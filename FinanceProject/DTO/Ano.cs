using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Ano
    {
        public int ID { get; set; }
        public int? AnoNumber { get; set; }
        public static Ano getNew() { return new Ano(); }
    }
}
