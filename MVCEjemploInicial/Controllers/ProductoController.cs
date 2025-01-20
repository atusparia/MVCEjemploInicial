using MVCEjemploInicial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemploInicial.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto

        [HttpGet]
        public ActionResult Index()
        {
            List<ProductoModel> productos = new List<ProductoModel>();

            /*
            productos.Add(new ProductoModel { ProductoId=1, ProductoName="Arroz", Descripcion="Arroz extra"});
            productos.Add(new ProductoModel { ProductoId=2, ProductoName="Fideo", Descripcion="Fideos tallarin"});
            productos.Add(new ProductoModel { ProductoId=3, ProductoName="Azúcar", Descripcion="Azúcar rubia"});
            */

            if (Session["Productos"] != null)
            {
                productos = (List<ProductoModel>)Session["Productos"];
            }
            else 
            {
                Session["Productos"] = productos;
            }

            return View(productos);
        }

        [HttpGet]
        public ActionResult Create() 
        { 
            ProductoModel producto = new ProductoModel();

            return View(producto);
        }

        [HttpPost]
        public ActionResult Create(ProductoModel model)
        { 
            ((List<ProductoModel>)Session["Productos"]).Add(model);  

            return RedirectToAction("Index");
        }
    }
}