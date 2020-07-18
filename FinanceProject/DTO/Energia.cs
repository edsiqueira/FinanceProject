using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Energia : Base
    {
        public int ID { get; set; }
        public decimal Vazio { get; set; }
        public decimal Ponta { get; set; }
        public decimal Cheia { get; set; }
        public decimal Valor { get; set; }
        public decimal KwTotal { get; set; }
        public DateTime InicioFaturacao { get; set; }
        public DateTime FimFaturacao { get; set; }

        public Contrato ContratoID { get; set; }

        public static Energia CreateInstance() 
        {
            Energia energia = new Energia();
            energia.MesID = getNewMes();
            energia.AnoID = getNewAno();
            energia.ContratoID = Contrato.CreateInstance();

            return energia; 
        }

    }
}
