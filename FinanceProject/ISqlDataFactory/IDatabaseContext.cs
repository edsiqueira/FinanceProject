using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISqlDataFactory
{
    public interface IDatabaseContext
    {
        Agua Save(Agua pAgua);
        Ano Save(Ano pAno);
        Energia Save(Energia pEnergia);
        Mes Save(Mes pMes);
        NetTV Save(NetTV pNetTV);
        Telemovel Save(Telemovel pTelemovel);
        Aluguel Save(Aluguel pAluguel);
        TipoDespesaAvulsa Save(TipoDespesaAvulsa pTipoDespesaAvulsa);
        DespesaAvulsa Save(DespesaAvulsa pDespesaAvulsa);
        Contrato Save(Contrato pContrato);
        TipoContrato Save(TipoContrato pTipoContrato);
        Ordenado Save(Ordenado pOrdenado);
        PlafondAC Save(PlafondAC pPlafondAC);
        Pessoa Save(Pessoa pPessoa);
        AluguelPessoa Save(AluguelPessoa pAluguelPessoa);

        List<Agua> GetAll(Agua pAgua);
        List<Energia> GetAll(Energia pEnergia);
        List<Telemovel> GetAll(Telemovel pTelemovel);
        List<NetTV> GetAll(NetTV pNetTV);
        List<Aluguel> GetAll(Aluguel pNetTV);
        List<DespesaAvulsa> GetAll(DespesaAvulsa pDespesaAvulsa);
        List<TipoContrato> GetAll(TipoContrato pTipoContrato);
        List<Contrato> GetAll(Contrato pContrato);
        List<Ano> GetAll(Ano pAno);
        List<Mes> GetAll(Mes pMes);
        List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa();
        List<Ordenado> GetAll(Ordenado pOrdenado);
        List<PlafondAC> GetAll(PlafondAC pPlafondAC);
        List<Pessoa> GetAll(Pessoa pPessoa);
        List<AluguelPessoa> GetAll(AluguelPessoa pAluguelPessoa);
        Contrato GetContratoForEntity(int enumerator);
    }
}
