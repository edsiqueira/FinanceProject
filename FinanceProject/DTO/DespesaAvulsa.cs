using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DespesaAvulsa : Base
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDespesa { get; set; }
        public TipoDespesaAvulsa TipoDespesaAvulsaID { get; set; }

        public static DespesaAvulsa getNew() 
        {
            var despesaAvulsa = new DespesaAvulsa();
            despesaAvulsa.TipoDespesaAvulsaID = TipoDespesaAvulsa.getNew();
            despesaAvulsa.AnoID = getNewAno();
            despesaAvulsa.MesID = getNewMes();
            return despesaAvulsa;
        }

    }
}
