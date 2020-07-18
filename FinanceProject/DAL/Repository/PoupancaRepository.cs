using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class PoupancaRepository : BaseRepository<Poupanca>, IPoupancaRepository
    {
        public PoupancaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
