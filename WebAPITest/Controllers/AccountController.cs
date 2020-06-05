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
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private static readonly List<AccountItem> AccuntItems = new List<AccountItem>
        {
            new AccountItem
            {
                CustomerId = 1,
        Email = "feed fish",
        Phone = "feed fish",
        DeliveryPoint = "feed fish",
        Name = "feed fish",
        ShopId = 1,
        PaymentMethod = 1,
        Status = 1,
          Vat = 1.2,
        Total =122,
        cart= new List<CartDto>
        {
                      new  CartDto
                      {
                                        Id=1,
                                    Name="potato",
                                    Title="organic",
                                    Image= "https://images.all-free-download.com/images/graphiclarge/potatoes_highdefinition_picture_4_167260.jpg",
                                    Price=120,
                                    ProductId=1,
                                    Quantity=2, 
                      },
                       new  CartDto
                      {
                                        Id=2,
                                    Name="Mango",
                                    Title="",
                                    Image="https://images-na.ssl-images-amazon.com/images/I/71GpOmt0CVL._SL1500_.jpg",
                                    Price=60,
                                    ProductId=6,
                                    Quantity=2,
                                    AccountId=0
                      },


        }


            }

        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<AccountItem>> Get()
        {
            var todoItem = AccuntItems.ToList();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
    public class AccountItem
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DeliveryPoint { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }
        public int PaymentMethod { get; set; }
        public int Status { get; set; }
        public double Vat { get; set; }
        public double Total { get; set; }
        public List<CartDto> cart { get; set; }
    }
    public class CartDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int AccountId { get; set; }
    }
}
