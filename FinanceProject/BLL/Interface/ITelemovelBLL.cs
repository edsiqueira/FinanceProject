using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface ITelemovelBLL
    {
        void Add(Telemovel pTelemovel);
        //Telemovel GetByMes(Telemovel pTelemovel);
        List<Telemovel> GetAllByAno(Telemovel pTelemovel);
        void Delete(Telemovel pTelemovel);
    }
}
