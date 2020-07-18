using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Ordenado
    {
        public int ID { get; set; }
        public decimal Base { get; set; }
        public decimal AjudasCusto { get; set; }
        public decimal DuodecimosFerias { get; set; }
        public decimal DuodecimosNatal { get; set; }
        public decimal SegurancaSocial { get; set; }
        public decimal IRS { get; set; }
        public decimal SubsidioRefeicao { get; set; }
        public DateTime DataRececao { get; set; }
        public Mes MesID { get; set; }
        public Ano AnoID { get; set; }


        public static Ordenado CreateInstance()
        {
            var ordenado = new Ordenado();
            ordenado.AnoID = Ano.getNew();
            ordenado.MesID = Mes.CreateInstance();

            return ordenado;
        }
    }
}
