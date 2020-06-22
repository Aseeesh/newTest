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
    public class ProductController : Controller
    {
        private static readonly List<Product> ProductItems = new List<Product>
        {
            new Product
                        {
                      Id =1,
                    ShopId =1,
                    Name ="potato",
                    Title ="organic",
                    Image ="Images/Product/potato.jpg",
                    IsTrending =1,
                      Price =120,
                    Description = "120 per kg",
                    ProductCategoryId=1 ,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =2,
                                        Name ="Fruits",
                                        Description ="Fruits",
                                        Image ="Images/ProductCategory/vegetables.jpg",
                                        Title ="Fruits",
                                  }

                            }

                        }
                        ,
            new Product
                        {
                      Id =2,
                    ShopId =1,
                    Name ="Tomato",
                    Title ="organic",
                    Image ="Images/Product/tomato.jpg",
                    IsTrending =1,
                      Price =60,
                    Description = "60 per kg",
                    ProductCategoryId=1,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =2,
                                        Name ="Fruits",
                                        Description ="Fruits",
                                        Image ="Images/ProductCategory/vegetables.jpg",
                                        Title ="Fruits",
                                  }

                            }

                        },
            new Product
                        {
                      Id =3,
                    ShopId =1,
                    Name ="Mango",
                    Title ="organic",
                    Image ="Images/Product/mango.jpg",
                    IsTrending =1,
                      Price =60,
                    Description = "60 per kg",
                    ProductCategoryId=2,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =2,
                                        Name ="Fruits",
                                        Description ="Fruits",
                                        Image ="Images/ProductCategory/fresh-fruits-1.jpg",
                                        Title ="Fruits",
                                  }

                            }

                        },

             new Product
                        {
                      Id =4,
                    ShopId =1,
                    Name ="Strawberry",
                    Title ="organic",
                    Image ="Images/Product/strawberry.jpg",
                    IsTrending =1,
                      Price =60,
                    Description = "60 per kg",
                    ProductCategoryId=2,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =2,
                                        Name ="Fruits",
                                        Description ="Fruits",
                                        Image ="Images/ProductCategory/fresh-fruits-1.jpg",
                                        Title ="Fruits",
                                  }

                            }

                        },
              new Product
                        {
                      Id =5,
                    ShopId =1,
                    Name ="Kiwi",
                    Title ="organic",
                    Image ="Images/Product/kiwi.jpg",
                    IsTrending =1,
                      Price =60,
                    Description = "60 per kg",
                    ProductCategoryId=2,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =2,
                                        Name ="Fruits",
                                        Description ="Fruits",
                                        Image ="Images/ProductCategory/fresh-fruits-1.jpg",
                                        Title ="Fruits",
                                  }

                            }

                        },
            new Product
                        {
                      Id =6,
                    ShopId =1,
                    Name ="Paul Masson",
                    Title ="organic",
                    Image ="Images/Product/paul massion.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",
                    ProductCategoryId=3,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =3,
                                        Name ="Liquor",
                                        Description ="Liquor",
                                        Image ="Images/ProductCategory/liquor.jpg",
                                        Title ="Liquor",
                                  }

                            }

                        },
            new Product
                        {
                      Id =7,
                    ShopId =1,
                    Name ="Clos Malverne",
                    Title ="organic",
                    Image ="Images/Product/clos marvin.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",
                    ProductCategoryId=3,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                       Id =3,
                                        Name ="Liquor",
                                        Description ="Liquor",
                                        Image ="Images/ProductCategory/liquor.jpg",
                                        Title ="Liquor",
                                  }

                            }

                        },

              new Product
                        {
                      Id =8,
                    ShopId =1,
                    Name ="Jack Daniels",
                    Title ="organic",
                    Image ="Images/Product/jack daniels.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",  ProductCategoryId=3,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                    Id =3,
                                        Name ="Liquor",
                                        Description ="Liquor",
                                        Image ="Images/ProductCategory/liquor.jpg",
                                        Title ="Liquor",
                                  }

                            }

                        },
                 new Product
                        {
                      Id =9,
                    ShopId =1,
                    Name ="Black Labels",
                    Title ="organic",
                    Image ="Images/Product/black lebel.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",  ProductCategoryId=3,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                     Id =3,
                                        Name ="Liquor",
                                        Description ="Liquor",
                                        Image ="Images/ProductCategory/liquor.jpg",
                                        Title ="Liquor",
                                  }

                            }

                        },
             new Product
                        {
                      Id =11,
                    ShopId =1,
                    Name ="Breads- Multigrain",
                    Title ="organic",
                    Image ="Images/Product/multigrain bread.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",ProductCategoryId=4,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                      Id =4,
                                        Name ="Bakery",
                                        Description ="Bakery",
                                        Image ="Images/ProductCategory/bakery.jpg",
                                        Title ="Bakery",
                                  }

                            }

                        },
              new Product
                        {
                      Id =11,
                    ShopId =1,
                    Name ="Breads",
                    Title ="organic",
                    Image ="Images/Product/breads.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",ProductCategoryId=4,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                       Id =4,
                                        Name ="Bakery",
                                        Description ="Bakery",
                                        Image ="Images/ProductCategory/bakery.jpg",
                                        Title ="Bakery",
                                  }

                            }

                        },

              new Product
                        {
                      Id =12,
                    ShopId =1,
                    Name ="Cup cakes",
                    Title ="organic",
                    Image ="Images/Product/cupcake.jpg",
                    IsTrending =1,
                      Price =2660,
                    Description = "2660 per kg",ProductCategoryId=4,
                     ProductCategory =new List<ProductCategoryList>
                    {
                                  new  ProductCategoryList
                                  {
                                       Id =4,
                                        Name ="Bakery",
                                        Description ="Bakery",
                                        Image ="Images/ProductCategory/bakery.jpg",
                                        Title ="Bakery",
                                  }

                            }

                        },

        };

        private static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
          Id =4,
        ShopId =1,
        Name ="potato",
        Title ="organic",
        Image ="https://images.all-free-download.com/images/graphiclarge/potatoes_highdefinition_picture_4_167260.jpg",
        IsTrending =1,
          Price =120,
        Description = "120 per kg",
        ProductCategoryId=1,

            }
            ,
             new Product
            {
          Id =5,
        ShopId =1,
        Name ="Tomato",
        Title ="organic",
        Image ="https://study.com/cimages/multimages/16/adobestock_34617669.jpeg",
        IsTrending =1,
          Price =60,
        Description = "60 per kg",
         ProductCategoryId=1,

            },
                new Product
            {
          Id =6,
        ShopId =1,
        Name ="Mango",
        Title ="organic",
        Image ="https://images-na.ssl-images-amazon.com/images/I/71GpOmt0CVL._SL1500_.jpg",
        IsTrending =1,
          Price =60,
        Description = "60 per kg",
         ProductCategoryId=2,

            },

                  new Product
            {
          Id =7,
        ShopId =1,
        Name ="Strawberry",
        Title ="organic",
        Image ="https://qph.fs.quoracdn.net/main-qimg-e98d17a843754bcbdf34705ad72920cb",
        IsTrending =1,
          Price =60,
        Description = "60 per kg",
       ProductCategoryId=2,

            },

                     new Product
            {
          Id =8,
        ShopId =1,
        Name ="Paul Masson",
        Title ="organic",
        Image ="https://www.proof66.com/images/hires/201201180618494f16aa995dce3.jpg",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
        ProductCategoryId=3,

            },
                         new Product
            {
          Id =9,
        ShopId =1,
        Name ="Clos Malverne",
        Title ="organic",
        Image ="https://closmalverne.co.za/wp-content/uploads/2019/04/Clos-malverne-sauv-blanc.jpg",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
         ProductCategoryId=3,

            },

                                   new Product
            {
          Id =10,
        ShopId =1,
        Name ="Jack Daniels",
        Title ="organic",
        Image ="https://images.unsplash.com/photo-1527281400683-1aae777175f8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
        ProductCategoryId=3,

            },
 new Product
            {
          Id =11,
        ShopId =1,
        Name ="Breads- Multigrain",
        Title ="organic",
        Image ="https://www.gutkafoodexports.com/wp-content/uploads/2014/10/bakrrey-940x360.jpg",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
         ProductCategoryId=4,

            },
  new Product
            {
          Id =11,
        ShopId =1,
        Name ="Breads",
        Title ="organic",
        Image ="https://lh5.googleusercontent.com/proxy/kjoaEl1HmDXVvaIp8Czr7y5XH14erZHocQ5GU65-PLNUSOJRuG6O9qHI-vMkffEsdOqQ2T87njsSmfaqy3RM-15ojYTv8cCC8RkWmQvs-6BFi-loyvg8rHA",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
         ProductCategoryId=4,
        
            },

  new Product
            {
          Id =12,
        ShopId =1,
        Name ="Cup cakes",
        Title ="organic",
        Image ="https://www.kindpng.com/picc/m/187-1875321_buttercup-bake-shop-new-cake-bakery-items-png.png",
        IsTrending =1,
          Price =2660,
        Description = "2660 per kg",
        ProductCategoryId=4
            },

        };

        [HttpGet("[action]/{ProductCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Product>> Get(int ProductCategoryId)
        { 
            
           
            if (ProductCategoryId > 0)
            {
                return ProductItems.Where(x=>x.ProductCategoryId==ProductCategoryId).ToList();
            }
            else
            {
                return ProductItems.ToList() ;

           
            }
           
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> GetById(int Id)
        {
            var todoItem = ProductItems.FirstOrDefault(x => x.Id == Id); ;

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
        
        [HttpGet("GetByCategory/{ProductCategoryId}")] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Product>> GetByCategory(int ProductCategoryId)
        {
            var todoItem = Products.Where(x => x.ProductCategoryId == ProductCategoryId).ToList(); ;

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int IsTrending { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public List<ProductCategoryList> ProductCategory{ get; set; }
    }
    public class ProductCategoryList
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
}
