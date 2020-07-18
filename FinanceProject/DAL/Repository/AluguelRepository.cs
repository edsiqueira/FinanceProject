using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class AluguelRepository : BaseRepository<Aluguel>, IAluguelRepository
    {
        public AluguelRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
