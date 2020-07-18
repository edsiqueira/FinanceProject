using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IAluguelBLL
    {
        void Add(Aluguel pAluguel);
        List<Aluguel> GetAll(Aluguel pAluguel);
        void Delete(Aluguel pAluguel);
    }
}
