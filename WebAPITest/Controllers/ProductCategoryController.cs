using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductCategoryController : Controller
    {
        private static readonly List<ProductCategory> ProductCategoryItems = new List<ProductCategory>
        {
            new ProductCategory
            {
                Id = 1, 
                Name = "Vegetables",
                Title="Vegetables",
                Description="Vegetables",
                Image="Images/ProductCategory/vegetables.jpg"
            },
            new ProductCategory
            {
                Id = 2,
                Name = "Fruits",
                Title="Fruits",
                Description="Fruits",
                Image="Images/ProductCategory/fresh-fruits-1.jpg"
            },
            new ProductCategory
            {
                Id = 3,
                Name = "Liquor",
                Title="Liquor",
                Description="Liquor",
                Image="Images/ProductCategory/liquor.jpg"
            },
            new ProductCategory
            {
                Id = 4,
                Name = "Bakery",
                Title="Bakery",
                Description="Bakery",
                Image="Images/ProductCategory/bakery.jpg"
            }


        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<ProductCategory>> Get()
        {
            var todoItem = ProductCategoryItems.ToList();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
    
}
