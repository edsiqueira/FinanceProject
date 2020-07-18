using BLL.Interface;
using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class TipoDespesaAvulsaBLL : ITipoDespesaAvulsaBLL
    {
        private readonly IBaseRepository<TipoDespesaAvulsa> baseRepository;
        private readonly ITipoDespesaAvulsaRepository tipoDespesaAvulsaRepository;
        public TipoDespesaAvulsaBLL(IBaseRepository<TipoDespesaAvulsa> _baseRepository, ITipoDespesaAvulsaRepository _enumRepository)
        {
            baseRepository = _baseRepository;
            tipoDespesaAvulsaRepository = _enumRepository;
        }

        public void Add(TipoDespesaAvulsa pTipoDespesaAvulsa)
        {
            baseRepository.Save(pTipoDespesaAvulsa);
        }

        public void Delete(TipoDespesaAvulsa pTipoDespesaAvulsa)
        {
            throw new NotImplementedException();
        }

        public List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa()
        {
            return tipoDespesaAvulsaRepository.GetAllTipoDespesaAvulsa();
        }

        public TipoDespesaAvulsa GetByMes(TipoDespesaAvulsa id)
        {
            throw new NotImplementedException();
        }
    }
}
