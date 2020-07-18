using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface INetTvBLL
    {
        void Add(NetTV pNetTV);
        //NetTV GetByMes(NetTV pNetTV);
        List<NetTV> GetAllByAno(NetTV pNetTV);
        void Delete(NetTV pNetTV);
    }
}
