using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataFactory.Repository
{
    public class ContratoRepository : IContratoRepository
    {
        private readonly IDatabaseContext database;
        public ContratoRepository(IDatabaseContext _database)
        {
            database = _database;
        }
        public Contrato GetContratoForEntity(System.Enum enumerator)
        {
            int enumeratorInt = 0;

            foreach (var item in enumerator.GetType().GetEnumValues())
            {
                if (enumerator.Equals(item))
                {
                    enumeratorInt = (int)item;
                    break;
                }
            }

            return database.GetContratoForEntity(enumeratorInt);
        }
    }
}
