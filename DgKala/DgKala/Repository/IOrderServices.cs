using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using DgKala.Models.Context;
using DgKala.Models.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace DgKala.Repository
{
    public interface IOrderServices
    {
        int AddOrder(string userName,int categoryId);
        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string userName,int orderId);

    }








    public class OrderServices : IOrderServices
    {
        private DgkalaContext _context;

        private IUserServices _userServices;

        public OrderServices(DgkalaContext context,IUserServices userServices)
        {
            _context = context;
            _userServices = userServices;
        }
        public int AddOrder(string userName, int categoryId) 
        {
            int userId = _userServices.GetUserIdByUsername(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var course = _context.Categories.Find(categoryId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = course.CategoryPrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            CategoryId = categoryId,
                            Count = 1,
                            Price = course.CategoryId
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.CategoryId == categoryId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        CategoryId = categoryId,
                        Price = course.CategoryPrice,
                    };
                    _context.OrderDetails.Add(detail);
                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }


            return order.OrderId;

        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
        public Order GetOrderForUserPanel(string userName,int orderId)
        {
            int userId = _userServices.GetUserIdByUsername(userName); 

            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Category)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }
    }
}

