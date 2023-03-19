using System.Collections.Generic;
namespace Data1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url
        {
            get
            {
                return "products/" + this.Id;
            }
        }
    }

    public static class Products
    {
        private static List<Data1.Product> products = new List<Data1.Product>(){
      new Data1.Product(){ Id = 1, Name = "Test"  },
      new Data1.Product(){ Id = 2, Name = "Test2"  },
      new Data1.Product(){ Id = 3, Name = "Test3"  },
      new Data1.Product(){ Id = 4, Name = "Test4"  }
    };

        public static List<Product> GetProducts()
        {
            return products;
        }
    }
}   
