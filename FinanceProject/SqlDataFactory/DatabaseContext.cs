using DTO;
using ISqlDataFactory;
using System;
using System.Collections.Generic;
using System.Data;

namespace SqlDataFactory
{
    public class DatabaseContext : IDatabaseContext
    {
        private readonly IDBManager dBManager;
        public DatabaseContext(IDBManager _dBManager)
        {
            dBManager = _dBManager;
        }
        public Mes Save(Mes pMes)
        {
            try
            {

                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pMes);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveMes(pMes, dBManager);
                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pMes;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public Ano Save(Ano pAno)
        {
            try
            {

                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pAno);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveAno(pAno, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);
                return pAno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Agua Save(Agua pAgua)
        {
            try
            {

                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pAgua);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveAgua(pAgua, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pAgua;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Energia Save(Energia pEnergia)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pEnergia);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveEnergia(pEnergia, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);
                
                return pEnergia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Telemovel Save(Telemovel pTelemovel)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pTelemovel);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveTelemovel(pTelemovel, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pTelemovel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NetTV Save(NetTV pNetTV)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pNetTV);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveNetTV(pNetTV, dBManager);
                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pNetTV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Aluguel Save(Aluguel pAluguel)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pAluguel);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveAluguel(pAluguel, dBManager);
                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pAluguel;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public TipoDespesaAvulsa Save(TipoDespesaAvulsa pTipoDespesaAvulsa)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pTipoDespesaAvulsa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveTipoDespesaAvulsa(pTipoDespesaAvulsa, dBManager);
                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pTipoDespesaAvulsa;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DespesaAvulsa Save(DespesaAvulsa pDespesaAvulsa)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pDespesaAvulsa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveDespesaAvulsa(pDespesaAvulsa, dBManager);
                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pDespesaAvulsa;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public Contrato Save(Contrato pContrato)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pContrato);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveContrato(pContrato, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pContrato;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public TipoContrato Save(TipoContrato pTipoContrato)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pTipoContrato);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveTipoContrato(pTipoContrato, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pTipoContrato;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Ordenado Save(Ordenado pOrdenado)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pOrdenado);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveOrdenado(pOrdenado, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pOrdenado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public PlafondAC Save(PlafondAC pPlafondAC)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pPlafondAC);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSavePlafondAC(pPlafondAC, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pPlafondAC;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Contrato GetContratoForEntity(int tipoContrato)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetContratoForTipoContrato();

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForGetContratoByTipoContrato(tipoContrato, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);

                var contrato = Contrato.CreateInstance();

                while (dr.Read())
                {
                    contrato.ID = (int)dr["Contrato"];
                    contrato.DataInicio = (DateTime)dr["DataInicio"];
                    contrato.DataFim = (DateTime)dr["DataFim"];
                    contrato.TipoContratoID.ID = (int)dr["TipoContrato"];
                    contrato.TipoContratoID.Empresa = dr["Empresa"].ToString();
                    contrato.TipoContratoID.DescricaoTipoContrato = dr["DescricaoTipoContrato"].ToString();
                    contrato.TipoContratoID.CodTipoContrato = (int)dr["CodTipoContrato"];
                }

                cnVazio.Close();

                return contrato;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
                cnVazio = null;
            }
        }
        public List<Agua> GetAll(Agua pAgua)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pAgua);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pAgua.AnoID, pAgua.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);



                List<Agua> listAgua = new List<Agua>();

                while (dr.Read())
                {
                    var agua = Agua.CreateInstance();
                    agua.Litros = (decimal)dr["Litros"];
                    agua.Valor = (decimal)dr["Valor"];
                    agua.DataProximaLeitura = (DateTime)dr["DataProximaLeitura"];
                    agua.MesID.MesName = dr["MesName"].ToString();
                    agua.AnoID.AnoNumber = (int)dr["AnoNumber"];

                    listAgua.Add(agua);
                }

                cnVazio.Close();

                return listAgua;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Energia> GetAll(Energia pEnergia)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pEnergia);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pEnergia.AnoID, pEnergia.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);

                List<Energia> listEnergia = new List<Energia>();

                while (dr.Read())
                {
                    var energia = Energia.CreateInstance();
                    energia.Cheia = (decimal)dr["Cheia"];
                    energia.Vazio = (decimal)dr["Vazio"];
                    energia.Ponta = (decimal)dr["Ponta"];
                    energia.KwTotal = (decimal)dr["KwTotal"];
                    energia.Valor = (decimal)dr["Valor"];
                    energia.MesID.MesName = dr["MesName"].ToString();
                    energia.AnoID.AnoNumber = (int)dr["AnoNumber"];
                    listEnergia.Add(energia);
                }

                cnVazio.Close();

                return listEnergia;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<NetTV> GetAll(NetTV pNetTV)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pNetTV);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pNetTV.AnoID, pNetTV.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);
                List<NetTV> listNetTV = new List<NetTV>();

                while (dr.Read())
                {
                    var netTv = NetTV.CreateInstance();
                    netTv.Valor = (decimal)dr["Valor"];
                    netTv.Acrescimos = (decimal)dr["Acrescimos"];
                    netTv.Descricao = dr["Descricao"].ToString();
                    netTv.MesID.MesName = dr["MesName"].ToString();
                    netTv.AnoID.AnoNumber = (int)dr["AnoNumber"];

                    listNetTV.Add(netTv);
                }

                cnVazio.Close();

                return listNetTV;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Telemovel> GetAll(Telemovel pTelemovel)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pTelemovel);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pTelemovel.AnoID, pTelemovel.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);

                List<Telemovel> listTelemovel = new List<Telemovel>();

                while (dr.Read())
                {
                    var financiamento = Telemovel.CreateInstance();
                    financiamento.Descricao = dr["Descricao"].ToString();
                    financiamento.Valor = (decimal)dr["Valor"];
                    financiamento.MesID.MesName = dr["MesName"].ToString();
                    financiamento.AnoID.AnoNumber = (int)dr["AnoNumber"];
                    financiamento.Acrescimos = (decimal)dr["Acrescimos"];
                    listTelemovel.Add(financiamento);
                }

                cnVazio.Close();

                return listTelemovel;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Aluguel> GetAll(Aluguel pAluguel)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pAluguel);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pAluguel.AnoID, pAluguel.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);
                List<Aluguel> listAluguel = new List<Aluguel>();

                while (dr.Read())
                {
                    var aluguel = Aluguel.CreateInstance();
                    aluguel.Descricao = dr["Descricao"].ToString();
                    aluguel.Valor = (decimal)dr["Valor"];
                    aluguel.MesID.MesName = dr["MesName"].ToString();
                    aluguel.AnoID.AnoNumber = (int)dr["AnoNumber"];

                    listAluguel.Add(aluguel);
                }

                cnVazio.Close();

                return listAluguel;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Contrato> GetAll(Contrato pContrato)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pContrato);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForGetAllContrato(pContrato, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);
                List<Contrato> listContrato = new List<Contrato>();

                while (dr.Read())
                {
                    var aluguel = Contrato.CreateInstance();
                    aluguel.NumeroContrato = dr["NumeroContrato"].ToString();
                    aluguel.Ativo = (bool)dr["Ativo"];
                    aluguel.DataFim = (DateTime)dr["DataFim"];
                    aluguel.DataInicio = (DateTime)dr["DataInicio"];
                    aluguel.TipoContratoID.DescricaoTipoContrato = dr["DescricaoTipoContrato"].ToString();

                    listContrato.Add(aluguel);
                }

                cnVazio.Close();

                return listContrato;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Ordenado> GetAll(Ordenado pOrdenado)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pOrdenado);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pOrdenado.AnoID, pOrdenado.MesID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);
                List<Ordenado> listOrdenado = new List<Ordenado>();

                while (dr.Read())
                {
                    var ordenado = Ordenado.CreateInstance();
                    ordenado.AjudasCusto = (decimal)dr["AjudasCusto"];
                    ordenado.Base = (decimal)dr["Base"];
                    ordenado.DataRececao = (DateTime)dr["DataRececao"];
                    ordenado.DuodecimosFerias = (decimal)dr["DuodecimosFerias"];
                    ordenado.DuodecimosNatal = (decimal)dr["DuodecimosNatal"];
                    ordenado.IRS = (decimal)dr["IRS"];
                    ordenado.SegurancaSocial = (decimal)dr["SegurancaSocial"]; 
                    ordenado.SubsidioRefeicao = (decimal)dr["SubsidioRefeicao"];
                    ordenado.MesID.MesName = (string)dr["MesName"];
                    ordenado.AnoID.AnoNumber = (int)dr["AnoNumber"];

                    listOrdenado.Add(ordenado);
                }

                cnVazio.Close();

                return listOrdenado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<PlafondAC> GetAll(PlafondAC pPlafondAC)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pPlafondAC);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForGetAllPlafondAC(pPlafondAC.AnoID, dBManager);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, paramList, out cnVazio);
                List<PlafondAC> listPlafondAC = new List<PlafondAC>();

                while (dr.Read())
                {
                    var plafondAC = PlafondAC.CreateInstance();
                    plafondAC.Total = (decimal)dr["Total"];
                    plafondAC.ValorDisponivel = (decimal)dr["ValorDisponivel"];
                    plafondAC.ValorMensal = (decimal)dr["ValorMensal"];
                    plafondAC.AnoID.AnoNumber = (int)dr["AnoNumber"];

                    listPlafondAC.Add(plafondAC);
                }

                cnVazio.Close();

                return listPlafondAC;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Mes> GetAll(Mes pMes)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pMes);

                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                //var paramList = null;

                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<Mes> listMes = new List<Mes>();

                while (dr.Read())
                {
                    var mes = Mes.CreateInstance();
                    mes.MesName = dr["MesName"].ToString();
                    mes.MesNumber = (int)dr["MesNumber"];
                    listMes.Add(mes);
                }

                cnVazio.Close();

                return listMes;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<Ano> GetAll(Ano pAno)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pAno);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<Ano> listAno = new List<Ano>();

                while (dr.Read())
                {
                    var ano = Ano.getNew();
                    ano.AnoNumber = (int)dr["AnoNumber"];
                    listAno.Add(ano);
                }

                cnVazio.Close();

                return listAno;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<TipoDespesaAvulsa> GetAllTipoDespesaAvulsa()
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAllTipoDespesaAvulsa();
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);
                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<TipoDespesaAvulsa> listTipoDespesaAvulsa = new List<TipoDespesaAvulsa>();

                while (dr.Read())
                {
                    var tipoDespesa = TipoDespesaAvulsa.getNew();
                    tipoDespesa.CodDespesa = (int)dr["CodDespesa"];
                    tipoDespesa.Nome = (string)dr["Nome"];
                    listTipoDespesaAvulsa.Add(tipoDespesa);
                }

                cnVazio.Close();

                return listTipoDespesaAvulsa;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<DespesaAvulsa> GetAll(DespesaAvulsa pDespesaAvulsa)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pDespesaAvulsa);
                var stored = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForListByYearAndMonth(pDespesaAvulsa.AnoID, pDespesaAvulsa.MesID, dBManager);

                List<DespesaAvulsa> listDespesaAvulsa = new List<DespesaAvulsa>();
                var dr = dBManager.GetDataReader(stored.CommandText, stored.CommandType, paramList, out cnVazio);
                while (dr.Read())
                {
                    var tipoDespesa = DespesaAvulsa.getNew();
                    tipoDespesa.DataDespesa = (DateTime)dr["DataDespesa"];
                    tipoDespesa.Descricao = (string)dr["Descricao"];
                    tipoDespesa.MesID.MesName = (string)dr["MesName"];
                    tipoDespesa.AnoID.AnoNumber = (int)dr["AnoNumber"];
                    tipoDespesa.TipoDespesaAvulsaID.Nome = (string)dr["Nome"];
                    tipoDespesa.Valor = (decimal)dr["Valor"];
                    listDespesaAvulsa.Add(tipoDespesa);
                }

                cnVazio.Close();

                return listDespesaAvulsa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<TipoContrato> GetAll(TipoContrato pTipoContrato)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pTipoContrato);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<TipoContrato> listTipoContrato = new List<TipoContrato>();

                while (dr.Read())
                {
                    var tipoContrato = TipoContrato.CreateInstance();
                    tipoContrato.DescricaoTipoContrato = (string)dr["DescricaoTipoContrato"];
                    tipoContrato.CodTipoContrato = (int)dr["CodTipoContrato"];
                    tipoContrato.Empresa = (string)dr["Empresa"];

                    listTipoContrato.Add(tipoContrato);
                }

                cnVazio.Close();

                return listTipoContrato;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public Pessoa Save(Pessoa pPessoa)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pPessoa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSavePessoa(pPessoa, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pPessoa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public AluguelPessoa Save(AluguelPessoa pAluguelPessoa)
        {
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForSave(pAluguelPessoa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var paramList = SqlDatabaseCreateCommnad.CreateParameterForSaveAluguelPessoa(pAluguelPessoa, dBManager);

                dBManager.ExecuteStoredProcedure(storedProcedure.CommandText, storedProcedure.CommandType, paramList);

                return pAluguelPessoa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Pessoa> GetAll(Pessoa pPessoa)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pPessoa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<Pessoa> listPessoa = new List<Pessoa>();

                while (dr.Read())
                {
                    var pessoa = Pessoa.CreateInstance();
                    pessoa.Nome = (string)dr["Nome"];
                    pessoa.QuantidadePessoa = (int)dr["QuantidadePessoa"];
                    pessoa.CodigoId = (int)dr["CodigoId"];

                    listPessoa.Add(pessoa);
                }

                cnVazio.Close();

                return listPessoa;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
        public List<AluguelPessoa> GetAll(AluguelPessoa pAluguelPessoa)
        {
            IDbConnection cnVazio = null;
            try
            {
                var command = SqlDatabaseCreateCommnad.CreateCommandForGetAll(pAluguelPessoa);
                var storedProcedure = dBManager.CreateStoredProcedure(command, CommandType.StoredProcedure);

                var dr = dBManager.GetDataReader(storedProcedure.CommandText, storedProcedure.CommandType, null, out cnVazio);

                List<AluguelPessoa> listAluguelPessoa = new List<AluguelPessoa>();

                while (dr.Read())
                {
                    var aluguelPessoa = AluguelPessoa.CreateInstance();
                    aluguelPessoa.ValorContrato = (decimal)dr["ValorContrato"];
                    aluguelPessoa.ValorPagamento = (decimal)dr["ValorPagamento"];
                    aluguelPessoa.PessoaID.Nome = (string)dr["Nome"];
                    aluguelPessoa.AnoID.AnoNumber= (int)dr["AnoNumber"];
                    aluguelPessoa.MesID.MesName = (string)dr["MesName"];

                    listAluguelPessoa.Add(aluguelPessoa);
                }

                cnVazio.Close();

                return listAluguelPessoa;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnVazio.Dispose();
                cnVazio.Close();
            }
        }
    }
}

