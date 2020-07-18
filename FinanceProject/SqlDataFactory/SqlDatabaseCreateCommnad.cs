using DTO;
using ISqlDataFactory;
using SqlDataFactory.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace SqlDataFactory
{
    public class SqlDatabaseCreateCommnad
    {
        public static string CreateCommandForSave(object pObject)
        {
            var prop = pObject.GetType().GetProperties();
            var name = pObject.GetType().Name;
            var idValue = 0;
            for (int i = 0; i < prop.Length; i++)
            {
                if (prop[i].Name == "ID")
                {
                    idValue = (int)prop[i].GetValue(pObject, new object[] { });
                    break;
                }
            }
            
            if (idValue == 0)
                return string.Format("[dbo].[{0}_Ins]", name);

            else
                return string.Format("[dbo].[{0}_Upd]", name);
        }
     
        /****************************/
        /*       GET METHODS        */
        /****************************/

        public static string CreateCommandForGetContratoForTipoContrato()
        {
            return "[dbo].[GetContratoByTipoContrato]";
        }

        public static string CreateCommandForGetAllTipoDespesaAvulsa()
        {
            return "[dbo].[TipoDespesaAvulsa_GetAll]";
        } 

        public static string CreateCommandForGetAll(object pObject)
        {
            var name = pObject.GetType().Name;
            return string.Format("[dbo].[{0}_GetAll]", name);
        }
        /*******************************************/
        /*       CREATE PARAMETERS FOR SAVE        */
        /*******************************************/

        public static List<IDbDataParameter> CreateParameterForSaveDespesaAvulsa(DespesaAvulsa pDespesaAvulsa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pDespesaAvulsa.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Descricao", pDespesaAvulsa.Descricao, DbType.String));
            paramList.Add(dBManager.CreateParameter("@DataDespesa", pDespesaAvulsa.DataDespesa, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pDespesaAvulsa.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pDespesaAvulsa.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@CodDespesa", pDespesaAvulsa.TipoDespesaAvulsaID.CodDespesa, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveMes(Mes pMes, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@MesNumber", pMes.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@MesName", pMes.MesName, DbType.String));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveAno(Ano pAno, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAno.AnoNumber, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveAgua(Agua pAgua, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pAgua.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Litros", pAgua.Litros, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@DataProximaLeitura", pAgua.DataProximaLeitura, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pAgua.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAgua.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pAgua.ContratoID.TipoContratoID.CodTipoContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@InicioFaturacao", pAgua.InicioFaturacao, DbType.Date));
            paramList.Add(dBManager.CreateParameter("@FimFaturacao", pAgua.FimFaturacao, DbType.Date));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveEnergia(Energia pEnergia, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pEnergia.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Cheia", pEnergia.Cheia, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Vazio", pEnergia.Vazio, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Ponta", pEnergia.Ponta, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@KwTotal", pEnergia.KwTotal, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@InicioFaturacao", pEnergia.InicioFaturacao, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@FimFaturacao", pEnergia.FimFaturacao, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pEnergia.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pEnergia.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pEnergia.ContratoID.TipoContratoID.CodTipoContrato, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveTelemovel(Telemovel pTelemovel, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pTelemovel.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Acrescimos", pTelemovel.Acrescimos, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Descricao", pTelemovel.Descricao, DbType.String));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pTelemovel.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pTelemovel.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pTelemovel.ContratoID.TipoContratoID.CodTipoContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@InicioFaturacao", pTelemovel.InicioFaturacao, DbType.Date));
            paramList.Add(dBManager.CreateParameter("@FimFaturacao", pTelemovel.FimFaturacao, DbType.Date));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveNetTV(NetTV pNetTV, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pNetTV.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Acrescimos", pNetTV.Acrescimos, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Descricao", pNetTV.Descricao, DbType.String));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pNetTV.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pNetTV.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pNetTV.ContratoID.TipoContratoID.CodTipoContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@InicioFaturacao", pNetTV.InicioFaturacao, DbType.Date));
            paramList.Add(dBManager.CreateParameter("@FimFaturacao", pNetTV.FimFaturacao, DbType.Date));
            return paramList;
        }
        public static List<IDbDataParameter> CreateParameterForSaveAluguel(Aluguel pAluguel, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@Valor", pAluguel.Valor, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Descricao", pAluguel.Descricao, DbType.String));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pAluguel.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAluguel.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pAluguel.ContratoID.TipoContratoID.CodTipoContrato, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveTipoDespesaAvulsa(TipoDespesaAvulsa pTipoDespesaAvulsa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@CodDespesa", pTipoDespesaAvulsa.CodDespesa, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Nome", pTipoDespesaAvulsa.Nome, DbType.String));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveContrato(Contrato pContrato, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@DataInicio", pContrato.DataInicio, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@DataFim", pContrato.DataFim, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@NumeroContrato", pContrato.NumeroContrato, DbType.String));
            paramList.Add(dBManager.CreateParameter("@TipoContrato", pContrato.TipoContratoID.CodTipoContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@Ativo", pContrato.Ativo, DbType.Boolean));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveTipoContrato(TipoContrato pTipoContrato, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@CodTipoContrato", pTipoContrato.CodTipoContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@DescricaoTipoContrato", pTipoContrato.DescricaoTipoContrato, DbType.String));
            paramList.Add(dBManager.CreateParameter("@Empresa", pTipoContrato.Empresa, DbType.String));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveOrdenado(Ordenado pOrdenado, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@AjudasCusto", pOrdenado.AjudasCusto, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@Base", pOrdenado.Base, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@DataRececao", pOrdenado.DataRececao, DbType.DateTime));
            paramList.Add(dBManager.CreateParameter("@DuodecimosFerias", pOrdenado.DuodecimosFerias, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@DuodecimosNatal", pOrdenado.DuodecimosNatal, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@SegurancaSocial", pOrdenado.SegurancaSocial, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@SubsidioRefeicao", pOrdenado.SubsidioRefeicao, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@IRS", pOrdenado.IRS, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pOrdenado.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pOrdenado.AnoID.AnoNumber, DbType.Int32));
            return paramList;
        }
        public static List<IDbDataParameter> CreateParameterForSavePlafondAC(PlafondAC pPlafondAC, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pPlafondAC.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@Total", pPlafondAC.Total, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@ValorDisponivel", pPlafondAC.ValorDisponivel, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@ValorMensal", pPlafondAC.ValorMensal, DbType.Decimal));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSavePessoa(Pessoa pPessoa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@CodigoId", pPessoa.CodigoId, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@Nome", pPessoa.Nome, DbType.String));
            paramList.Add(dBManager.CreateParameter("@QuantidadePessoa", pPessoa.QuantidadePessoa, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForSaveAluguelPessoa(AluguelPessoa pAluguelPessoa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAluguelPessoa.AnoID.AnoNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pAluguelPessoa.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@CodigoId", pAluguelPessoa.PessoaID.CodigoId, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@ValorContrato", pAluguelPessoa.ValorContrato, DbType.Decimal));
            paramList.Add(dBManager.CreateParameter("@ValorPagamento", pAluguelPessoa.ValorPagamento, DbType.Decimal));
            return paramList;
        }
        /*******************************************/
        /*       CREATE PARAMETERS FOR LIST        */
        /*******************************************/

        public static List<IDbDataParameter> CreateParameterForListByYearAndMonth(Ano pAno, Mes pMes, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@MesNumber", pMes.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAno.AnoNumber, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForListDespesaAvulsa(DespesaAvulsa pDespesaAvulsa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@MesNumber", pDespesaAvulsa.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pDespesaAvulsa.AnoID.AnoNumber, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForGetContratoByTipoContrato(int tipoContrato, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@TipoContrato", tipoContrato, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForGetAllContrato(Contrato pContrato, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@NumeroContrato", pContrato.NumeroContrato, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@TipoContratoID", pContrato.TipoContratoID.CodTipoContrato, DbType.Int32));
            return paramList;
        }
        public static List<IDbDataParameter> CreateParameterForGetAllPlafondAC(Ano pAno, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAno.AnoNumber, DbType.Int32));
            return paramList;
        }

        public static List<IDbDataParameter> CreateParameterForGetAluguelPessoa(AluguelPessoa pAluguelPessoa, IDBManager dBManager)
        {
            List<IDbDataParameter> paramList = new List<IDbDataParameter>();
            //paramList.Add(dBManager.CreateParameter("@CodigoId", pAluguelPessoa.ID, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@MesNumber", pAluguelPessoa.MesID.MesNumber, DbType.Int32));
            paramList.Add(dBManager.CreateParameter("@AnoNumber", pAluguelPessoa.AnoID.AnoNumber, DbType.Int32));
            return paramList;
        }

    }
}
