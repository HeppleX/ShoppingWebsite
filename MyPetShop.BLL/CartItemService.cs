using MyPetShop.DAL;
using System.Collections.Generic;
using System.Linq;

namespace MyPetShop.BLL
{
    public class CartItemService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();
        
        public CartItem Add(int customerId,int productId,int qty)
        {
            CartItem cartItem = null;
            Product product = (from p in db.Product
                               where p.ProductId == productId
                               select p).First();
            cartItem = new CartItem();
            cartItem.CustomerId = customerId;
            cartItem.ProId = product.ProductId;
            cartItem.ProName = product.Name;
            cartItem.ListPrice = product.ListPrice.Value;
            cartItem.Qty = qty;
            int ExistCartItemCount = (from c in db.CartItem
                                      where c.CustomerId == customerId && c.ProId == productId
                                      select c).Count();
            if(ExistCartItemCount>0)
            {
                CartItem existCartItem = (from c in db.CartItem
                                          where c.CustomerId == customerId && c.ProId == productId
                                          select c).First();
                existCartItem.Qty += qty;
            }
            else
            {
                db.CartItem.InsertOnSubmit(cartItem);
            }
            db.SubmitChanges();
            return cartItem;
        }
        public CartItem Update(int customerId, int productId, int qty)
        {
            CartItem cartItem = null;
            cartItem =(from c in db.CartItem
                         where c.CustomerId == customerId && c.ProId == productId
                         select c).First();
            if(cartItem!=null)
            {
                cartItem.Qty = qty;
                if(cartItem.Qty<=0)
                {
                    db.CartItem.DeleteOnSubmit(cartItem);
                }
                db.SubmitChanges();
            }
            return cartItem;
        }
        public void Delete(int customerId, int productId)
        {
            CartItem cartItem = (from c in db.CartItem
                        where c.CustomerId == customerId && c.ProId == productId
                        select c).First();
            if (cartItem != null)
            {
                db.CartItem.DeleteOnSubmit(cartItem);
                db.SubmitChanges();
            }
        }
        public void Clear(int customerId)
        {
            List<CartItem> cartItemList= (from c in db.CartItem
                                          where c.CustomerId == customerId
                                          select c).ToList();
            foreach(CartItem cartItem in cartItemList)
            {
                db.CartItem.DeleteOnSubmit(cartItem);
            }
            db.SubmitChanges();
        }
        public List<CartItem> GetCartItemsByCustomerId(int customerId)
        {
            return (from c in db.CartItem
                    where c.CustomerId == customerId
                    select c).ToList();
        }
        public decimal GetTotalPriceByCustomerId(int customerId)
        {
            List<CartItem> list= (from c in db.CartItem
                                  where c.CustomerId == customerId
                                  select c).ToList();
            return list.Sum(c => c.ListPrice * c.Qty);
        }
    }
}
