﻿using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DespesasAvulsasRepository : BaseRepository<DespesasAvulsas>, IDespesasAvulsasRepository
    {
        public DespesasAvulsasRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
