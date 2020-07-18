using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RearlineLogicLayer
{
    public class BaseHomeRearline
    {
        protected readonly IAguaBLL aguaBLL;
        protected readonly IAluguelBLL aluguelBLL;
        protected readonly IAnoBLL anoBLL;
        protected readonly IContratoBLL contratoBLL;
        //protected readonly ICreditoBLL creditoBLL;

        protected readonly IDespesaAvulsaBLL despesaAvulsaBLL;
        //protected readonly IDespesasRecebidasBLL despesasRecebidasBLL;

        protected readonly IEnergiaBLL energiaBLL;
        //protected readonly IFinanciamentoBLL financiamentoBLL;
        //protected readonly IGasBLL gasBLL;
        protected readonly IMesBLL mesBLL;

        protected readonly INetTvBLL netTvBLL;
        protected readonly IOrdenadoBLL ordenadoBLL;
        //protected readonly IPagamentoCreditoBLL pagamentoCreditoBLL;
        //protected readonly IPessoaBLL pessoaBLL;
        protected readonly IPlafondACBLL plafondACBLL;
        //protected readonly IPoupancaBLL poupancaBLL;
        //protected readonly IReceberAluguelBLL receberAluguelBLL;
        protected readonly ITelemovelBLL telemovelBLL;
        protected readonly ITipoDespesaAvulsaBLL tipoDespesaAvulsaBLL;
        protected readonly ITipoContratoBLL tipoContratoBLL;
        //protected readonly ITipoOperacaoBLL tipoOperacaoBLL;
        //protected readonly ITransportesBLL transportesBLL;

        //public BaseHomeRearline(IAguaBLL _aguaBLL, IAluguelBLL _aluguelBLL, IAnoBLL _anoBLL, ICreditoBLL _creditoBLL,
        //                        IDespesasRecebidasBLL _despesasRecebidasBLL, IEnergiaBLL _energiaBLL, IFinanciamentoBLL _financiamentoBLL, IGasBLL _gasBLL,
        //                        IMesBLL _mesBLL, INetTvBLL _netTvBLL, IOrdenadoBLL _ordenadoBLL, IPagamentoCreditoBLL _pagamentoCreditoBLL,
        //                        IPessoaBLL _pessoaBLL, IPlafondACBLL _plafondACBLL, IPoupancaBLL _poupancaBLL, IReceberAluguelBLL _receberAluguelBLL,
        //                        ITelemovelBLL _telemovelBLL, ITipoOperacaoBLL _tipoOperacaoBLL, ITransportesBLL _transportesBLL)
        //{
        //    aguaBLL = _aguaBLL;
        //    aluguelBLL = _aluguelBLL;
        //    anoBLL = _anoBLL;
        //    creditoBLL = _creditoBLL;
        //    despesasAvulsasBLL = _despesasAvulsasBLL;
        //    despesasRecebidasBLL = _despesasRecebidasBLL;
        //    energiaBLL = _energiaBLL;
        //    financiamentoBLL = _financiamentoBLL;
        //    gasBLL = _gasBLL;
        //    mesBLL = _mesBLL;
        //    netTvBLL = _netTvBLL;
        //    ordenadoBLL = _ordenadoBLL;
        //    pagamentoCreditoBLL = _pagamentoCreditoBLL;
        //    pessoaBLL = _pessoaBLL;
        //    plafondACBLL = _plafondACBLL;
        //    poupancaBLL = _poupancaBLL;
        //    receberAluguelBLL = _receberAluguelBLL;
        //    telemovelBLL = _telemovelBLL;
        //    tipoDespesaAvulsaBLL = _tipoDespesaAvulsaBLL;
        //    tipoOperacaoBLL = _tipoOperacaoBLL;
        //    transportesBLL = _transportesBLL;

        //}

        public BaseHomeRearline(IAluguelBLL _aluguelBLL, IAguaBLL _aguaBLL, IAnoBLL _anoBLL, IContratoBLL _contratoBLL, IDespesaAvulsaBLL _despesaAvulsaBLL,
                                IEnergiaBLL _energiaBLL, IMesBLL _mesBLL, INetTvBLL _netTvBLL, IOrdenadoBLL _ordenadoBLL, IPlafondACBLL _plafondACBLL,
                               ITelemovelBLL _telemovelBLL, ITipoDespesaAvulsaBLL _tipoDespesaAvulsaBLL, ITipoContratoBLL _tipoContratoBLL)
        {
            aguaBLL = _aguaBLL;
            aluguelBLL = _aluguelBLL;
            anoBLL = _anoBLL;
            contratoBLL = _contratoBLL;
            despesaAvulsaBLL = _despesaAvulsaBLL;
            energiaBLL = _energiaBLL;
          
            mesBLL = _mesBLL;
            netTvBLL = _netTvBLL;
            ordenadoBLL = _ordenadoBLL;
            plafondACBLL = _plafondACBLL;
            telemovelBLL = _telemovelBLL;
            tipoDespesaAvulsaBLL = _tipoDespesaAvulsaBLL;
            tipoContratoBLL = _tipoContratoBLL;

        }
    }
}
