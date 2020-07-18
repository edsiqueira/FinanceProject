using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class GasRepository : BaseRepository<Gas>, IGasRepository
    {
        public GasRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
