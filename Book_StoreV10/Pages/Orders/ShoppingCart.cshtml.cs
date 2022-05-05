using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_StoreV10.Interfaces;
using Book_StoreV10.Models;
using Book_StoreV10.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_StoreV10.Pages.Orders
{
    public class ShoppingCartModel : PageModel
    {
        IBooksRepository bookRepos;
        ShoppingCartService ShoppingCart;
        public List<Book> orderItems { get; private set; }
        public double TotalPrice { get; private set; }

        public ShoppingCartModel(IBooksRepository BooksRepository, ShoppingCartService cart)
        {
            bookRepos = BooksRepository;
            ShoppingCart = cart;
        }

        public void OnGet(string isbn)
        {
            Book b = bookRepos.GetBook(isbn);
            ShoppingCart.AddBook(b);
            orderItems = ShoppingCart.GetOrderItems();
            TotalPrice = ShoppingCart.CalcTotalPrice();
        }
        
    }
}
