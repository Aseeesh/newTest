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
                Id=1,
                CustomerId = 1,
                Email = "eat fish",
                Phone = "eat fish",
                DeliveryPoint = "feed fish",
                Name = "feed fish",
                ShopId = 1,
                PaymentMethod = 1,
                Status = 1,
                  Vat = 1.2,
                Total =122,
                AccountCart= new List<CartDto>
                    {
                                  new  CartDto
                                  {
                                                    Id=1,
                                                Name="clos marvin",
                                                Title="clos marvin",
                                                Image= "Images/Product/clos marvin.jpg",
                                                Price=120,
                                                ProductId=1,
                                                Quantity=2, 
                                  },
                                   new  CartDto
                                  {
                                                    Id=2,
                                                Name="Mango",
                                                Title="",
                                                Image="Images/Product/kiwi.jpg",
                                                Price=60,
                                                ProductId=6,
                                                Quantity=2,
                                                AccountId=0
                                  },


                    }


            },
             new AccountItem
            {
                   Id=2,
                CustomerId = 1,
        Email = "feed fish",
        Phone = "feed fish",
        DeliveryPoint = "feed fish",
        Name = "feed fish",
        ShopId = 1,
        PaymentMethod = 1,
        Status = 2,
          Vat = 1.2,
        Total =122,
        AccountCart= new List<CartDto>
        {
                      new  CartDto
                      {
                                     Id =11,
                                    Name ="Breads",
                                    Title ="organic",
                                    Image ="Images/Product/breads.jpg",
                                    Price =2660,
                                    ProductId=1,
                                    Quantity=2,
                      },
                       new  CartDto
                      {
                                    Id =12,
                                    Name ="Cup cakes",
                                    Title ="organic",
                                    Image ="Images/Product/cupcake.jpg",
                                    Price =2660,
                                     ProductId=6,
                                    Quantity=2,
                                    AccountId=0
                      },


        }


             },
             new AccountItem
            {
                   Id=3,
                CustomerId = 1,
        Email = "feed ",
        Phone = "feed ",
        DeliveryPoint = "feed ",
        Name = "feed ",
        ShopId = 1,
        PaymentMethod = 1,
        Status = 2,
          Vat = 1.2,
        Total =122,
        AccountCart= new List<CartDto>
        {
                      new  CartDto
                      {
                                     Id =11,
                                    Name ="Breads",
                                    Title ="organic",
                                    Image ="Images/Product/breads.jpg",
                                    Price =2660,
                                    ProductId=1,
                                    Quantity=2,
                      },
                       new  CartDto
                      {
                                    Id =12,
                                    Name ="Cup cakes",
                                    Title ="organic",
                                    Image ="Images/Product/cupcake.jpg",
                                    Price =2660,
                                     ProductId=6,
                                    Quantity=2,
                                    AccountId=0
                      },
                   
                       new  CartDto
                      {
                                    Id =12,
                                    Name ="Kiwi",
                                    Title ="organic",
                                    Image ="Images/Product/kiwi.jpg",
                                    Price =2660,
                                     ProductId=6,
                                    Quantity=2,
                                    AccountId=0
                      },


        }


             }






        };


        [HttpGet("{CustomerId}/{Status}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<AccountItem>> Get(int CustomerId = 0, int Status = 0)
        {
            if (CustomerId > 0)
            {
                return AccuntItems.Where(x=>x.CustomerId==CustomerId&& x.Status==Status).ToList();
            }
            else
            {
            var todoItem = AccuntItems.ToList();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;

            }
        }

        [HttpGet("[action]/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<AccountItem>> GetById(int Id)
        {
            var todoItem = AccuntItems.Where(x=>x.Id == Id).ToList();

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
    public class AccountItem
    {
        public int Id { get; set; }
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
        public List<CartDto> AccountCart { get; set; }
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
