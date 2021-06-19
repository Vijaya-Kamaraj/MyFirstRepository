using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductDbManager dbManager = new ProductDbManager();
            Product obj = new Product();

            //Create 
   
            obj.ProductName = "Iphone";
 
            obj.ProductPrice = 115000;
 
            obj.ProductQuantity = 30;
 
            string status = dbManager.AddProduct(obj);
 
            Console.WriteLine(status);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Get All Product Data");

            List<Product> productList = dbManager.GetProducts();
   
            foreach(Product item in productList)
 
            {
    
                Console.WriteLine("{0} - {1} - {2}", item.ProductName, item.ProductPrice, item.ProductQuantity);
 
            }

            Console.WriteLine("---------------------------------------------------");
            
            Console.WriteLine("Get Single Product Data");
            Product getSingleProduct = dbManager.GetProduct(1);
            Console.WriteLine("{0} - {1} - {2}", getSingleProduct.ProductName, getSingleProduct.ProductPrice,getSingleProduct.ProductQuantity);


            Console.WriteLine("---------------------------------------------------");
            getSingleProduct.ProductName = "Camera";
            getSingleProduct.ProductPrice = 50000;
            getSingleProduct.ProductQuantity = 30;
            status=dbManager.UpdateProduct(getSingleProduct);

            Console.WriteLine(status);

            Console.WriteLine("---------------------------------------------------");
            status = dbManager.DeleteProduct(5);
            Console.WriteLine(status);
            Console.ReadLine();
}
}
}
