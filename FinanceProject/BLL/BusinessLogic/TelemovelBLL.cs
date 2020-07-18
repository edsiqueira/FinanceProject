using BLL.Enum;
using BLL.Interface;
using DTO;
using ISqlDataFactory;
using ISqlDataFactory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.BusinessLogic
{
    public class TelemovelBLL : ITelemovelBLL
    {
        private readonly IBaseRepository<Telemovel> baseRepository;
        private readonly IContratoRepository contratoRepository;
        public TelemovelBLL(IBaseRepository<Telemovel> _baseRepository, IContratoRepository _contratoRepository)
        {
            baseRepository = _baseRepository;
            contratoRepository = _contratoRepository;
        }

        public void Add(Telemovel pTelemovel)
        {
            pTelemovel.ContratoID = contratoRepository.GetContratoForEntity(ContratoEnum.Telemovel);
           
            baseRepository.Save(pTelemovel);

        }

        public void Delete(Telemovel pTelemovel)
        {
            baseRepository.Delete(pTelemovel);
        }

        public List<Telemovel> GetAllByAno(Telemovel pTelemovel)
        {
            if (pTelemovel == null)
            {
                pTelemovel = Telemovel.CreateInstance();
            }
            
            return baseRepository.GetAll(pTelemovel);
        }

        //public Telemovel GetByMes(Telemovel pTelemovel)
        //{
        //    return baseRepository.GetByMes(pTelemovel);
        //}
    }
}
