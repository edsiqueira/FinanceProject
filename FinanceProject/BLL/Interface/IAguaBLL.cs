using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IAguaBLL
    {
        Agua Add(Agua pAgua);
        List<Agua> GetAll(Agua pAgua);
        void Delete(Agua pAgua);
    }
}
