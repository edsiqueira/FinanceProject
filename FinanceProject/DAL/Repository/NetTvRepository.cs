using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class NetTvRepository : BaseRepository<NetTV>, INetTvRepository
    {
        public NetTvRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
