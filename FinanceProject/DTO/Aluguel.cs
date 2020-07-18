using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Aluguel : Base
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public Contrato ContratoID { get; set; }

        public static Aluguel CreateInstance()
        {
            Aluguel aluguel = new Aluguel();
            aluguel.MesID = getNewMes();
            aluguel.AnoID = getNewAno();
            aluguel.ContratoID = Contrato.CreateInstance();
            return aluguel;
        }
    }
}
