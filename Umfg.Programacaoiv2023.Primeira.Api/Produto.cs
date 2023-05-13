using System;
using System.Text.Json.Serialization;

namespace Umfg.Programacaoiv2023.RestFulProduto.Api
{
    public sealed class Produto
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