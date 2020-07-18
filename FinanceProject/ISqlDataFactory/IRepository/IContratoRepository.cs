using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISqlDataFactory.IRepository
{
    public interface IContratoRepository
    {
        Contrato GetContratoForEntity(System.Enum enumerator);
    }
}
