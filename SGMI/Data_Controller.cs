using Bunifu.Framework.UI;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SGMI
{
    public class Data_Controller
    {
        public static List<User> users;
        public static List<Infrator> infratores;
        public static User user_logged;
        public static bool keep_login;
        public static string user_logged_save;
        private static string path, path_data, path_anexos, path_infos;

        public const string str_Connection = "mongodb+srv://SGMI_User:SGMI2019@sgmicluster-boq9i.gcp.mongodb.net/test?retryWrites=true&w=majority";
        private static MongoClient client;
        private static IMongoDatabase database;
        private static IMongoCollection<Infrator> collection_infratores;
        private static IMongoCollection<User> collection_users;
        private static IMongoCollection<BsonDocument> collection_logged_users;

        public static IMongoCollection<Infrator> Collection_Infratores { get => collection_infratores; }

        public static void Start_Controller()
        {
            path = Application.StartupPath + "\\";
            path_data = path + "files\\data\\";
            path_anexos = path + "files\\anexos\\";
            path_infos = path_data + "infos.json";

            Connect_To_Mongo();

            users = Load_Users();
            if (users == null) users = new List<User>();

            infratores = Load_Infratores();
            if (infratores == null) infratores = new List<Infrator>();

            if (File.Exists(path_infos))
            {
                using (StreamReader r = new StreamReader(path_infos))
                {
                    try
                    {
                        string json = r.ReadToEnd();
                        dynamic data = JObject.Parse(json);
                        keep_login = data.keep_login;
                        user_logged_save = data.user_logged_save;

                        user_logged = users.FirstOrDefault(u => u.Name == user_logged_save);
                    }
                    catch
                    {
                        r.Close();
                        Reset_Saved_Login();
                    }
                }
            }
            else { Save_Infos_To_Storage(); }
        }

        private static void Connect_To_Mongo()
        {
            try
            {
                client = new MongoClient(str_Connection);
                database = client.GetDatabase("SGMI");
                collection_infratores = database.GetCollection<Infrator>("infratores");
                collection_users = database.GetCollection<User>("users");
                collection_logged_users = database.GetCollection<BsonDocument>("logged_users");
            }
            catch
            {
                MessageBox.Show("Não foi possível se conectar\nao Banco de Dados", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Save_Logged_User(User user)
        {
            keep_login = true;
            user_logged_save = user.Name;
            Save_Infos_To_Storage();
        }
        public static void Reset_Saved_Login()
        {
            keep_login = false;
            user_logged_save = "";
            Save_Infos_To_Storage();

            if (user_logged != null)
            {
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("id_usuario", user_logged.Id);
                collection_logged_users.DeleteOne(deleteFilter);
            }


        }
        public static void Save_Infos_To_Storage()
        {
            JObject json = new JObject();
            json.Add("keep_login", keep_login);
            json.Add("user_logged_save", user_logged_save);
            Create_Dir_data();
            if (!File.Exists(path_data + @"\infos.json")) { FileStream file = File.Create(path_data + @"\infos.json"); file.Close(); }
            FileInfo myFile = new FileInfo(path_data + @"\infos.json");
            if ((myFile.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                myFile.Attributes &= ~FileAttributes.Hidden;
            }
            File.WriteAllText(path_data + @"\infos.json", JsonConvert.SerializeObject(json));
            myFile.Attributes |= FileAttributes.Hidden;
        }

        private static List<User> Load_Users()
        {
            try { return collection_users.Find(new BsonDocument()).ToList(); }
            catch
            {
                MessageBox.Show("Não foi possível\ncarregar usuários!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void Add_User(User user)
        {
            var filter = Builders<User>.Filter.Eq("Name", user.Name);
            bool new_user = !collection_users.Find(filter).Any();

            if (new_user) { collection_users.InsertOne(user); }
            else
            {
                User user_from_mongo = collection_users.Find(filter).FirstOrDefault();
                if (user_from_mongo.Equals(user))
                {
                    var update = Builders<User>.Update
                    .Set("Name", user.Name)
                    .Set("Email", user.Email)
                    .Set("Telefone", user.Telefone)
                    .Set("Credentials", user.Credentials)
                    .Set("Passpassword", user.Passpassword);

                    collection_users.UpdateOne(filter, update);
                }
                else
                {
                    MessageBox.Show("Existem inconsistências na informação\n\nPor favor reinicie o sistema\ne tente novamente!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!users.Contains(user)) { users.Add(user); }
        }
        public static void Remove_User(User user)
        {
            bool exists = !collection_users.Find(Builders<User>.Filter.Eq("Name", user.Name)).Any();
            if (exists)
            {
                var deleteFilter = Builders<User>.Filter.Eq("Name", user.Name);
                collection_users.DeleteOne(deleteFilter);
            }
            //users.Remove(user);
            //Save_User_To_Storage();
        }

        private static List<Infrator> Load_Infratores()
        {
            try { return collection_infratores.Find(new BsonDocument()).ToList(); }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível carregar\ndados dos infratores!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void Add_Infrator(Infrator infrator, Infrator infrator_original)
        {
            bool new_user = infrator_original == null;

            if (new_user)
            {
                try
                {
                    collection_infratores.InsertOne(infrator);
                    MessageBox.Show("Infrator salvo!");
                }
                catch { }
            }
            else
            {
                var filter = Builders<Infrator>.Filter.Eq("_id", infrator.Id);
                Infrator infrator_from_mongo = collection_infratores.Find(filter).FirstOrDefault();

                if (isEquals(infrator_from_mongo, infrator_original))
                {
                    try
                    {
                        BsonArray infracoes_ = new BsonArray();
                        foreach (var infra in infrator.Infrações)
                        {
                            infracoes_.Add(new BsonDocument
                    {
                       { "_id", infra.Id},
                       { "Descrição", infra.Descrição},
                       { "Data_ocorrência", infra.Data_ocorrência },
                       { "Data_registro", infra.Data_registro }
                    });
                        }

                        var update = Builders<Infrator>.Update
                            .Set("Nome", infrator.Nome)
                            .Set("Cpf", infrator.Cpf)
                            .Set("Mãe", infrator.Mãe)
                            .Set("Logradouro", infrator.Logradouro)
                            .Set("Num_residência", infrator.Num_residência)
                            .Set("Bairro", infrator.Bairro)
                            .Set("Cidade", infrator.Cidade)
                            .Set("Uf", infrator.Uf)
                            .Set("Sexo", infrator.Sexo)
                            .Set("Data_nascimento", infrator.Data_nascimento)
                            .Set("Data_registro", infrator.Data_registro)
                            .Set("Infrações", infracoes_);

                        collection_infratores.UpdateOne(filter, update);

                        MessageBox.Show("Infrator salvo!");
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível salvar!\n\nVerifique todos os\ncampos e tente novamente!");
                    }
                }
                else
                {
                    MessageBox.Show("Existem inconsistências na informação\n\nPor favor reinicie o sistema\ne tente novamente!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (!infratores.Contains(infrator)) { infratores.Add(infrator); }
        }
        public static void Remove_Infrator(Infrator infrator)
        {
            bool exists = !collection_infratores.Find(Builders<Infrator>.Filter.Eq("Rg", infrator.Rg)).Any();
            if (exists)
            {
                var deleteFilter = Builders<Infrator>.Filter.Eq("Rg", infrator.Rg);
                collection_infratores.DeleteOne(deleteFilter);
            }
            //infratores.Remove(infrator);
            //Save_Infrator_To_Storage();
        }
        public static bool isEquals(Infrator infrator_from_mongo, Infrator infrator_original)
        {
            bool result = infrator_original != null &&
                    infrator_original.Nome == infrator_from_mongo.Nome &&
                    infrator_original.Cpf == infrator_from_mongo.Cpf &&
                    infrator_original.Rg == infrator_from_mongo.Rg &&
                    infrator_original.Mãe == infrator_from_mongo.Mãe &&
                    infrator_original.Logradouro == infrator_from_mongo.Logradouro &&
                    infrator_original.Num_residência == infrator_from_mongo.Num_residência &&
                    infrator_original.Bairro == infrator_from_mongo.Bairro &&
                    infrator_original.Cidade == infrator_from_mongo.Cidade &&
                    infrator_original.Uf == infrator_from_mongo.Uf &&
                    infrator_original.Sexo == infrator_from_mongo.Sexo &&
                    infrator_original.Data_nascimento == infrator_from_mongo.Data_nascimento &&
                    infrator_original.Data_registro == infrator_from_mongo.Data_registro &&
                    infrator_original.Infrações.Count == infrator_from_mongo.Infrações.Count;

            if (result)
            {
                bool inf_result = true;
                for (int i = 0; i < infrator_from_mongo.Infrações.Count; i++)
                {
                    try
                    {
                        Infração infração_mongo = infrator_from_mongo.Infrações[i],
                            infração_original = infrator_original.Infrações[i];

                        inf_result = infração_mongo.Descrição == infração_original.Descrição &&
                            infração_mongo.Data_ocorrência == infração_original.Data_ocorrência &&
                            infração_mongo.Data_registro == infração_original.Data_registro;
                        if (!inf_result) break;
                    }
                    catch { inf_result = false; break; }
                }
                result = result && inf_result;
            }

            return result;
        }
        public static void Add_Anexo(ObjectId id_infração, string fileName, string newFileName)
        {
            var fileBytes = File.ReadAllBytes(fileName);
            var collection = database.GetCollection<BsonDocument>("anexos");

            BsonDocument baseDoc = new BsonDocument();
            baseDoc.SetElement(new BsonElement("pdfContent", fileBytes));

            baseDoc.SetElement(new BsonElement("_id", Guid.NewGuid()));
            baseDoc.SetElement(new BsonElement("filename", newFileName));
            baseDoc.SetElement(new BsonElement("infração_id", id_infração));
            collection.InsertOne(baseDoc);
        }
        public static void Remove_Anexo(ObjectId id_infração, string path_anexo)
        {
            string filename = path_anexo.Split('\\').LastOrDefault();

            if (File.Exists(path_anexo)) { File.Delete(path_anexo); }
            var collection = database.GetCollection<BsonDocument>("anexos");
            var filter = Builders<BsonDocument>
                .Filter.And(Builders<BsonDocument>
                .Filter.Eq("infração_id", id_infração), Builders<BsonDocument>
                .Filter.Eq("filename", filename));

            collection.DeleteOne(filter);
        }
        public static string[] Read_Anexos(ObjectId infração_id)
        {
            var collection = database.GetCollection<BsonDocument>("anexos");
            var filter_id = Builders<BsonDocument>.Filter.Eq("infração_id", infração_id);
            var docs = collection.Find(filter_id).ToEnumerable();

            List<string> paths = new List<string>();

            if (!Directory.Exists(path_anexos)) { Directory.CreateDirectory(path_anexos); }

            foreach (var doc in docs)
            {
                string save_path = path_anexos + doc.GetElement("filename").Value.ToString();
                if (!File.Exists(save_path))
                {
                    byte[] fileArray = doc.GetElement("pdfContent").Value.AsByteArray;
                    File.WriteAllBytes(save_path, fileArray);
                }
                paths.Add(save_path);
            }
            return paths.ToArray();
        }

        public static bool Validate_Login(User user)
        {
            user_logged = users.FirstOrDefault(u => u.Name == user.Name && u.Passpassword == user.Passpassword);

            bool validar = user_logged != null;

            if (validar && !keep_login)
            {
                var filter_id = Builders<BsonDocument>.Filter.Eq("id_usuario", user_logged.Id);
                var docs = collection_logged_users.Find(filter_id).ToEnumerable();

                validar = !(docs.Count() > 0);

                if (docs.Count() > 0)
                {
                    MessageBox.Show("Este usuário já está logado!", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // add la
                    BsonDocument login_user = new BsonDocument();
                    login_user.SetElement(new BsonElement("id_usuario", user_logged.Id));

                    collection_logged_users.InsertOne(login_user);

                }
            }

            return validar;
        }

        public static void Create_Dir_data()
        {
            if (!Directory.Exists(path_data)) { Directory.CreateDirectory(path_data); }
        }

        public static TClone Clone<TClone>(object sourceItem) where TClone : new()
        {
            var convertProperties = TypeDescriptor.GetProperties(typeof(TClone)).Cast<PropertyDescriptor>();
            var entityProperties = TypeDescriptor.GetProperties(sourceItem).Cast<PropertyDescriptor>();

            TClone clone = new TClone();

            foreach (var entityProperty in entityProperties)
            {
                var property = entityProperty;
                var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == property.Name);
                if (convertProperty != null)
                {
                    convertProperty.SetValue(clone, Convert.ChangeType(entityProperty.GetValue(sourceItem), convertProperty.PropertyType));
                }
            }

            return clone;
        }
    }

    public class Data_Formater
    {
        public static void Limiter_Number(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.End)
            {
                e.Handled = true;
            }
        }
        public static void Limiter_Sexo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'F' &&
                e.KeyChar != 'f' &&
                e.KeyChar != 'M' &&
                e.KeyChar != 'm' &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.End) { e.Handled = true; }
        }
        public static void Limiter_Text(object sender, KeyPressEventArgs e, bool with_points)
        {
            if (!char.IsLetter(e.KeyChar) && (!with_points || e.KeyChar != '-' && e.KeyChar != '.') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.End)
            {
                e.Handled = true;
            }
        }

        public static string Mask_CPF(string cpf) { return Dynamic_Mask(cpf, "000.000.000-00", 11); }
        public static string Mask_RG(string rg) { return Dynamic_Mask(rg, "00.000.000", 7); }
        public static string Mask_Tel(string tel)
        {
            return Dynamic_Mask(tel, "(00) 0 0000-0000", 11);
        }
        public static string Just_Numbers(string str)
        {
            return Regex.Replace(str, "[^0-9]", string.Empty);
        }
        private static string Dynamic_Mask(string str, string mask, int digits)
        {

            if (!string.IsNullOrEmpty(str))
            {
                string numbers = Just_Numbers(str);
                if (numbers.Length > 0)
                {

                    if (numbers.Length <= digits)
                    {
                        int pos = 0;
                        string result = "";
                        try
                        {
                            foreach (char c in mask)
                            {
                                if (c == '0')
                                {
                                    result += numbers[pos];
                                    pos++;
                                }
                                else result += c;
                            }
                        }
                        catch
                        {
                            try
                            {
                                while (result.Last() == '.' || result.Last() == '-' || result.Last() == '(' || result.Last() == ')' ||result.Last() == ' ')
                                {
                                    result = result.Remove(result.LastIndexOf(result.Last()));
                                }
                            }
                            catch { }
                        }
                        return result;
                    }
                    return str;
                }
                return "";
            }
            return str;
        }
    }

    public class Data_Validate
    {
        public static bool Email(string email)
        {
            Regex rg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return rg.IsMatch(email);
        }
    }
}