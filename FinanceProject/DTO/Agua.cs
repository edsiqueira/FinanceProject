using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class Agua : Base
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public decimal Litros { get; set; }
        public DateTime DataProximaLeitura { get; set; }
        public DateTime InicioFaturacao { get; set; }
        public DateTime FimFaturacao { get; set; }

        public Contrato ContratoID { get; set; }

        public static Agua CreateInstance()
        {
            Agua pAgua = new Agua();
            pAgua.MesID = getNewMes();
            pAgua.AnoID = getNewAno();
            pAgua.ContratoID = Contrato.CreateInstance();


            return pAgua;
        }
    }
}
