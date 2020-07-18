using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class OrdenadoBLL : IOrdenadoBLL
    {
        private readonly IBaseRepository<Ordenado> baseRepository;
        public OrdenadoBLL(IBaseRepository<Ordenado> _baseRepository)
        {
            baseRepository = _baseRepository;
        }
        public void Add(Ordenado pOrdenado)
        {
            baseRepository.Save(pOrdenado);
        }

        public void Delete(Ordenado pOrdenado)
        {
            throw new NotImplementedException();
        }

        public List<Ordenado> GetAll(Ordenado pOrdenado)
        {
            return baseRepository.GetAll(pOrdenado);
        }
    }
}
