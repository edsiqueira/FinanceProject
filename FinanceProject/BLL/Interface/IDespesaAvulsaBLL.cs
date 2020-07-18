using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IDespesaAvulsaBLL
    {
        void Add(DespesaAvulsa pDespesaAvulsa);
        //DespesaAvulsa GetByMes(DespesaAvulsa pDespesaAvulsa);
        List<DespesaAvulsa> GetAll(DespesaAvulsa pDespesaAvulsa);
        void Delete(DespesaAvulsa pDespesaAvulsa);
    }
}
