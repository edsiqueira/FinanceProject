using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Telemovel : Base
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public decimal Acrescimos { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioFaturacao { get; set; }
        public DateTime FimFaturacao { get; set; }

        public Contrato ContratoID { get; set; }
        public static Telemovel CreateInstance() 
        {
            Telemovel telemovel = new Telemovel();
            telemovel.MesID = getNewMes();
            telemovel.AnoID = getNewAno();
            telemovel.ContratoID = Contrato.CreateInstance();
            return telemovel; 
        }
    }
}
