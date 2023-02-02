using AutoMapper;
using AutoMapper.Configuration;
using Dapper;
using Microsoft.Data.Sqlite;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVCc.Controllers
{
   
    public class GraphicsController : Controller
    {
   

        // GET: Graphics
        public ActionResult Index()
        {
            return View();
        }




  
        

    }
}