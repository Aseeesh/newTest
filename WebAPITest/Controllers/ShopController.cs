using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        private static readonly List<Shop> ShopItems = new List<Shop>
        {
            new Shop
            {
          Id=1,
        Name="",
        Location="",
        PanNo="",
        VatNo="",
        Description="",
        cart= new List<ShopCategory>
        {
                      new  ShopCategory
                      {
                                        Id=1,
                                    Name="Local market",
                                    Title="Local market",
                                    Description="Local market",
                                  
                      },
                       new  ShopCategory
                      {
                                   Id=2,
                                    Name="International  market",
                                    Title="International  market",
                                    Description="International  market",
                      },


        }


            }

        };


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Shop>> Get()
        {
            var todoItem = ShopItems.ToList();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    
}
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string PanNo { get; set; }
        public string VatNo { get; set; }
        public string Description { get; set; }
        public List<ShopCategory> cart { get; set; }
    }

    public class ShopCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
    }
    }
