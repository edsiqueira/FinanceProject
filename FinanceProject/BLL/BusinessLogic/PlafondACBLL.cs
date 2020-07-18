using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessLogic
{
    public class PlafondACBLL : IPlafondACBLL
    {
        private readonly IBaseRepository<PlafondAC> baseRepository;
        public PlafondACBLL(IBaseRepository<PlafondAC> _baseRepository)
        {
            baseRepository = _baseRepository;
        }

        public void Add(PlafondAC pPlafondAC)
        {
            baseRepository.Save(pPlafondAC);
        }

        public void Delete(PlafondAC pPlafondAC)
        {
            throw new NotImplementedException();
        }

        public List<PlafondAC> GetAll(PlafondAC pPlafondAC)
        {
            if (pPlafondAC == null)
            {
                pPlafondAC = PlafondAC.CreateInstance();
            }
            return baseRepository.GetAll(pPlafondAC);
        }
    }
}
