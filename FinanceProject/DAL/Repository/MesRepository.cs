using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class MesRepository : BaseRepository<Mes>, IMesRepository
    {
        public MesRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
