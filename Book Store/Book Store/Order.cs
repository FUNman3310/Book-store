using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    public class Order
    {
        List<Book> Basket;
        public int Id { get; set; } 
        public double TotalPrice { get; set; }  
        public string Date { get; set; }
        
        public void AddToBasket(List<Book> books)
        {
            Basket = books;
        }

        public void SellBooks()
        {
            foreach (Book book in Basket)
            {
                TotalPrice += book.Price;
            }
            TotalPrice = Discount(TotalPrice);
            Console.WriteLine(TotalPrice);
            Basket.Clear();
        }

        private double Discount(double totalPrice)
        {
            if (totalPrice<100)
            {
                return totalPrice;
            }
            else if (totalPrice>=100||totalPrice<=200)
            {
                return totalPrice -= totalPrice / 10;
            }
            else
            {
                return totalPrice-=totalPrice / 20;
            }
        }
    }
}
