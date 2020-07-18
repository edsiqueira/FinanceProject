using BLL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RearlineLogicLayer
{
    public class HomeRearline: BaseHomeRearline, IHomeRearline
    {
        //public HomeRearline(IAguaBLL _aguaBLL, IAluguelBLL _aluguelBLL, IAnoBLL _anoBLL, ICreditoBLL _creditoBLL, 
        //                        IDespesasRecebidasBLL _despesasRecebidasBLL, IEnergiaBLL _energiaBLL, IFinanciamentoBLL _financiamentoBLL, IGasBLL _gasBLL,
        //                        IMesBLL _mesBLL, INetTvBLL _netTvBLL, IOrdenadoBLL _ordenadoBLL, IPagamentoCreditoBLL _pagamentoCreditoBLL,
        //                        IPessoaBLL _pessoaBLL, IPlafondACBLL _plafondACBLL, IPoupancaBLL _poupancaBLL, IReceberAluguelBLL _receberAluguelBLL,
        //                        ITelemovelBLL _telemovelBLL, , ITipoOperacaoBLL _tipoOperacaoBLL, ITransportesBLL _transportesBLL) : 
        //                base(_aguaBLL, _aluguelBLL, _anoBLL, _creditoBLL, _despesasAvulsasBLL, _despesasRecebidasBLL, _energiaBLL, _financiamentoBLL, _gasBLL, _mesBLL, _netTvBLL,
        //                    _ordenadoBLL, _pagamentoCreditoBLL, _pessoaBLL, _plafondACBLL, _poupancaBLL, _receberAluguelBLL, _telemovelBLL, _tipoDespesaAvulsaBLL, _tipoOperacaoBLL, _transportesBLL)
        //{
            
        //}

        public HomeRearline(IAluguelBLL _aluguelBLL, IAguaBLL _aguaBLL, IAnoBLL _anoBLL, IContratoBLL _contratoBLL, IDespesaAvulsaBLL _despesaAvulsaBLL, IEnergiaBLL _energiaBLL, IMesBLL _mesBLL, 
            INetTvBLL _netTvBLL, IOrdenadoBLL _ordenadoBLL, IPlafondACBLL _plafondACBLL, ITelemovelBLL _telemovelBLL, 
            ITipoDespesaAvulsaBLL _tipoDespesaAvulsaBL, ITipoContratoBLL _tipoContratoBLL) :
                       base(_aluguelBLL, _aguaBLL, _anoBLL, _contratoBLL, _despesaAvulsaBLL, _energiaBLL,  _mesBLL, _netTvBLL, _ordenadoBLL, _plafondACBLL, _telemovelBLL, _tipoDespesaAvulsaBL, _tipoContratoBLL)
        {

        }
        public void AddAno(Ano pAno)
        {
            throw new NotImplementedException();
        }
        public void AddMes(Mes pMes)
        {
            mesBLL.Add(pMes);
        }

        public void AddDespesaAvulsa(DespesaAvulsa pDespesaAvulsa)
        {
            despesaAvulsaBLL.Add(pDespesaAvulsa);
        }

        public void AddTipoContrato(TipoContrato pTipoContrato)
        {
            tipoContratoBLL.Add(pTipoContrato);
        }

        public Agua AddAgua(Agua pAgua)
        {
            return aguaBLL.Add(pAgua);
        }

        public void AddEnergia(Energia pEnergia)
        {
            energiaBLL.Add(pEnergia);
        }
        
        public void AddNetTv(NetTV pNetTv)
        {
            netTvBLL.Add(pNetTv);
        }

        public void AddOrdenado(Ordenado pOrdenado)
        {
            ordenadoBLL.Add(pOrdenado);
        }

        public void AddTelemovel(Telemovel pTelemovel)
        {
            telemovelBLL.Add(pTelemovel);
        }

        public void AddContrato(Contrato pContrato)
        {
            contratoBLL.Add(pContrato);
        }

        public void AddTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa)
        {
            tipoDespesaAvulsaBLL.Add(pTipoDespesaAvulsa);
        }

        public List<Agua> GetAllAgua(Agua pAgua = null)
        {
            return aguaBLL.GetAll(pAgua);
        }

        public List<Mes> GetAllMes(Mes pMes = null)
        {
            if (pMes == null)
            {
                pMes = Mes.CreateInstance();
            }
            return mesBLL.GetAllMes(pMes);
        }

        public List<Ano> GetAllAno(Ano pAno = null)
        {
            if (pAno == null)
            {
                pAno = Ano.getNew();
            }
            return anoBLL.GetAllAno(pAno);
        }

        public List<Energia> GetAllEnergia(Energia pEnergia = null)
        {
            return energiaBLL.GetAllByAno(pEnergia);
        }

        public List<Telemovel> GetAllTelemovel(Telemovel pTelemovel = null)
        {
            return telemovelBLL.GetAllByAno(pTelemovel);
        }

        public List<NetTV> GetAllNetTV(NetTV pNetTV = null)
        {
            return netTvBLL.GetAllByAno(pNetTV);
        }

        public List<Aluguel> GetAllAluguel(Aluguel pAluguel = null)
        {
            return aluguelBLL.GetAll(pAluguel);
        }

        public List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa = null)
        {
            return tipoDespesaAvulsaBLL.GetAllTipoDespesaAvulsa();
        }

        public List<DespesaAvulsa> GetAllDespesaAvulsa(DespesaAvulsa pDespesaAvulsa = null)
        {
            return despesaAvulsaBLL.GetAll(pDespesaAvulsa);
        }

        public List<Contrato> GetAllContrato(Contrato pContrato = null)
        {
            return contratoBLL.GetAll(pContrato);
        }

        public List<TipoContrato> GetAllTipoContrato(TipoContrato pTipoContrato = null)
        {
            return tipoContratoBLL.GetAll(pTipoContrato);
        }

        public List<Ordenado> GetAllOrdenado(Ordenado pOrdenado = null) 
        {
            if (pOrdenado == null)
            {
                pOrdenado = Ordenado.CreateInstance();
            }
            return ordenadoBLL.GetAll(pOrdenado);
        }

        public List<PlafondAC> GetAllPlafondAC(PlafondAC pPlafondAC = null)
        {
            if (pPlafondAC == null)
            {
                pPlafondAC = PlafondAC.CreateInstance();
            }
            return plafondACBLL.GetAll(pPlafondAC);
        }

        public void AddPlafondAC(PlafondAC pPlafondAC)
        {
            plafondACBLL.Add(pPlafondAC);
        }

        public void AddAluguel(Aluguel pAluguel)
        {
            aluguelBLL.Add(pAluguel);
        }
    }
}
