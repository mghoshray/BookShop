using System.Collections.Generic;
using System.Linq;

namespace BookShopApp
{
    public class Basket
    {
        public Basket()
        {
            BasketItems = new List<Book>();
        }

        public List<Book> BasketItems { get; set; }

        public int HarryPotterBookCount()
        {
            var count = 0;
            BasketItems
                .GroupBy(g => g.Name)
                .Select(group => group.First())
                .ToList()
                .ForEach(b =>
                   {
                       if (b is HarryPotterBook)
                       {
                           count++;
                       }
                   });
            return count;
        }

        public decimal Discount
        {
            get
            {
                switch (HarryPotterBookCount())
                {
                    case 2:
                        return 5;
                    case 3:
                        return 10;
                    case 4:
                        return 20;
                    case 7:
                        return 25;
                    default:
                        return 0;
                }
            }
        }

        public void AddItems(Book book)
        {
            BasketItems.Add(book);
        }

        public decimal TotalPrice()
        {
            var PriceBeforeDiscount = BasketItems.Select(i => i.UnitPrice).First() * BasketItems.Count();
            var DiscountedPrice = PriceBeforeDiscount;

            if (HarryPotterBookCount() > 0)
            {
                return DiscountedPrice = 
                    ((BasketItems.Count() - HarryPotterBookCount()) 
                    * BasketItems.Select(i => i.UnitPrice).First()) 
                        + ((BasketItems.Select(i => i.UnitPrice).First()
                            * HarryPotterBookCount()) - ((BasketItems.Select(i => i.UnitPrice).First() 
                            * HarryPotterBookCount()) 
                            * (Discount / 100)));
            }

            return DiscountedPrice;
        }
    }
}
