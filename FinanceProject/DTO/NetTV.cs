using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NetTV : Base
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public decimal Acrescimos { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioFaturacao { get; set; }
        public DateTime FimFaturacao { get; set; }

        public Contrato ContratoID { get; set; }

        public static NetTV CreateInstance()
        {
            NetTV netTv = new NetTV();
            netTv.MesID = getNewMes();
            netTv.AnoID = getNewAno();
            netTv.ContratoID = Contrato.CreateInstance();
            return netTv;
        }

    }
}
