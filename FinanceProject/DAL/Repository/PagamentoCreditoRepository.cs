using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class PagamentoCreditoRepository : BaseRepository<PagamentoCredito>, IPagamentoCreditoRepository
    {
        public PagamentoCreditoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
