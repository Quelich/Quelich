using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Quelich.Models;
using Quelich.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quelich.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService) // I need some stuff ASP.NET, go get it!!
        {
            _logger = logger;
            ProductService = productService; 
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts(); // Index page knows about Products 
        }
    }
}
