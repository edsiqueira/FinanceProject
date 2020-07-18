using BLL.Enum;
using BLL.Interface;
using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class AluguelBLL : IAluguelBLL
    {
        private readonly IBaseRepository<Aluguel> baseRepository;
        private readonly IContratoRepository contratoRepository;
        public AluguelBLL(IBaseRepository<Aluguel> _baseRepository, IContratoRepository _contratoRepository)
        {
            baseRepository = _baseRepository;
            contratoRepository = _contratoRepository;
        }

        public void Add(Aluguel pAluguel)
        {
            pAluguel.ContratoID = contratoRepository.GetContratoForEntity(ContratoEnum.Aluguel);
            baseRepository.Save(pAluguel);
        }

        public void Delete(Aluguel pAluguel)
        {
            baseRepository.Delete(pAluguel);
        }

        public List<Aluguel> GetAll(Aluguel pAluguel)
        {
            if (pAluguel == null)
            {
                pAluguel = Aluguel.CreateInstance();
                pAluguel.AnoID.AnoNumber = 2020;
            }
            return baseRepository.GetAll(pAluguel);
        }

        //public Aluguel GetByMes(Aluguel id)
        //{
        //    return baseRepository.GetByMes(id);
        //}
    }
}
