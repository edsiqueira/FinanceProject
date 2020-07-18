using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class TransportesRepository : BaseRepository<Transportes>, ITransportesRepository
    {
        public TransportesRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
