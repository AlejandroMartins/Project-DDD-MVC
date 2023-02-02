using AutoMapper;
using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVCD.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaAppService _VendaApp;

        public VendaController(IVendaAppService VendaApp)
        {
            _VendaApp = VendaApp;
        }

        // GET: Venda
        public ActionResult Index()
        {
            return View();
        }

       


    }
}