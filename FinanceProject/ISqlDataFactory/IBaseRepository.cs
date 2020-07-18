using System;
using System.Collections.Generic;
using System.Text;

namespace ISqlDataFactory
{
    public interface IBaseRepository<T>  where T : class
    {
        T Save(T entity);
        List<T> GetAll(T entity);
        //T GetByMes(T entity);
        bool Delete(T entity);
    }
}
