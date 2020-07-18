using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IOrdenadoBLL
    {
        void Add(Ordenado pOrdenado);
        List<Ordenado> GetAll(Ordenado pOrdenado);
        void Delete(Ordenado pOrdenado);
    }
}
