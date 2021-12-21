using Microsoft.AspNetCore.Mvc;
using Shop.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
    }
}
