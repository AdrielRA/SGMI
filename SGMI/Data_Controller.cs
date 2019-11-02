using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private static string path, path_data, path_users, path_infratores, path_infos;

        public static void Start_Controller()
        {
            path = Application.StartupPath + "\\";
            path_data = path + "files\\data\\";
            path_users = path_data + "users.json";
            path_infratores = path_data + "infratores.json";
            path_infos = path_data + "infos.json";

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

        public static void Save_Logged_User(User user)
        {
            keep_login = true; user_logged_save = user.Name; user_logged = user;
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

        private static List<User> Load_Users()
        {
            if (File.Exists(path_users))
            {
                using (StreamReader r = new StreamReader(path_users))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
            return null;
        }
        public static void Add_User(User user)
        {
            if (!users.Contains(user)) { users.Add(user); }
            Save_User_To_Storage();
        }
        public static void Remove_User(User user)
        {
            users.Remove(user);
            Save_User_To_Storage();
        }
        public static void Save_User_To_Storage()
        {
            Create_Dir_data();
            File.WriteAllText(path_users, JsonConvert.SerializeObject(users));
        }

        private static List<Infrator> Load_Infratores()
        {
            if (File.Exists(path_infratores))
            {
                using (StreamReader r = new StreamReader(path_infratores))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Infrator>>(json);
                }
            }
            return null;
        }
        public static void Add_Infrator(Infrator infrator)
        {
            if (!infratores.Contains(infrator)) { infratores.Add(infrator); }
            Save_Infrator_To_Storage();
        }
        public static void Remove_Infrator(Infrator infrator)
        {
            infratores.Remove(infrator);
            Save_Infrator_To_Storage();
        }
        public static void Save_Infrator_To_Storage()
        {
            Create_Dir_data();
            File.WriteAllText(path_infratores, JsonConvert.SerializeObject(infratores));
        }

        public static bool Validate_Login(User user)
        {
            return users.FirstOrDefault(u => u.Name == user.Name && u.Passpassword == user.Passpassword) != null;
        }

        public static void Create_Dir_data()
        {
            if (!Directory.Exists(path_data)) { Directory.CreateDirectory(path_data); }
        }
    }
}