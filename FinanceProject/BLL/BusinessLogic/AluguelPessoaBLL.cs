using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class AluguelPessoaBLL : IAluguelPessoaBLL
    {
        private readonly IBaseRepository<AluguelPessoa> baseRepository;
        //private readonly IContratoRepository contratoRepository;

        public AluguelPessoaBLL(IBaseRepository<AluguelPessoa> _baseRepository)
        {
            baseRepository = _baseRepository;
        }
        public void Add(AluguelPessoa pAluguelPessoa)
        {
            baseRepository.Save(pAluguelPessoa);
        }

        public void Delete(AluguelPessoa pAluguelPessoa)
        {
            baseRepository.Delete(pAluguelPessoa);
        }

        public List<AluguelPessoa> GetAll(AluguelPessoa pAluguelPessoa)
        {
            if (pAluguelPessoa == null)
            {
                pAluguelPessoa = AluguelPessoa.CreateInstance();
                pAluguelPessoa.AnoID.AnoNumber = DateTime.Now.Year;
            }
            return baseRepository.GetAll(pAluguelPessoa);
        }
    }
}
