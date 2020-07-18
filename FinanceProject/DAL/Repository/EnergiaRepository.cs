using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class EnergiaRepository : BaseRepository<Energia>, IEnergiaRepository
    {
        public EnergiaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
