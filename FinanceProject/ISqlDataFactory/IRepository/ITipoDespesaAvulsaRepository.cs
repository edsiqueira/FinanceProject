using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISqlDataFactory.IRepository
{
    public interface ITipoDespesaAvulsaRepository
    {
        List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa();
    }
}
