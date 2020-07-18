using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class ReceberAluguelRepository : BaseRepository<ReceberAluguel>, IReceberAluguelRepository
    {
        public ReceberAluguelRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
