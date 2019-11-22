﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGMI
{
    public class Infrator
    {
        private ObjectId id;
        private string nome, cpf, rg, mãe, logradouro, num_residência, bairro, cidade, uf;
        private char sexo;
        private DateTime data_nascimento, data_registro;
        private List<Infração> infrações;

        public Infrator()
        {
            Infrações = new List<Infração>();
        }

        public ObjectId Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Mãe { get => mãe; set => mãe = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Num_residência { get => num_residência; set => num_residência = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public DateTime Data_registro { get => data_registro; set => data_registro = value; }
        public List<Infração> Infrações { get => infrações; set => infrações = value; }
        
    }
}
