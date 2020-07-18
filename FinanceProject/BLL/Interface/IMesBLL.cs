using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IMesBLL
    {
        void Add(Mes pMes);
        List<Mes> GetAllMes(Mes pMes);
        void Delete(Mes pMes);
    }
}
