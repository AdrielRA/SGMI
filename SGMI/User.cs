﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGMI
{
    public class User
    {
        private string name, email, telefone, credentials, passpassword;

        private string id;

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Credentials { get => credentials; set => credentials = value; }
        public string Passpassword { get => passpassword; set => passpassword = value; }        
    }
}
