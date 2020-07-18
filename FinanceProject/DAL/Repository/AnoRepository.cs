using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class AnoRepository : BaseRepository<Ano>, IAnoRepository
    {
        public AnoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
