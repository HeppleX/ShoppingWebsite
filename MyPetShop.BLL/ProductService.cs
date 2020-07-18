using MyPetShop.DAL;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;

namespace MyPetShop.BLL
{
    public class ProductService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();
        public void Add(string imageFile,string name,int categoryId,int supplierId,decimal listPrice,decimal unitCost,string descn, int qty)
        {
            Product product = new Product();
            product.Image = imageFile;
            product.Name = name;
            product.CategoryId = categoryId;
            product.SuppId = supplierId;
            product.ListPrice = listPrice;
            product.UnitCost = unitCost;
            product.Descn = descn;
            product.Qty = qty;
            db.Product.InsertOnSubmit(product);
            db.SubmitChanges();
        }
        public void Update(int productId,string name, int categoryId, int suppId, decimal listPrice, decimal unitCost, string descn, int qty)
        {
            Product product = (from p in db.Product
                               where p.ProductId == productId
                               select p).First();
            product.Name = name;
            product.CategoryId = categoryId;
            product.SuppId = suppId;
            product.ListPrice = listPrice;
            product.UnitCost = unitCost;
            product.Descn = descn;
            product.Qty = qty;
            db.SubmitChanges();
        }
        public List<Product> GetAllProducts()
        {
            return (from p in db.Product
                    select p).ToList();
        }
        public Product GetProductByProductId(int productId)
        {
            return (from p in db.Product
                    where p.ProductId == productId
                    select p).First();
        }
        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return (from p in db.Product
                    where p.CategoryId == categoryId
                    select p).ToList();
        }
        public List<Product> GetNewProduct(int count)
        {
            return(from p in db.Product
                  orderby p.ProductId descending
                  select p).Take(count).ToList();
        }
        public List<Product> GetProductByProductIdorByCategoryId(string productId,string categoryId)
        {
            if(!string.IsNullOrEmpty(productId))
            {
                return (from p in db.Product
                        where p.ProductId==int.Parse(productId)
                        select p).ToList();
            }
            else
            {
                return (from p in db.Product
                        where p.CategoryId == int.Parse(categoryId)
                        select p).ToList();
            }
        }
        public List<Product> GetProductBySearchText(string searchText)
        {
            return (from p in db.Product
                    where SqlMethods.Like(p.Name,"%"+searchText+"%")
                    select p).ToList();
        }
        public int GetProductCountByCategoryId(int categoryId)
        {
            return (from p in db.Product
                    where p.CategoryId == categoryId
                    select p).Count();
        }
        public int GetProductCountBySupplierId(int supplierId)
        {
            return (from p in db.Product
                    where p.SuppId == supplierId
                    select p).Count();
        }
        public bool IsExistCS()
        {
            var categories = from c in db.Category
                             select c;
            var suppliers = from c in db.Supplier
                             select c;
            if(categories.Count()==0||suppliers.Count()==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsExistProduct(string name)
        {           
            var products = from c in db.Product
                           where c.Name==name
                           select c;
            if (products.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeletePro(int productId)
        {
            var product = (from p in db.Product
                           where p.ProductId == productId
                           select p).First();
            db.Product.DeleteOnSubmit(product);
            db.SubmitChanges();
        }
    }
}
