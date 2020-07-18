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
    public class NetTvBLL : INetTvBLL
    {
        private readonly IBaseRepository<NetTV> baseRepository;
        private readonly IContratoRepository contratoRepository;
        public NetTvBLL(IBaseRepository<NetTV> _baseRepository, IContratoRepository _contratoRepository)
        {
            baseRepository = _baseRepository;
            contratoRepository = _contratoRepository;
        }

        public void Add(NetTV pNetTV)
        {
            pNetTV.ContratoID = contratoRepository.GetContratoForEntity(ContratoEnum.TvNet);
            baseRepository.Save(pNetTV);

        }

        public void Delete(NetTV pNetTV)
        {
            baseRepository.Delete(pNetTV);
        }

        public List<NetTV> GetAllByAno(NetTV pNetTV)
        {
            if (pNetTV == null)
            {
                pNetTV = NetTV.CreateInstance();
                pNetTV.AnoID.AnoNumber = 2020;
            }
            return baseRepository.GetAll(pNetTV);
              
        }

        //public NetTV GetByMes(NetTV pNetTV)
        //{
        //    return baseRepository.GetByMes(pNetTV);
        //}
    }
}
