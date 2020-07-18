using DAL.Context;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class TipoOperacaoRepository : BaseRepository<TipoOperacao>, ITipoOperacaoRepository
    {
        public TipoOperacaoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
