using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class ContratoBLL : IContratoBLL
    {
        private readonly IBaseRepository<Contrato> baseRepository;
        public ContratoBLL(IBaseRepository<Contrato> _baseRepository)
        {
            baseRepository = _baseRepository;
        }

        public void Add(Contrato pContrato)
        {
            pContrato.Ativo = true;
            baseRepository.Save(pContrato);
        }

        public void Delete(Contrato pContrato)
        {
            throw new NotImplementedException();
        }

        public List<Contrato> GetAll(Contrato pContrato)
        {
            if (pContrato == null)
            {
                pContrato = Contrato.CreateInstance();
            }
            return baseRepository.GetAll(pContrato); 
        }
    }
}
