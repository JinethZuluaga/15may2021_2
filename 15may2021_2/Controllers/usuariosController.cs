using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _15may2021_2.Models;


namespace _15may2021_2.Controllers
{
    public class usuariosController : Controller
    {
        // GET: usuarios
        public ActionResult Index()
        {
            using (var db = new inventario2021Entities())
            {
                return View(db.usuario.ToList());
            }
        }
    }
}