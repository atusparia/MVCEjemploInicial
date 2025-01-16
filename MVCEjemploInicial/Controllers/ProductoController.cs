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
        public ActionResult Index()
        {
            List<ProductoModel> productos = new List<ProductoModel>();

            productos.Add(new ProductoModel { ProductoId=1, ProductoName="Arroz", Descripcion="Arroz extra"});
            productos.Add(new ProductoModel { ProductoId=2, ProductoName="Fideo", Descripcion="Fideos tallarin"});
            productos.Add(new ProductoModel { ProductoId=3, ProductoName="Azúcar", Descripcion="Azúcar rubia"});

            return View(productos);
        }

        public ActionResult Create() 
        { 
            ProductoModel producto = new ProductoModel();

            return View(producto);
        }
    }
}