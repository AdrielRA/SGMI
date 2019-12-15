using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;
using System.Net.NetworkInformation;
using System.Threading;

namespace SGMI
{
    public class Data_Controller
    {
        #region definições
        public enum Credencial : int
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
        #endregion

        #region variáveis
        public static List<User> users;
        public static List<Infrator> infratores;
        public static User user_logged;
        public static bool keep_login;
        public static string user_logged_save, path_anexos;
        private static string path, path_data, path_infos, id_user_logged;
        private static DateTime last_recheck;

        public const string str_Connection = "mongodb+srv://SGMI_User:SGMI2019@sgmicluster-boq9i.gcp.mongodb.net/test?retryWrites=true&w=majority";
        private static MongoClient client;
        public static IMongoDatabase database;
        private static IMongoCollection<Infrator> collection_infratores;
        public static IMongoCollection<User> collection_users;
        private static IMongoCollection<BsonDocument> collection_logged_users;
        public static IMongoCollection<Pdf_> collection_anexos;
        public static IMongoCollection<Infrator> Collection_Infratores { get => collection_infratores; }

        public static int tot_up = 0, tot_dow = 0, tot_up_ok = 0, tot_dow_ok = 0;
        public static List<string> paths_anexos_offline,
            uploading = new List<string>(),
            downloading = new List<string>(),
            Credenciais = new List<string>() { "INDEFINIDO", "PROFESSOR", "ADVOGADO", "POLICIAL", "DELEGADO", "PROMOTOR", "JUIZ" };
        private static List<Responsavel> responsaveis;

        public static List<Thread> threads_running = new List<Thread>();
        private static bool keep_running = true;

        #endregion

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
                        //id_user_to_remove = data.id_user_to_remove;

                        //if (!string.IsNullOrEmpty(id_user_to_remove))
                        //{
                        //    user_logged = users.FirstOrDefault(u => u.Id == id_user_to_remove);
                        //    r.Close();
                        //    Reset_Saved_Login();
                        //}
                        /*else { */user_logged = users.FirstOrDefault(u => u.Nome == user_logged_save); /*}*/
                    }
                    catch
                    {
                        r.Close();
                        Reset_Saved_Login();
                    }
                }
            }
            else { Save_Infos_To_Storage(); }
            
            if (user_logged != null)
            {
                Start_Thread(new Thread(() => Start_UserLogged_Delete_Watch()));
            }
        }

        public static void Start_Thread(Thread thread)
        {
            keep_running = true;
            if (!threads_running.Contains(thread)) threads_running.Add(thread);
            thread.IsBackground = true;
            thread.Start();
        }
        public static void Stop_Thread(Thread thread)
        {
            if (threads_running.Contains(thread)) threads_running.Remove(thread);
            thread.Interrupt();
            thread.Abort();
        }
        public static void Stop_All_Threads()
        {
            keep_running = false;
            //for (int i = 0; i < threads_running.Count; i++) { Stop_Thread(threads_running[i]); }
        }

        public static void Start_Infrator_Insert_Watch()
        {
            var pipeline = new EmptyPipelineDefinition<ChangeStreamDocument<Infrator>>()
                .Match(change =>
                    change.FullDocument.Nome != "" &&
                    change.OperationType == ChangeStreamOperationType.Insert);
            
            using (var cursor = collection_infratores.Watch(pipeline))
            {
                try
                {
                    while (cursor.MoveNext() && cursor.Current.Count() == 0 && keep_running) { }
                    var infrator_inserido = cursor.Current.First().FullDocument;

                    frm_Principal.instancia.Show_Notify("Infrator inserido!", "Nome: " + infrator_inserido.Nome, ToolTipIcon.Info);

                    infratores.Add(infrator_inserido);
                }
                catch { }

                if (keep_running) { Start_Thread(new Thread(() => Start_Infrator_Insert_Watch())); }
                Stop_Thread(Thread.CurrentThread);
            }
        }
        public static void Start_Infrator_Delete_Watch()
        {
            var pipeline = new EmptyPipelineDefinition<ChangeStreamDocument<Infrator>>()
                .Match(change =>
                    change.FullDocument.Nome != "" &&
                    change.OperationType == ChangeStreamOperationType.Delete);


            using (var cursor = collection_infratores.Watch(pipeline))
            {
                try
                {
                    while (cursor.MoveNext() && cursor.Current.Count() == 0 && keep_running) { }

                    Infrator infrator_removido = infratores.FirstOrDefault(i => i.Id.ToString().Contains(cursor.Current.First().DocumentKey["_id"].ToString()));

                    if (infrator_removido != null)
                    {
                        frm_Principal.instancia.Show_Notify("Infrator removido!", "Nome: " + infrator_removido.Nome, ToolTipIcon.Info);
                        infratores.Remove(infrator_removido);
                    }
                }
                catch { }
                if (keep_running) { Start_Thread(new Thread(() => Start_Infrator_Delete_Watch())); }
                Stop_Thread(Thread.CurrentThread);
            }
        }
        public static void Start_UserLogged_Delete_Watch()
        {
            var pipeline = new EmptyPipelineDefinition<ChangeStreamDocument<BsonDocument>>()
                .Match(change => change.OperationType == ChangeStreamOperationType.Delete);

            using (var cursor = collection_logged_users.Watch(pipeline))
            {
                try
                {
                    while (cursor.MoveNext() && cursor.Current.Count() == 0 && keep_running) { }

                    if (cursor.Current.First().DocumentKey["_id"].ToString() == id_user_logged)
                    {
                        frm_Menu.instancia.Desconectar();
                    }
                }
                catch { }
                if (keep_running) { Start_Thread(new Thread(() => Start_UserLogged_Delete_Watch())); }
                Stop_Thread(Thread.CurrentThread);
            }
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
            user_logged_save = id_user_logged = "";

            if (user_logged != null && Web_Tools.Conectado_A_Internet())
            {
                var deleteFilter = Builders<BsonDocument>.Filter.Eq("id_usuario", user_logged.Id);
                collection_logged_users.DeleteOne(deleteFilter);
            }
            //else if (user_logged != null) { id_user_to_remove = user_logged.Id; }

            Save_Infos_To_Storage();
        }
        public static void Save_Infos_To_Storage()
        {
            JObject json = new JObject();
            json.Add("keep_login", keep_login);
            json.Add("user_logged_save", user_logged_save);
            json.Add("last_recheck", last_recheck);
            //json.Add("id_user_to_remove", id_user_to_remove);
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
                Infrator infrator_from_mongo = collection_infratores.Find(i => i.Id == infrator.Id).FirstOrDefault();

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

                        collection_infratores.UpdateOne(i => i.Id == infrator.Id, update);

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
            if (infrator != null) { collection_infratores.DeleteOneAsync(i => i.Id == infrator.Id); }
            if (infratores.Contains(infrator)) { infratores.Remove(infrator); }
        }
        public static bool isEquals(Infrator infrator_from_mongo, Infrator infrator_original)
        {
            bool result = infrator_original != null && infrator_from_mongo != null &&
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
        public static async Task Clear_Anexos()
        {
            List<string> local_files = Directory.GetFiles(path_anexos, "*.pdf", SearchOption.TopDirectoryOnly).ToList(); // pega nome completo dos pdf's do PC
            local_files = local_files.Select(s => s.Replace(path_anexos, "")).ToList(); // apaga o C://... e deixa só o nome.pdf

            List<string> paths_from_mongo = new List<string>(); // pega nome dos pdf's do mongo
            using (var cursor = await collection_anexos.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    foreach (Pdf_ pdf in cursor.Current) paths_from_mongo.Add(pdf.Filename);
                }
            }

            List<string> files_to_clear = local_files.Except(paths_from_mongo).ToList(); // pega todos os nomes que estão no PC, exceto os q ainda estão no mongo

            foreach (string file_name in files_to_clear) // exclui os que tem que ser deletados
            {
                if (File.Exists(path_anexos + file_name)) { File.Delete(path_anexos + file_name); }
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
            if (Web_Tools.Conectado_A_Internet())
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
                                if (last_recheck.ToUniversalTime() <= DateTime.Now.AddDays(-1).ToUniversalTime())
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
                                var res = MessageBox.Show("Este usuário já está logado!\n\nDeseja desconectar de\ntodos os dispositivos?", "Alerta:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                
                                if (res == DialogResult.Yes)
                                {
                                    if (user_logged != null)
                                    {
                                        frm_Verificação verificação = new frm_Verificação(user_logged.Email);
                                        verificação.ShowDialog();

                                        if (verificação.verificado) { Reset_Saved_Login(); }
                                    }
                                }
                                user_logged = null;
                            }
                            else
                            {
                                BsonDocument login_user = new BsonDocument();
                                login_user.SetElement(new BsonElement("id_usuario", user_logged.Id));
                                login_user.SetElement(new BsonElement("ultimo_acesso", DateTime.Now));

                                collection_logged_users.InsertOne(login_user);

                                id_user_logged = login_user["_id"].ToString();
                            }
                        }
                    }
                    else
                    {
                        if (user_logged_from_mongo != null)
                        {
                            id_user_logged = user_logged_from_mongo["_id"].ToString();

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
            else { Web_Tools.Show_Net_Error(); return false; }
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
        public static string Mask_RG(string rg) { return Dynamic_Mask(rg, "00.000.000", 8); }
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
        public static bool Conectado_A_Internet()
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.google.com");

            try
            {
                using (var response = myWebRequest.GetResponse()) { }
                return true;
            }
            catch { return false; }
        }
        public static void Show_Net_Error()
        {
            MessageBox.Show("Sua conexão caiu!\n\nVerifique sua internet\ne tente novamente...", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show_Net_Start_Error()
        {
            MessageBox.Show("Não foi possível se conectar!\n\nVerifique sua conexão...", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public async Task Send_Email(User user, string email_destino, string assunto, string descrição)
        {
            bool enviada;
            if (Conectado_A_Internet())
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
            else { Show_Net_Error(); }
        }

        static public async Task Send_Verification(string cod, string email_destino)
        {
            bool enviada;
            if (Conectado_A_Internet())
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
            else { Show_Net_Error(); }
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

    public class Security_Controller
    {
        public static int[] podem_cadastrar = new int[4]
        {
            //(int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            //(int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        public static int[] podem_consultar = new int[6]
        {
            (int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        public static int[] podem_ver_perfil = new int[5]
        {
            //(int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        public static int[] podem_salvar_edição = new int[4]
        {
            //(int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            //(int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        public static int[] podem_ver_anexos = new int[5]
        {
            //(int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        public static int[] podem_editar_anexos = new int[5]
        {
            //(int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };

        public static void Show_Alert()
        {
            MessageBox.Show("Infelizmente você não tem\npermissão para acessar\neste recurso no momento!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

}