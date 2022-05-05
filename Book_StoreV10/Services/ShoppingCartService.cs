using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Services
{
    public class ShoppingCartService
    {
        List<Book> orderItems;

        public ShoppingCartService()
        {
            orderItems = new List<Book>();
        }

        public void AddBook(Book book)
        {
            orderItems.Add(book);
         }

        public void DeleteBook(Book book)
        {
            orderItems.Remove(book);
        }

        public double CalcTotalPrice()
        {
            double result = 0.0;

            foreach (Book item in orderItems)
            {
                result += item.Price;
                //result= result+ item.price;
            }

            return result;
        }

        public List<Book> GetOrderItems()

        {
            return orderItems;
        }
    }
}