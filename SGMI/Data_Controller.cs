﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            client = new MongoClient(str_Connection);
            database = client.GetDatabase("SGMI");
            collection_infratores = database.GetCollection<Infrator>("infratores");
            collection_users = database.GetCollection<User>("users");
        }

        public static void Save_Logged_User(User user)
        {
            keep_login = true; user_logged_save = user.Name;
            Save_Infos_To_Storage();
        }
        public static void Reset_Saved_Login()
        {
            keep_login = false;
            user_logged_save = "";
            Save_Infos_To_Storage();
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

        private static List<User> Load_Users() { return collection_users.Find(new BsonDocument()).ToList(); }
        public static void Add_User(User user)
        {
            var filter = Builders<User>.Filter.Eq("Name", user.Name);
            bool new_user = !collection_users.Find(filter).Any();

            if (new_user) { collection_users.InsertOne(user); }
            else
            {
                var update = Builders<User>.Update
                    .Set("Name", user.Name)
                    .Set("Email", user.Email)
                    .Set("Telefone", user.Telefone)
                    .Set("Credentials", user.Credentials)
                    .Set("Passpassword", user.Passpassword);

                collection_users.UpdateOne(filter, update);
            }
            if (!users.Contains(user)) { users.Add(user); }
            //Save_User_To_Storage();
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

        private static List<Infrator> Load_Infratores() { return collection_infratores.Find(new BsonDocument()).ToList(); }
        public static void Add_Infrator(Infrator infrator)
        {
            var filter = Builders<Infrator>.Filter.Eq("Rg", infrator.Rg);
            bool new_user = !collection_infratores.Find(filter).Any();

            if (new_user) { collection_infratores.InsertOne(infrator); }
            else
            {
                BsonArray infracoes_ = new BsonArray();
                foreach (var infra in infrator.Infrações)
                {
                    infracoes_.Add(new BsonDocument
                    {
                       { "infração_id", infra.Id},
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
            return user_logged != null;
        }

        public static void Create_Dir_data()
        {
            if (!Directory.Exists(path_data)) { Directory.CreateDirectory(path_data); }
        }
    }
}