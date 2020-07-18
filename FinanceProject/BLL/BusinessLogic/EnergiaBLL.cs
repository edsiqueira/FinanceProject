using BLL.Enum;
using BLL.Interface;
using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;

namespace BLL.BusinessLogic
{
    public class EnergiaBLL : IEnergiaBLL
    {
        private readonly IBaseRepository<Energia> baseRepository;
        private readonly IContratoRepository contratoRepository;
        public EnergiaBLL(IBaseRepository<Energia> _baseRepository, IContratoRepository _contratoRepository)
        {
            baseRepository = _baseRepository;
            contratoRepository = _contratoRepository;
        }

        public void Add(Energia pEnergia)
        {

            pEnergia.ContratoID = contratoRepository.GetContratoForEntity(ContratoEnum.Energia);
            baseRepository.Save(pEnergia);
        }

        public void Delete(Energia pEnergia)
        {
            baseRepository.Delete(pEnergia);
        }

        public List<Energia> GetAllByAno(Energia pEnergia)
        {
            if (pEnergia == null)
            {
                pEnergia = Energia.CreateInstance();
                pEnergia.AnoID.AnoNumber = DateTime.Now.Year;
            }
            return baseRepository.GetAll(pEnergia);
        }

        //public Energia GetByMes(Energia pEnergia)
        //{
        //    return baseRepository.GetByMes(pEnergia);
        //}
    }
}
