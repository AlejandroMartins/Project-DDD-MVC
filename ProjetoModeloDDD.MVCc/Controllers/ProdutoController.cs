using AutoMapper;
using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVCD.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoApp;

        public ProdutoController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        // GET: Produto
        public ActionResult Index()
        {
            var produtoviewmodel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoviewmodel);

        }

        public ActionResult GraficoProdutos()
        {
            var produtoviewmodel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetGraphicProdutos());
            ViewBag.TicketMedio = _produtoApp.GetTicketMedio();
            return View(produtoviewmodel);
        }

        public ActionResult TicketMedio()
        {
            var produtoviewmodel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetGraphicProdutos());
            ViewBag.TicketMedio = _produtoApp.GetTicketMedio();
            return View(produtoviewmodel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }
            return View(produto);
        }

    }
}