using HHRR.Models;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace HHRR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            Datos datos = Control();
            
            return View(datos);
        }

        [HttpPost]
        public ActionResult Formulario(Datos user)
        {

            
            if (ModelState.IsValid)
            {
                StringBuilder dato = new StringBuilder();
                foreach (var kategori in user.Hobby)
                {
                    if (kategori.Id)
                    {
                        dato.Append(kategori.Nombre + ", ");
                        
                    }
                }
                TempData["Hobby"] = dato;
                return RedirectToAction("ResultadoFormulario", user);
            }
            return View(user);
        }

        public ActionResult ResultadoFormulario(Datos user)
        {

            
            if (TempData["Hobby"] != null)
            {
                ViewBag.Hobby = TempData["Hobby"].ToString();
            }

            return View(user);
        }

        private Datos Control()
        {
            Datos model = new Datos
            {
                Hobby = new List<Controlador>
            {
                new Controlador{Hobby=1, Nombre="Bailar"},
                new Controlador{Hobby=2, Nombre="Nadar"},
                new Controlador{Hobby=3, Nombre="tradding"},
                new Controlador{Hobby=4, Nombre="Saltar"},
            }
            };
            return model;
        }

       
    }
}