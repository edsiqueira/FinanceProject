using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.BusinessLogic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using RearlineLogicLayer;
using ISqlDataFactory;
using DTO;
using SqlDataFactory;
using ISqlDataFactory.IRepository;
using SqlDataFactory.Repository;

namespace WebFinance
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddNewtonsoftJson();


            services.AddScoped<IAguaBLL, AguaBLL>();
            services.AddScoped<IAluguelBLL, AluguelBLL>();
            services.AddScoped<IAnoBLL, AnoBLL>();
            //services.AddScoped<ICreditoBLL, CreditoBLL>();
            services.AddScoped<IContratoBLL, ContratoBLL>();
            services.AddScoped<IDespesaAvulsaBLL, DespesaAvulsaBLL>();
            //services.AddScoped<IDespesasRecebidasBLL, DespesasRecebidasBLL>();
            services.AddScoped<IEnergiaBLL, EnergiaBLL>();
            //services.AddScoped<IFinanciamentoBLL, FinanciamentoBLL>();
            //services.AddScoped<IGasBLL, GasBLL>();
            services.AddScoped<IMesBLL, MesBLL>();
            services.AddScoped<INetTvBLL, NetTvBLL>();
            services.AddScoped<IOrdenadoBLL, OrdenadoBLL>();
            //services.AddScoped<IPagamentoCreditoBLL, PagamentoCreditoBLL>();
            //services.AddScoped<IPessoaBLL, PessoaBLL>();
            services.AddScoped<IPlafondACBLL, PlafondACBLL>();
            //services.AddScoped<IPoupancaBLL, PoupancaBLL>();
            //services.AddScoped<IReceberAluguelBLL, ReceberAluguelBLL>();
            services.AddScoped<ITelemovelBLL, TelemovelBLL>();
            services.AddScoped<ITipoDespesaAvulsaBLL, TipoDespesaAvulsaBLL>();
            //services.AddScoped<ITipoOperacaoBLL, TipoOperacaoBLL>();
            //services.AddScoped<ITransportesBLL, TransportesBLL>();
            services.AddScoped<ITipoContratoBLL, TipoContratoBLL>();
            services.AddScoped<IBaseRepository<Agua>, BaseRepository<Agua>>();
            services.AddScoped<IBaseRepository<Aluguel>, BaseRepository<Aluguel>>();
            services.AddScoped<IBaseRepository<Ano>, BaseRepository<Ano>>();
            //services.AddScoped<IBaseRepository<Credito>, BaseRepository<Credito>>();
            services.AddScoped<IBaseRepository<Contrato>, BaseRepository<Contrato>>();
            services.AddScoped<IBaseRepository<DespesaAvulsa>, BaseRepository<DespesaAvulsa>>();
            //services.AddScoped<IBaseRepository<DespesasRecebidas>, BaseRepository<DespesasRecebidas>>();
            services.AddScoped<IBaseRepository<Energia>, BaseRepository<Energia>>();
            //services.AddScoped<IBaseRepository<Financiamento>, BaseRepository<Financiamento>>();
            //services.AddScoped<IBaseRepository<Gas>, BaseRepository<Gas>>();
            services.AddScoped<IBaseRepository<Mes>, BaseRepository<Mes>>();
            //services.AddScoped<IMesRepository, MesRepository>();
            //services.AddScoped<IAnoRepository, AnoRepository>();
            services.AddScoped<IContratoRepository, ContratoRepository>();
            //services.AddScoped<IEnumRepository, EnumRepository>();

            services.AddScoped<IBaseRepository<TipoDespesaAvulsa>, BaseRepository<TipoDespesaAvulsa>>();
            services.AddScoped<ITipoDespesaAvulsaRepository, TipoDespesaAvulsaRepository>();

            services.AddScoped<IBaseRepository<NetTV>, BaseRepository<NetTV>>();
            services.AddScoped<IBaseRepository<Ordenado>, BaseRepository<Ordenado>>();
            //services.AddScoped<IBaseRepository<PagamentoCredito>, BaseRepository<PagamentoCredito>>();
            //services.AddScoped<IBaseRepository<Pessoa>, BaseRepository<Pessoa>>();
            services.AddScoped<IBaseRepository<PlafondAC>, BaseRepository<PlafondAC>>();
            //services.AddScoped<IBaseRepository<Poupanca>, BaseRepository<Poupanca>>();
            //services.AddScoped<IBaseRepository<ReceberAluguel>, BaseRepository<ReceberAluguel>>();
            services.AddScoped<IBaseRepository<Telemovel>, BaseRepository<Telemovel>>();
            services.AddScoped<IBaseRepository<TipoContrato>, BaseRepository<TipoContrato>>();
            //services.AddScoped<IBaseRepository<TipoOperacao>, BaseRepository<TipoOperacao>>();

            //services.AddScoped<IBaseRepository<Transportes>, BaseRepository<Transportes>>();

            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IDBManager, DBManager>();
            services.AddScoped<IHomeRearline, HomeRearline>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
