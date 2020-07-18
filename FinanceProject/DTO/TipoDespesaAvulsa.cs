using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TipoDespesaAvulsa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CodDespesa { get; set; }

        public static TipoDespesaAvulsa getNew() { return new TipoDespesaAvulsa(); }
    }
}
