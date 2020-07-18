using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class AluguelPessoa : Base
    {
        public int ID { get; set; }
        public decimal ValorPagamento { get; set; }
        public decimal ValorContrato { get; set; }
        public Pessoa PessoaID { get; set; }

        public static AluguelPessoa CreateInstance() 
        {
            var p = new AluguelPessoa();
            p.PessoaID = Pessoa.CreateInstance();
            p.AnoID = Ano.getNew();
            p.MesID = Mes.CreateInstance();
            return p; 
        }
    }
}
