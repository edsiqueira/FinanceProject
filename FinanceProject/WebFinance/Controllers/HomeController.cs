using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RearlineLogicLayer;
using WebFinance.Models;

namespace WebFinance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRearline _rearline;

        public HomeController(ILogger<HomeController> logger, IHomeRearline rearline)
        {
            _logger = logger;
            _rearline = rearline;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult aguaPartialView()
        {
            return PartialView("~/Views/Home/Partials/_Agua.cshtml");
        }

        public IActionResult energiaPartialView()
        {
            return PartialView("~/Views/Home/Partials/_Energia.cshtml");
        }
        public IActionResult tvnetPartialView()
        {
            return PartialView("~/Views/Home/Partials/_NetTv.cshtml");
        }

        public IActionResult telemovelPartialView()
        {
            return PartialView("~/Views/Home/Partials/_Telemovel.cshtml");
        }
        public IActionResult despesaAvulsaPartialView()
        {
            return PartialView("~/Views/Home/Partials/_DespesaAvulsa.cshtml");
        }
        public IActionResult configuracaoPartialView()
        {
            return PartialView("~/Views/Home/Partials/_Configuracao.cshtml");
        }

        public IActionResult aluguelPartialView()
        {
            return PartialView("~/Views/Home/Partials/_Aluguel.cshtml");
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddAgua([FromBody]Agua pAgua)
        {
            if (pAgua != null)
            {
                _rearline.AddAgua(pAgua);
                return Json(pAgua);
            }
            else
                return Error();
        }
        [HttpPost]
        public IActionResult AddEnergia([FromBody]Energia pEnergia)
        {
            if (pEnergia != null) 
            {
                _rearline.AddEnergia(pEnergia);
                return Json(pEnergia);
            }

            else
                return Error();
           
        }
        [HttpPost]
        public IActionResult AddTipoDespesaAvuslsa([FromBody]TipoDespesaAvulsa pTipoDespesaAvulsa)
        {
            if (pTipoDespesaAvulsa != null)
            {
                _rearline.AddTipoDespesaAvulsa(pTipoDespesaAvulsa);
                return Json(pTipoDespesaAvulsa);
            }

            else
                return Error();

        }
        [HttpPost]
        public IActionResult AddTelemovel([FromBody]Telemovel pTelemovel)
        {
            if (pTelemovel != null)
            {
                _rearline.AddTelemovel(pTelemovel);
                return Json(pTelemovel);
            }

            else
                return Json("");

        }
        [HttpPost]
        public IActionResult AddContrato([FromBody]Contrato pContrato)
        {
            if (pContrato != null)
            {
                _rearline.AddContrato(pContrato);
                return Json(pContrato);
            }

            else
                return Json("");

        }
        [HttpPost]
        public IActionResult AddNetTV([FromBody]NetTV pNetTV)
        {
            if (pNetTV != null)
            {
                _rearline.AddNetTv(pNetTV);
                return Json(pNetTV);
            }

            else
                return Json("");

        }
        [HttpPost]
        public IActionResult AddOrdenado([FromBody]Ordenado pOrdenado)
        {
            if (pOrdenado != null)
            {
                _rearline.AddOrdenado(pOrdenado);
                return Json(pOrdenado);
            }

            else
                return Json("");

        }
        [HttpPost]
        public IActionResult AddPlafondAC([FromBody]PlafondAC pPlafondAC)
        {
            if (pPlafondAC != null)
            {
                _rearline.AddPlafondAC(pPlafondAC);
                return Json(pPlafondAC);
            }

            else
                return Json("");

        }
        [HttpPost]
        public IActionResult AddDespesaAvulsa([FromBody]DespesaAvulsa pDespesaAvulsa)
        {
            if (pDespesaAvulsa != null)
            {
                _rearline.AddDespesaAvulsa(pDespesaAvulsa);
                return Json(pDespesaAvulsa);
            }
            else
                return Json("Erro");
        }

        [HttpPost]
        public IActionResult AddAluguel([FromBody]Aluguel pAluguel)
        {
            if (pAluguel != null)
            {
                _rearline.AddAluguel(pAluguel);
                return Json(pAluguel);
            }
            else
                return Json("Erro");
        }

        [HttpPost]
        public IActionResult AddAluguelPessoa([FromBody]List<AluguelPessoa> pAluguelPessoa)
        {
            if (pAluguelPessoa != null)
            {
                //_rearline.AddAluguel(pAluguel);
                return Json(pAluguelPessoa);
            }
            else
                return Json("Erro");
        }

        [HttpPost]
        public void AddAno(Ano pAno)
        {
            _rearline.AddAno(pAno);
        }
        public IActionResult AddTipoContrato([FromBody]TipoContrato pTipoContrato)
        {
            if (pTipoContrato != null)
            {
                _rearline.AddTipoContrato(pTipoContrato);
                return Json(pTipoContrato);
            }

            else
                return Json("");

        }

        [HttpGet]
        public IActionResult GetAllAgua()
        {
            return Json(_rearline.GetAllAgua());
        }
        [HttpGet]
        public IActionResult GetAllMes()
        {
            return Json(_rearline.GetAllMes());
        }
        [HttpGet]
        public IActionResult GetAllAno()
        {
            return Json(_rearline.GetAllAno());
        }
        [HttpGet]
        public IActionResult GetAllEnergia()
        {
            return Json(_rearline.GetAllEnergia());
        }
        [HttpGet]
        public IActionResult GetAllTelemovel()
        {
            return Json(_rearline.GetAllTelemovel());
        }
        [HttpGet]
        public IActionResult GetAllNetTv()
        {
            return Json(_rearline.GetAllNetTV());
        }
        [HttpGet]
        public IActionResult GetAllAluguel()
        {
            return Json(_rearline.GetAllAluguel());
        }
        [HttpGet]
        public IActionResult GetAllTipoDespesaAvulsa()
        {
            return Json(_rearline.GetAllTipoDespesaAvulsa());
        }
        [HttpGet]
        public IActionResult GetAllDespesaAvulsa()
        {
            return Json(_rearline.GetAllDespesaAvulsa());
        }
        [HttpGet]
        public IActionResult GetAllContrato()
        {
            return Json(_rearline.GetAllContrato());
        }

        [HttpGet]
        public IActionResult GetAllPlafondAC()
        {
            return Json(_rearline.GetAllPlafondAC());
        }

        [HttpGet]
        public IActionResult GetAllTipoContrato()
        {
            return Json(_rearline.GetAllTipoContrato());
        }

        [HttpGet]
        public IActionResult GetAllOrdenado()
        {
            return Json(_rearline.GetAllOrdenado());
        }
    }
}
