using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DespesasRecebidasRepository : BaseRepository<DespesasRecebidas>, IDespesasRecebidasRepository
    {
        public DespesasRecebidasRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }

}
