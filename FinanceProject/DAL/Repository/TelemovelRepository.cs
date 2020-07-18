using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class TelemovelRepository : BaseRepository<Telemovel>, ITelemovelRepository
    {
        public TelemovelRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
