using BLL.Enum;
using BLL.Interface;
using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;

namespace BLL.BusinessLogic
{
    public class AguaBLL : IAguaBLL
    {
        private readonly IBaseRepository<Agua> baseRepository;
        private readonly IContratoRepository contratoRepository;
        public AguaBLL(IBaseRepository<Agua> _baseRepository, IContratoRepository _contratoRepository)
        {
            baseRepository = _baseRepository;
            contratoRepository = _contratoRepository;
        }

        public Agua Add(Agua pAgua)
        {
            pAgua.ContratoID = contratoRepository.GetContratoForEntity(ContratoEnum.Agua);
            return baseRepository.Save(pAgua);
        }

        public void Delete(Agua pAgua)
        {
            //_aguaRepository.Delete(pAgua);
        }

        public List<Agua> GetAll(Agua pAgua)
        {
            if (pAgua == null)
            {
                pAgua = Agua.CreateInstance();
                pAgua.AnoID.AnoNumber = 2020;
            }
            return baseRepository.GetAll(pAgua);
        }
    }
}
