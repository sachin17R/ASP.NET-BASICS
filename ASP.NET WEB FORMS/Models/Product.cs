using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APPS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; } = 1;
    }

    public static class  ProductRepo
    {
       public  static List<Product> AllRecords = GetAllRec();

        private static List<Product> GetAllRec()
        {
            List<Product> Allrc = new List<Product>();
            Allrc.Add(new Product { ProductId = 15, ProductName = "cold coffee", ProductImage = @".\Images\ColdCoffee.jfif", Price = 250 });
            Allrc.Add(new Product { ProductId = 16, ProductName = "Iced_Coffee", ProductImage = @".\Images\Iced_Coffee.jpg", Price = 210 });
            Allrc.Add(new Product { ProductId = 17, ProductName = "Kulfi", ProductImage = @".\Images\Kulfi.jpg", Price = 210 });
            Allrc.Add(new Product { ProductId = 18, ProductName = "Lemon_Tea", ProductImage = @".\Images\Lemon_Tea.jpg", Price = 25 });
            Allrc.Add(new Product { ProductId = 1, ProductName = " Chair",ProductImage= @".\Images\images (2).jfif", Price = 2000 });
            Allrc.Add(new Product { ProductId = 2, ProductName = " Table",ProductImage= @".\Images\images.jfif", Price = 25000 });
            Allrc.Add(new Product { ProductId = 3, ProductName = "Dressing ",ProductImage= @".\Images\images.jfif", Price = 5000 });
            Allrc.Add(new Product { ProductId = 4, ProductName = " Soffa",ProductImage= @".\Images\sofa.jfif", Price = 3550});
            Allrc.Add(new Product { ProductId = 5, ProductName = "Bajji", ProductImage= @".\Images\Bajji.jpg", Price = 10 });
            Allrc.Add(new Product { ProductId = 6, ProductName = "Blue_Tea", ProductImage= @".\Images\Blue_Tea.jpg", Price = 310 });
            Allrc.Add(new Product { ProductId = 7, ProductName = "Bubble_Tea", ProductImage= @".\Images\Bubble_Tea.png", Price = 10 });
            Allrc.Add(new Product { ProductId = 8, ProductName = "Bhature", ProductImage= @".\Images\Chole_Bhature.jpg", Price = 310 });
            Allrc.Add(new Product { ProductId = 9, ProductName = "coffee",ProductImage= @".\Images\Coffee.jpg", Price = 210 });          
            Allrc.Add(new Product { ProductId = 10, ProductName = "Maggie", ProductImage= @".\Images\Maggie.jpg", Price = 250 });
            Allrc.Add(new Product { ProductId = 11, ProductName = "Maghreb", ProductImage= @".\Images\Maghreb.jfif", Price = 310 });
            Allrc.Add(new Product { ProductId = 12, ProductName = "Matcha_Tea", ProductImage= @".\Images\Matcha_Tea.jfif", Price = 25 });
            Allrc.Add(new Product { ProductId = 13, ProductName = "Pav_Bhaji", ProductImage= @".\Images\Pav_Bhaji.jpg", Price = 250 });
            Allrc.Add(new Product { ProductId = 14, ProductName = "Sandwich", ProductImage= @".\Images\Sandwich.jpg", Price = 210 });

            return Allrc;
        }
            public static void UpdateProduct(Product product)
            {
                var found = AllRecords.Find((p) => p.ProductId == product.ProductId);
                found.ProductName = product.ProductName;
                found.Price = product.Price;
            }

            public static void DeleteProduct(int id)
            {
                var found = AllRecords.Find((p) => p.ProductId == id);
                AllRecords.Remove(found);
            }

            internal static void AddNewProduct(Product product) => AllRecords.Add(product);

    }
}