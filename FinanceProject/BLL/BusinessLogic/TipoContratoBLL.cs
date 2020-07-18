using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class TipoContratoBLL : ITipoContratoBLL
    {
        private readonly IBaseRepository<TipoContrato> baseRepository;
        public TipoContratoBLL(IBaseRepository<TipoContrato> _baseRepository)
        {
            baseRepository = _baseRepository;
        }
        public void Add(TipoContrato pTipoContrato)
        {
            baseRepository.Save(pTipoContrato);
        }

        public void Delete(TipoContrato pTipoContrato)
        {
            throw new NotImplementedException();
        }

        public List<TipoContrato> GetAll(TipoContrato pTipoContrato)
        {
            if (pTipoContrato == null)
            {
                pTipoContrato = TipoContrato.CreateInstance();
            }
            return baseRepository.GetAll(pTipoContrato);
        }
    }
}
