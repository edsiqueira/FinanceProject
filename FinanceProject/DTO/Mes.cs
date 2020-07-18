using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTO
{
    public class Mes //: Base
    {
        public int ID { get; set; }
        public string MesName { get; set; }
        public int? MesNumber { get; set; }
        public static Mes CreateInstance() { return  new Mes(); }

    }
}
