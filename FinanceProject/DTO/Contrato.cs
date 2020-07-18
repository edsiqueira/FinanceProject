using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Contrato
    {
        public int ID { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string NumeroContrato { get; set; }
        public bool Ativo { get; set; }

        public TipoContrato TipoContratoID { get; set; }

        public static Contrato CreateInstance() 
        {
            var contrato = new Contrato();
            contrato.TipoContratoID = new TipoContrato();
            return contrato;
        }
    }
}
