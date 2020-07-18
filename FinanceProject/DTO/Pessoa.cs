using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int QuantidadePessoa { get; set; }
        public int CodigoId { get; set; }
        public bool Ativo { get; set; }

        public static Pessoa CreateInstance() { return new Pessoa(); }
    }
}
