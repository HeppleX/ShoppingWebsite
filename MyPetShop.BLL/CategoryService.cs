using MyPetShop.DAL;
using System.Collections.Generic;
using System.Linq;

namespace MyPetShop.BLL
{
    public class CategoryService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();
        public Category GetCategoryById(int categoryId)
        {
            return (from c in db.Category
                    where c.CategoryId == categoryId
                    select c).First();
        }
        public void InsertCategory(int categoryId,string name,string descn)
        {
            Category category = new Category();
            category.CategoryId = categoryId;
            category.Name = name;
            category.Descn = descn;
            db.Category.InsertOnSubmit(category);
            db.SubmitChanges();
        }
        public void UpdateCategory(int categoryId, string name, string descn)
        {
            Category category = (from c in db.Category
                                 where c.CategoryId == categoryId
                                 select c).First();
            category.Name = name;
            category.Descn = descn;
            db.SubmitChanges();
        }
        public void DeleteCategory(int categoryId)
        {
            Category category = (from c in db.Category
                                 where c.CategoryId == categoryId
                                 select c).First();
            db.Category.DeleteOnSubmit(category);
            db.SubmitChanges();
        }
        public List<Category> GetAllCategories()
        {
            return (from c in db.Category
                    select c).ToList();
        }
        public int GetProductCountByCategoryId(int categoryId)
        {
            return (from p in db.Product
                    where p.CategoryId == categoryId
                    select p).Count();
        }
    }
}
