using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PlafondAC
    {
        public int ID { get; set; }
        public decimal ValorDisponivel { get; set; }
        public decimal ValorMensal { get; set; }
        public decimal Total { get; set; }
        public Ano AnoID { get; set; }

        public static PlafondAC CreateInstance() 
        {
            var plafondAC = new PlafondAC();
            plafondAC.AnoID = Ano.getNew();

            return plafondAC;
        }
    }
}
