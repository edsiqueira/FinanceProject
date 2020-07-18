using DAL.Configuration;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Agua> Agua { get; set; }
        //public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Ano> Ano { get; set; }
        //public DbSet<Credito> Credito { get; set; }
        //public DbSet<DespesasAvulsas> DespesasAvulsas { get; set; }
        //public DbSet<DespesasRecebidas> DespesasRecebidas { get; set; }
        //public DbSet<Energia> Energia { get; set; }
        //public DbSet<Financiamento> Financiamento { get; set; }
        //public DbSet<Gas> Gas { get; set; }
        //public DbSet<NetTV> NetTV { get; set; }
        //public DbSet<Ordenado> Ordenado { get; set; }
        //public DbSet<PagamentoCredito> PagamentoCredito { get; set; }
        //public DbSet<Pessoa> Pessoa { get; set; }
        //public DbSet<PlafondAC> PlafondAC { get; set; }
        //public DbSet<Poupanca> Poupanca { get; set; }
        //public DbSet<ReceberAluguel> ReceberAluguel { get; set; }
        //public DbSet<Telemovel> Telemovel { get; set; }
        //public DbSet<TipoDespesaAvulsa> TipoDespesaAvulsa { get; set; }
        //public DbSet<TipoOperacao> TipoOperacao { get; set; }
        //public DbSet<Transportes> Transportes { get; set; }


        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AguaConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
