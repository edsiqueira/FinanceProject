using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface ITipoContratoBLL
    {
        void Add(TipoContrato pTipoContrato);
        List<TipoContrato> GetAll(TipoContrato pTipoContrato);
        void Delete(TipoContrato pTipoContrato);
    }
}
