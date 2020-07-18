using MyPetShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace MyPetShop.BLL
{
    public class OrderService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();
        public List<Order> GetAllOrders()
        {
            return db.Order.ToList();
        }
        public List<Order> GetOrderByCustomerId(int customerId)
        {
            return db.Order.Where(o => o.CustomerId == customerId).OrderByDescending(o => o.CustomerId).ToList();
        }
        public Order GetOrderByOrderId(int orderId)
        {
            return (from o in db.Order
                    where o.OrderId == orderId
                    select o).First();
        }
        public List<Order> GetOrderListByOrderId(int orderId)
        {
            return (from o in db.Order
                    where o.OrderId == orderId
                    select o).ToList();
        }
        public List<OrderItem> GetOrderItemByOrderId(int orderId)
        {
            return (from o in db.OrderItem
                    where o.OrderId == orderId
                    select o).ToList();
        }
        public void CreateOrderFromCart(int customertId,string customerName,string addr1,string addr2,string city,string state,string zip,string phone)
        {
            using(TransactionScope ts=new TransactionScope())
            {
                List<CartItem> cartItemList = (from c in db.CartItem
                                               where c.CustomerId == customertId
                                               select c).ToList();
                Order order = new Order();
                order.CustomerId = customertId;
                order.UserName = customerName;
                order.OrderDate = DateTime.Now;
                order.Addr1 = addr1;
                order.Addr2 = addr2;
                order.City = city;
                order.State = state;
                order.Zip = zip;
                order.Phone = phone;
                order.Status = "未审核";
                OrderItem orderItem = null;
                Product product = null;
                foreach(CartItem cartItem in cartItemList)
                {
                    orderItem = new OrderItem();
                    orderItem.OrderId = order.OrderId;
                    orderItem.ProName = cartItem.ProName;
                    orderItem.ListPrice = cartItem.ListPrice;
                    orderItem.Qty = cartItem.Qty;
                    orderItem.TotalPrice = cartItem.Qty * cartItem.ListPrice;
                    order.OrderItem.Add(orderItem);
                    product = (from p in db.Product
                               where p.ProductId == cartItem.ProId
                               select p).First();
                    product.Qty = product.Qty - cartItem.Qty;
                    db.CartItem.DeleteOnSubmit(cartItem);
                }
                db.Order.InsertOnSubmit(order);
                db.SubmitChanges();
                ts.Complete();
            }
        }
        public void UpdateOrder(int orderId)
        {
            Order order = (from o in db.Order
                           where o.OrderId == orderId
                           select o).First();
            order.Status = "已审核";
            db.SubmitChanges();
        }
    }
}
