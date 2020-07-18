using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IAnoBLL
    {
        void Add(Ano pAno);
        List<Ano> GetAllAno(Ano pAno);
        void Delete(Ano pAno);
    }
}
