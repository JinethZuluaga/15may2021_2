using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _15may2021_2.Models;

namespace _15may2021_2.Controllers
{
    public class UsuarioRolController : Controller
    {
        // GET: Compras
        public ActionResult Index()
        {
            using (var db = new inventario2021Entities())
            {
                return View(db.usuariorol.ToList());
            }
        }

        public static string NombreUsuarioRol(int idUsuarioRol)
        {
            using (var db = new inventario2021Entities())
            {
                return db.usuario.Find(idUsuarioRol).nombre;
            }
        }


        public ActionResult ListarUsuarioRol()
        {
            using (var db = new inventario2021Entities())
            {
                return PartialView(db.roles.ToList());
            }
        }

        public static string NombreRol(int idRol)
        {
            using (var db = new inventario2021Entities())
            {
                return db.roles.Find(idRol).descripcion;
            }
        }

        public ActionResult ListarRol()
        {
            using (var db = new inventario2021Entities())
            {
                return PartialView(db.roles.ToList());
            }
        }
        public ActionResult Create()
        {
            return View();
        }

       
    }
}