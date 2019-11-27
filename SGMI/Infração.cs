using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SGMI
{
    public class Infração
    {
        private string descrição;
        private DateTime data_ocorrência, data_registro;

        private ObjectId id;

        public Infração() { Id = ObjectId.GenerateNewId(); }

        public ObjectId Id { get => id; set => id = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        public DateTime Data_ocorrência { get => data_ocorrência; set => data_ocorrência = value; }
        public DateTime Data_registro { get => data_registro; set => data_registro = value; }
        
    }
}