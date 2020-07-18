using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IPlafondACBLL
    {
        void Add(PlafondAC pPlafondAC);
        List<PlafondAC> GetAll(PlafondAC pPlafondAC);
        void Delete(PlafondAC pPlafondAC);
    }
}
