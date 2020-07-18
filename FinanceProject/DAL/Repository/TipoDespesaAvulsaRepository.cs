using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class TipoDespesaAvulsaRepository : BaseRepository<TipoDespesaAvulsa>, ITipoDespesaAvulsaRepository
    {
        public TipoDespesaAvulsaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
