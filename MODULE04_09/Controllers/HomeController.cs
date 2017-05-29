using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODULE04_09.DAL;
using MODULE04_09.Models;

namespace MODULE04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductById_new(int id)
        {
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductByIdNew(id);
            return View(result);
        }
        
        //Get: Home/ProductByID/1
        //Get: Home/ProductByID?ID=1
        public ActionResult ProductByID(int id)
        {
            ProductSystem sys = new ProductSystem();
            //result不再是Product物件，而是ProductViewModel物件
            //剩下三個欄位而已
            var result = sys.GetProductByID(id);

            return View(result);
        }

        public ActionResult ProductsByCategory(int id)
        {
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductsByCategoryID(id);
            return View(result);
        }
    }
}