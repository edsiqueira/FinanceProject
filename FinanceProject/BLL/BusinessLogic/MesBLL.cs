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
    public class MesBLL : IMesBLL
    {
        private readonly IBaseRepository<Mes> baseRepository;
        //private readonly IMesRepository mesRepository;
        public MesBLL(IBaseRepository<Mes> _baseRepository/*, IMesRepository _mesRepository*/)
        {
            baseRepository = _baseRepository;
            //mesRepository = _mesRepository;
        }

        public void Add(Mes pMes)
        {
            baseRepository.Save(pMes);
        }

        public void Delete(Mes pMes)
        {
            baseRepository.Delete(pMes);
        }

        public List<Mes> GetAllMes(Mes pMes)
        {
            if (pMes == null)
            {
                pMes = Mes.CreateInstance();
            }
            return baseRepository.GetAll(pMes); ;
        }
    }
}
