using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class PlafondACRepository : BaseRepository<PlafondAC>, IPlafondACRepository
    {
        public PlafondACRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
