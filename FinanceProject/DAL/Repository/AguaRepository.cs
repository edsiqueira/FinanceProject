﻿using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class AguaRepository : BaseRepository<Agua>, IAguaRepository
    {
        public AguaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
