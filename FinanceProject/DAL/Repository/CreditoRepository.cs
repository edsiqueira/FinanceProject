using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class CreditoRepository : BaseRepository<Credito>, ICreditoRepository
    {
        public CreditoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
