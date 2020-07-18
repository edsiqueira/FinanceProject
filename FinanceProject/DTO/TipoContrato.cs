using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TipoContrato
    {
        public int ID { get; set; }
        public string DescricaoTipoContrato { get; set; }
        public string Empresa { get; set; }
        public int? CodTipoContrato { get; set; }

        public static TipoContrato CreateInstance() { return new TipoContrato(); }

    }
}
