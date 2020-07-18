using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class FinanciamentoRepository : BaseRepository<Financiamento>, IFinanciamentoRepository
    {
        public FinanciamentoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
