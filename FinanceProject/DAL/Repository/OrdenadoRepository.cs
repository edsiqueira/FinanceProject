using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class OrdenadoRepository : BaseRepository<Ordenado>, IOrdenadoRepository
    {
        public OrdenadoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
