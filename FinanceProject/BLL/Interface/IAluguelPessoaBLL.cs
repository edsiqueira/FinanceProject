using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IAluguelPessoaBLL
    {
        void Add(AluguelPessoa pAluguelPessoa);
        List<AluguelPessoa> GetAll(AluguelPessoa pAluguelPessoa);
        void Delete(AluguelPessoa pAluguelPessoa);
    }
}
