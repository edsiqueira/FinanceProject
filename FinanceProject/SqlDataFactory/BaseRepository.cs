using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataFactory
{
    public class BaseRepository<TEtity> : IBaseRepository<TEtity> where TEtity : class
    {
        private readonly IDatabaseContext database;
        public BaseRepository(IDatabaseContext _database)
        {
            database = _database;
        }
        public TEtity Save(TEtity entity)
        {
            var ret = database.Save((dynamic)entity);
            return entity;
        }

        public bool Delete(TEtity entity)
        {
            throw new NotImplementedException();
        }
       
        public List<TEtity> GetAll(TEtity entity)
        {
            var ret = database.GetAll((dynamic)entity);
            return ret;

        }
    }
}