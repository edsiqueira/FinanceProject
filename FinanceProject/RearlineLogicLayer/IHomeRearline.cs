using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RearlineLogicLayer
{
    public interface IHomeRearline
    {
        Agua AddAgua(Agua pAgua);
        void AddAluguel(Aluguel pAluguel);
        //Agua GetAguaByID(Agua pAgua);
        List<Agua> GetAllAgua(Agua pAgua = null);
        List<Energia> GetAllEnergia(Energia pEnergia = null);
        List<Telemovel> GetAllTelemovel(Telemovel pTelemovel = null);
        List<NetTV> GetAllNetTV(NetTV pNetTV = null);
        List<Aluguel> GetAllAluguel(Aluguel pAluguel = null);
        List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa = null);
        List<DespesaAvulsa> GetAllDespesaAvulsa(DespesaAvulsa pDespesaAvulsa = null);
        List<Contrato> GetAllContrato(Contrato pContrato = null);
        List<TipoContrato> GetAllTipoContrato(TipoContrato pTipoContrato = null);
        List<Ordenado> GetAllOrdenado(Ordenado pOrdenado = null);
        void AddTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa);
        List<Mes> GetAllMes(Mes pMes = null);
        List<PlafondAC> GetAllPlafondAC(PlafondAC pPlafondAC = null);
        //void AddAluguel(Aluguel pAluguel);
        void AddAno(Ano pAno);
        List<Ano> GetAllAno(Ano pAno = null);
        //void AddCredito(Credito pCredito);
        //void AddDespesasAvulsas(DespesasAvulsas pDespesasAvulsas);
        //void AddDespesasRecebidas(DespesasRecebidas pDespesasRecebidas);
        void AddEnergia(Energia pEnergia);
        //void AddFinanciamento(Financiamento pFinanciamento);
        //void AddGas(Gas pGas);
        void AddMes(Mes pMes);
        void AddNetTv(NetTV pNetTv);
        void AddTelemovel(Telemovel pTelemovel);
        void AddDespesaAvulsa(DespesaAvulsa pDespesaAvulsa);
        void AddTipoContrato(TipoContrato pTipoContrato);
        void AddContrato(Contrato pContrato);
        void AddOrdenado(Ordenado pOrdenado);
        //void AddPagamentoCredito(PagamentoCredito pPagamentoCredito);
        //void AddPessoa(Pessoa pPessoa);
        void AddPlafondAC(PlafondAC pPlafondAC);
        //void AddPoupanca(Poupanca pPoupanca);
        //void AddTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa);
        //void AddTipoOperacao(TipoOperacao pTipoOperacao); 
        //void AddTransportes(Transportes pTransportes);



    }
}
