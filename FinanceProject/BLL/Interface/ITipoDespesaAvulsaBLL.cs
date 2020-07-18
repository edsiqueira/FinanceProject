using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface ITipoDespesaAvulsaBLL
    {
        void Add(TipoDespesaAvulsa pTipoDespesaAvulsa);
        TipoDespesaAvulsa GetByMes(TipoDespesaAvulsa id);
        List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa();
        void Delete(TipoDespesaAvulsa pTipoDespesaAvulsa);
    }
}
