using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ContratoService
    {

        private readonly IContratoRepository contratoRepository;
        public ContratoService(IContratoRepository _contratoRepository)
        {
            contratoRepository = _contratoRepository;
        }
    }
}
