using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataFactory.Repository
{
    public class TipoDespesaAvulsaRepository : ITipoDespesaAvulsaRepository
    {
        private readonly IDatabaseContext database;
        public TipoDespesaAvulsaRepository(IDatabaseContext _database)
        {
            database = _database;
        }
        public List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa()
        {
            return database.GetAllTipoDespesaAvulsa();
        }
    }
}
