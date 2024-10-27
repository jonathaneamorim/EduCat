﻿namespace Model.Entities
{
    public class Endereco
    {
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Municipio { get; set; }
        public string? UF { get; set; }
        public string? Complemento { get; set; }
        public string? Pais { get; set; }

        public Endereco() { }
    }
}
