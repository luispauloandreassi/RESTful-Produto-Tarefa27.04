using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExercícioAPI_RESTful_Produto__
{
    internal class Produto
    {

        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("codigoBarra")]
        public string CodigoDeBarras { get; set; }

        [JsonPropertyName("valor")]
        public float Valor { get; set; }


        private Produto() { }

        public Produto(string descricao, string codigoDeBarras, float valor)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            CodigoDeBarras = codigoDeBarras;
            Valor = valor;
        }


    }
}