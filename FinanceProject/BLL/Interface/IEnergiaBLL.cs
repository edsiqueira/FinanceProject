using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IEnergiaBLL
    {
        void Add(Energia pEnergia);
        //Energia GetByMes(Energia pEnergia);
        List<Energia> GetAllByAno(Energia pEnergia);
        void Delete(Energia pEnergia);
    }
}
