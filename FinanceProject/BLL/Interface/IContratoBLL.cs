using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IContratoBLL
    {
        void Add(Contrato pContrato);
        List<Contrato> GetAll(Contrato pContrato);
        void Delete(Contrato pContrato);
    }
}
