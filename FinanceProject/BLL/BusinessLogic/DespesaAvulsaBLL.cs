using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class DespesaAvulsaBLL : IDespesaAvulsaBLL
    {
        private readonly IBaseRepository<DespesaAvulsa> baseRepository;
        public DespesaAvulsaBLL(IBaseRepository<DespesaAvulsa> _baseRepository)
        {
            baseRepository = _baseRepository;
        }

        public void Add(DespesaAvulsa pDespesaAvulsa)
        {
            baseRepository.Save(pDespesaAvulsa);
        }

        public void Delete(DespesaAvulsa pDespesaAvulsa)
        {
            baseRepository.Delete(pDespesaAvulsa);
        }

        public List<DespesaAvulsa> GetAll(DespesaAvulsa pDespesaAvulsa)
        {
            if (pDespesaAvulsa == null)
            {
                pDespesaAvulsa = DespesaAvulsa.getNew();
                pDespesaAvulsa.AnoID.AnoNumber = 2020;
            }
            return baseRepository.GetAll(pDespesaAvulsa);
        }

        //public DespesaAvulsa GetByMes(DespesaAvulsa pDespesaAvulsa)
        //{
        //    return baseRepository.GetByMes(pDespesaAvulsa);
        //}
    }
}
