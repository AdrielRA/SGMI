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
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;
using MongoDB.Driver.GridFS;
using System.Threading;

namespace SGMI
{
    public class Data_Controller
    {
        public static List<User> users;
        public static List<Infrator> infratores;
        public static User user_logged;
        public static bool keep_login;
        public static string user_logged_save, path_anexos;
        private static string path, path_data, path_infos;
        private static DateTime last_recheck;

        public const string str_Connection = "mongodb+srv://SGMI_User:SGMI2019@sgmicluster-boq9i.gcp.mongodb.net/test?retryWrites=true&w=majority";
        private static MongoClient client;
        private static IMongoDatabase database;
        private static IMongoCollection<Infrator> collection_infratores;
        public static IMongoCollection<User> collection_users;
        private static IMongoCollection<BsonDocument> collection_logged_users;
        private static IMongoCollection<Pdf_> collection_anexos;
        public static IMongoCollection<Infrator> Collection_Infratores { get => collection_infratores; }

        public static int tot_up = 0, tot_dow = 0, tot_up_ok = 0, tot_dow_ok = 0;
        public static List<string> uploading = new List<string>(), downloading = new List<string>();

        public static List<string> paths_anexos_offline;

        public static List<string> Credenciais = new List<string>() { "INDEFINIDO", "PROFESSOR", "ADVOGADO", "POLICIAL", "DELEGADO", "PROMOTOR", "JUIZ" };
        public enum Credencial:int
        {
            Indefinido = 0,
            Professor = 1,
            Advogado = 2,
            Policial = 3,
            Delegado = 4,
            Promotor = 5,
            Juiz = 6
        }

        public struct Sys_Email
        {
            public const string email = "sysGI@hotmail.com", senha = "@d1minL0gin1";
        }
        private struct Responsavel
        {
            public string email;
            public int categoria;
        }
        private static List<Responsavel> responsaveis;

        public static void Start_Controller()
        {
            path = Application.StartupPath + "\\";
            path_data = path + "files\\data\\";
            path_anexos = path + "files\\anexos\\";
            path_infos = path_data + "infos.json";

            Load_Responsaveis();

            Connect_To_Mongo();

            users = Load_Users();
            if (users == null) users = new List<User>();

            infratores = Load_Infratores();
            if (infratores == null) infratores = new List<Infrator>();

            last_recheck = DateTime.Now.AddDays(-2);

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
                        last_recheck = data.last_recheck;

                        user_logged = users.FirstOrDefault(u => u.Nome == user_logged_save);
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


        public static bool Verific_Existence_Email(string email)
        {

            bool ja_existe = false;
            try
            {
                ja_existe = collection_users.Find(u =>
                    u.Email == email
                ).Any();
            }
            catch { }

            return ja_existe;

        }
        private static void Load_Responsaveis()
        {
            responsaveis = new List<Responsavel>();
            responsaveis.Add(new Responsavel() { categoria = 1, email = "adrieldeveloper@hotmail.com" });
            responsaveis.Add(new Responsavel() { categoria = 2, email = "lucasrobert994@gmail.com" });
            responsaveis.Add(new Responsavel() { categoria = 3, email = "adrieldeveloper@hotmail.com" });
            responsaveis.Add(new Responsavel() { categoria = 4, email = "lucasrobert994@gmail.com" });
            responsaveis.Add(new Responsavel() { categoria = 5, email = "adrieldeveloper@hotmail.com" });
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
                collection_anexos = database.GetCollection<Pdf_>("anexos");
            }
            catch
            {
                MessageBox.Show("Não foi possível se conectar\nao Banco de Dados", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Save_Logged_User(User user)
        {
            keep_login = true;
            user_logged_save = user.Nome;
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
            json.Add("last_recheck", last_recheck);
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
        public static bool Add_User(User user)
        {
            bool result = false;
            try
            {
                if (!Exists_User(user))
                {
                    collection_users.InsertOne(user);
                    Web_Tools.Send_Email(user, responsaveis.FirstOrDefault(r => r.categoria == Math.Abs(user.Credencial)).email, "Verificação de Usuário - " + user.Id.ToString(), "Deseja liberar o acesso para este usuário?");

                    MessageBox.Show("Usuário Salvo!");
                    result = true;
                }
                else
                {
                    User user_from_mongo = collection_users.Find(u => u.Id == user.Id).SingleOrDefault();
                    if (isEquals(user_from_mongo, user))
                    {
                        collection_users.ReplaceOne(u => u.Id == user.Id, user);
                        MessageBox.Show("Usuário Liberado!");
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Existem inconsistências na informação\n\nPor favor reinicie o sistema\ne tente novamente!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (!users.Contains(user)) { users.Add(user); }

                return result;
            }
            catch { return false; }
        }
        public static void Remove_User(User user)
        {
            bool exists = collection_users.Find(u => u.Id == user.Id).Any();
            if (exists) { collection_users.DeleteOne(u => u.Id == user.Id); }
            if (users.Contains(user)) { users.Remove(user); }
        }
        public static bool Exists_User(User user)
        {
            bool ja_existe = false;
            try
            {
                ja_existe = collection_users.Find(u =>
                    u.Nome == user.Nome &&
                    u.Telefone == user.Telefone &&
                    u.Email == user.Email &&
                    u.Passpassword == user.Passpassword
                ).Any();
            }
            catch { }

            return ja_existe;
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
        public static bool isEquals(User user_from_mongo, User user_original)
        {
            bool result = user_original != null && user_from_mongo != null &&
                    user_original.Nome == user_from_mongo.Nome &&
                    user_original.Email == user_from_mongo.Email &&
                    user_original.Telefone == user_from_mongo.Telefone &&
                    user_original.Passpassword == user_from_mongo.Passpassword;

            return result;
        }

        public static async Task Add_Anexo(ObjectId id_infração, string fileName, string newFileName)
        {
            if (!uploading.Contains(newFileName))
            {
                uploading.Add(newFileName);
                tot_up++;
                frm_Principal.instancia.Transferences_Visible(true);
                frm_Principal.instancia.Update_Status_Upload(tot_up_ok, tot_up);

                Pdf_ pdf = new Pdf_()
                {
                    Filename = newFileName,
                    Infração_id = id_infração,
                    PdfContent = File.ReadAllBytes(fileName)
                };

                if (!Directory.Exists(path_anexos)) { Directory.CreateDirectory(path_anexos); }

                string save_path = path_anexos + pdf.Filename;
                if (!File.Exists(save_path)) { File.WriteAllBytes(save_path, pdf.PdfContent); }
                paths_anexos_offline.Add(pdf.Filename);

                await collection_anexos.InsertOneAsync(pdf);
                
                tot_up_ok++;
                frm_Principal.instancia.Update_Status_Upload(tot_up_ok, tot_up);
                frm_Principal.instancia.Lbl_Upload.Refresh();

                if (tot_up == tot_up_ok)
                {
                    tot_up = tot_up_ok = 0;
                    frm_Principal.instancia.Update_Status_Upload(tot_up_ok, tot_up);
                    frm_Principal.instancia.Lbl_Upload.Refresh();

                    if (tot_dow == 0 && tot_dow_ok == 0)
                    {
                        frm_Principal.instancia.Transferences_Visible(false);
                    }
                }
                uploading.Remove(newFileName);
            }

            if (frm_Anexo.instancia != null) { frm_Anexo.instancia.Fechar(); }
            if (frm_Detalhes.instancia != null) { frm_Detalhes.instancia.lb_Anexos_Update(id_infração); }

        }
        public static void Remove_Anexo(ObjectId id_infração, string filename)
        {
            if (File.Exists(path_anexos + filename)) { File.Delete(path_anexos + filename); }
            if (paths_anexos_offline.Contains(filename)) { paths_anexos_offline.Remove(filename); }

            collection_anexos.DeleteOneAsync(p => p.Infração_id == id_infração && p.Filename == filename);
        }
        public static async Task Remove_Todos_Anexos(ObjectId id_infração)
        {
            var options = new FindOptions<Pdf_>()
            {
                Projection = Builders<Pdf_>.Projection
                    .Include(p => p.Filename)
            };

            List<string> paths_to_delete = new List<string>(); // pega nome dos pdf's
            using (var cursor = await collection_anexos.FindAsync(p => p.Infração_id == id_infração, options))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (Pdf_ pdf in batch) paths_to_delete.Add(pdf.Filename);
                }
            }

            foreach (string file in paths_to_delete)
            {
                if (File.Exists(path_anexos + file)) { File.Delete(path_anexos + file); }
                collection_anexos.DeleteOneAsync(p => p.Infração_id == id_infração && p.Filename == file);
            }
        }

        public static async Task Read_Anexos(ObjectId infração_id)
        {
            if (!downloading.Contains(infração_id.ToString()))
            {
                downloading.Add(infração_id.ToString());

                if (!Directory.Exists(path_anexos)) { Directory.CreateDirectory(path_anexos); }

                List<string> local_files = new List<string>();
                foreach (string full_path in Directory.GetFiles(path_anexos, "*.pdf", SearchOption.TopDirectoryOnly))
                {
                    local_files.Add(full_path.Split('\\').LastOrDefault());
                }

                var options = new FindOptions<Pdf_>()
                {
                    Projection = Builders<Pdf_>.Projection
                    .Include(p => p.Filename)
                };

                List<string> paths = new List<string>(); // pega nome dos pdf's
                using (var cursor = await collection_anexos.FindAsync(p => p.Infração_id == infração_id, options))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        foreach (Pdf_ pdf in batch) paths.Add(pdf.Filename);
                    }
                }

                tot_dow += paths.Count - local_files.Where(p => paths.Contains(p)).Count();
                frm_Principal.instancia.Transferences_Visible(true);
                frm_Principal.instancia.Update_Status_Download(tot_dow_ok, tot_dow);

                List<Pdf_> downloaded_pdfs = new List<Pdf_>(); // faz download dos pdf's um por um...
                foreach (string file_to_download in paths.Where(p => !local_files.Contains(p)))
                {
                    using (var cursor = await collection_anexos.FindAsync(p => p.Infração_id == infração_id && p.Filename == file_to_download))
                    {
                        while (await cursor.MoveNextAsync())
                        {
                            var batch = cursor.Current;
                            foreach (Pdf_ pdf in batch)
                            {
                                downloaded_pdfs.Add(pdf);
                                tot_dow_ok++;
                                frm_Principal.instancia.Update_Status_Download(tot_dow_ok, tot_dow);
                                frm_Principal.instancia.Lbl_Download.Refresh();
                            }
                        }
                    }
                }

                foreach (var pdf in downloaded_pdfs)
                {
                    string save_path = path_anexos + pdf.Filename;
                    if (!File.Exists(save_path))
                    {
                        byte[] fileArray = pdf.PdfContent;
                        File.WriteAllBytes(save_path, fileArray);
                    }
                }

                paths_anexos_offline = paths;

                if (tot_dow == tot_dow_ok)
                {
                    tot_dow = tot_dow_ok = 0;
                    frm_Principal.instancia.Update_Status_Download(tot_dow_ok, tot_dow);
                    frm_Principal.instancia.Lbl_Download.Refresh();

                    if (tot_up == 0 && tot_up_ok == 0)
                    {
                        frm_Principal.instancia.Transferences_Visible(false);
                    }
                }

                downloading.Remove(infração_id.ToString());

                if (frm_Anexo.instancia != null) { frm_Anexo.instancia.Fechar(); }
            }
            else 
            {
                MessageBox.Show("Aguarde a sincronização dos\nanexos ser concluída!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static bool Validate_Login(User user)
        {
            user_logged = collection_users.Find(u => u.Nome == user.Nome && u.Passpassword == user.Passpassword).SingleOrDefault();

            bool validar = user_logged != null;

            if (validar)
            {
                var filter_id = Builders<BsonDocument>.Filter.Eq("id_usuario", user_logged.Id);
                var user_logged_from_mongo = collection_logged_users.Find(filter_id).SingleOrDefault();

                if (!keep_login)
                {
                    validar = user_logged.Credencial > 0;

                    if (!validar)
                    {
                        string situação = Web_Tools.Verify_User_Email(user_logged);

                        if (situação.ToUpper().Contains("SIM"))
                        {
                            user_logged.Credencial = Math.Abs(user_logged.Credencial);
                            validar = Add_User(user_logged); // update;
                        }
                        else if (situação.ToUpper().Contains("NÃO"))
                        {
                            Remove_User(user_logged);
                            MessageBox.Show("Seu acesso não foi liberado!", "Info:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if(last_recheck.ToUniversalTime() <= DateTime.Now.AddDays(-1).ToUniversalTime())
                            {
                                var resp = MessageBox.Show("Este usuário ainda\nnão foi verificado!\n\nSolicitar reverificação?", "Alerta:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (resp == DialogResult.Yes)
                                {
                                    if (user_logged != null)
                                    {
                                        Web_Tools.Send_Email(user_logged, responsaveis.FirstOrDefault(r => r.categoria == Math.Abs(user_logged.Credencial)).email, "Verificação de Usuário - " + user_logged.Id.ToString(), "Deseja liberar o acesso para este usuário?");

                                        last_recheck = DateTime.Now;
                                        Save_Infos_To_Storage();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Não foi possivel solicitar\nsua reverificação pois este\nusúario não consta mais\nna base de dados!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este usuário ainda\nnão foi verificado!\n\nTente uma reverificação amanhã!", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

                    if (validar)
                    {
                        validar = user_logged_from_mongo == null;

                        if (!validar)
                        {
                            MessageBox.Show("Este usuário já está logado!", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            BsonDocument login_user = new BsonDocument();
                            login_user.SetElement(new BsonElement("id_usuario", user_logged.Id));
                            login_user.SetElement(new BsonElement("ultimo_acesso", DateTime.Now));

                            collection_logged_users.InsertOne(login_user);
                        }
                    }
                }
                else
                {
                    if (user_logged_from_mongo != null)
                    {
                        DateTime data_limite = DateTime.Now.AddDays(-3).ToUniversalTime();
                        validar = user_logged_from_mongo["ultimo_acesso"].ToUniversalTime() >= data_limite;

                        if (validar)
                        {
                            user_logged_from_mongo["ultimo_acesso"] = DateTime.Now;
                            collection_logged_users.ReplaceOne(filter_id, user_logged_from_mongo);
                        }
                    }
                }
            }
            else { MessageBox.Show("Não foi possível realizar o login!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
        public static void Limiter_Text(object sender, KeyPressEventArgs e, bool with_spaces, bool with_points)
        {
            if (!char.IsLetter(e.KeyChar) && (!with_spaces || e.KeyChar != ' ') && (!with_points || e.KeyChar != '-' && e.KeyChar != '.') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.End)
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
                                while (result.Last() == '.' || result.Last() == '-' || result.Last() == '(' || result.Last() == ')' || result.Last() == ' ')
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


    public class Web_Tools
    {
        #region check_Connection
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        #endregion
        public static bool Conectado_A_Internet()
        {
            bool returnValue;
            try
            {
                int Desc;
                returnValue = InternetGetConnectedState(out Desc, 0);
            }
            catch
            {
                returnValue = false;
            }
            return returnValue;
        }

        static public async Task Send_Email(User user, string email_destino, string assunto, string descrição)
        {
            bool enviada;
            if (!Conectado_A_Internet())
            {
                MessageBox.Show("Verifique sua conexão\ncom a internet.", "Sem internet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Enviando solicitação\nde acesso!", "Enviando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    MailMessage e_mail = new MailMessage(Data_Controller.Sys_Email.email, email_destino);
                    e_mail.Subject = assunto;
                    e_mail.SubjectEncoding = Encoding.UTF8;
                    e_mail.IsBodyHtml = false;
                    e_mail.Body = "Usuário: " + user.Nome + "\nContato: " + user.Email + "\nCategoria: " + Data_Controller.Credenciais[Math.Abs(user.Credencial)] + "\n\n" + descrição;
                    e_mail.BodyEncoding = Encoding.UTF8;
                    e_mail.Priority = System.Net.Mail.MailPriority.High;
                    SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(Data_Controller.Sys_Email.email, Data_Controller.Sys_Email.senha);

                    await smtp.SendMailAsync(e_mail);
                    enviada = true;
                }
                catch { enviada = false; }
                if (enviada)
                {
                    MessageBox.Show("Recebemos sua requisição.\nAguarde pela liberação.\n\nObrigado pela paciência!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel solicitar.\nVerifique sua conexão com a internet." +
                        "Tente novamente mais tarde!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static public async Task Send_Verification(string cod, string email_destino)
        {
            bool enviada;
            if (!Conectado_A_Internet())
            {
                MessageBox.Show("Verifique sua conexão\ncom a internet.", "Sem internet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Enviando código\nde verificação!", "Enviando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    MailMessage e_mail = new MailMessage(Data_Controller.Sys_Email.email, email_destino);
                    e_mail.Subject = "Código de Verificação";
                    e_mail.SubjectEncoding = Encoding.UTF8;
                    e_mail.IsBodyHtml = false;
                    e_mail.Body = "CÓDIGO: " + cod;
                    e_mail.BodyEncoding = Encoding.UTF8;
                    e_mail.Priority = System.Net.Mail.MailPriority.High;
                    SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(Data_Controller.Sys_Email.email, Data_Controller.Sys_Email.senha);

                    await smtp.SendMailAsync(e_mail);
                    enviada = true;
                }
                catch { enviada = false; }
                if (enviada)
                {
                    MessageBox.Show("Código enviado!.\nVerifique sua caixa de e-mails!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel enviar seu código.\nVerifique sua conexão com a internet\nou tente com outro e-mail mais tarde!",
                        "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string Verify_User_Email(User user)
        {
            string result = "";
            try
            {
                MailServer oServer = new MailServer("imap-mail.outlook.com",
                        Data_Controller.Sys_Email.email,
                        Data_Controller.Sys_Email.senha,
                        ServerProtocol.Imap4);

                oServer.SSLConnection = true;
                oServer.Port = 993;

                MailClient oClient = new MailClient("TryIt");
                oClient.Connect(oServer);

                MailInfo[] infos = oClient.GetMailInfos();
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];

                    Mail oMail = oClient.GetMail(info);

                    if (oMail.Subject.Contains(user.Id))
                    {
                        result = oMail.TextBody.ToUpper().Contains("SIM") ? "SIM" : "NÃO";
                        oClient.Delete(info);
                        break;
                    }
                }
                oClient.Quit();
            }
            catch { }
            return result;
        }
    }

    public class Pdf_
    {
        private ObjectId id, infração_id;
        private string filename;
        private byte[] pdfContent;

        public ObjectId Id { get => id; set => id = value; }
        public ObjectId Infração_id { get => infração_id; set => infração_id = value; }
        public byte[] PdfContent { get => pdfContent; set => pdfContent = value; }
        public string Filename { get => filename; set => filename = value; }
    }
}