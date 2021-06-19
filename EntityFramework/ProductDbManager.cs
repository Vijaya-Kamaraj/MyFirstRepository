using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EntityFramework
{
    public class ProductDbManager
    {
        public ProductDbEntities db = new ProductDbEntities();
        
        // Create
        public string AddProduct(Product obj)
        {
            db.Products.Add(obj);
            db.SaveChanges();
            return "New Product details are added to database";
        }

        // Read All
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        //Read Single Data
        public Product GetProduct(int id)
        {
            //return db.Products.Find(ProductId);
            Product product = db.Products.Where(x => x.ProductId == id).Single();
            return product;
        }

        //Update
        public string UpdateProduct(Product obj1)
        {
            db.Entry(obj1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Product details are updated to database";
        }

        //Delete
        public string DeleteProduct(int id)
        {
            Product obj = db.Products.Find(id);
            db.Products.Remove(obj);
            db.SaveChanges();
            return "Product details are deleted from database";
        }
    }
}
