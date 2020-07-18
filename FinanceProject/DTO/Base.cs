using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public abstract class Base
    {
        public bool Pago { get; set; }
        public DateTime DataRegisto { get; set; }
        public Mes MesID { get; set; }
        public Ano AnoID { get; set; }

        public static Mes getNewMes() { return new Mes(); }
        public static Ano getNewAno() { return new Ano(); }

    }
}
