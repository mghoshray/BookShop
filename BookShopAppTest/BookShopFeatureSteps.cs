using TechTalk.SpecFlow;
using BookShopApp;
using Shouldly;

namespace BookShopAppTest
{
    [Binding]
    public sealed class BookShopFeatureSteps
    {
        Basket basket = new Basket();
        decimal price = 0;
        [Given(@"I have entered (.*) copy of a Harry Potter book and (.*) into the shopping basket")]
        public void GivenIHaveEnteredCopyOfAHarryPotterBookIntoTheShoppingBasket(int harrypottercopies, int othercopies)
        {
            switch (harrypottercopies +""+ othercopies)
            {
                case "10":
                    var book = new HarryPotterBook("Harry Potter and Philosopher's Stone");
                    basket.AddItems(book);
                    break;
                case "20":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    break;
                case "30":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Prizoner of Azkaban"));
                    break;
                case "40":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Prizoner of Azkaban"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Goblet of Fire"));
                    break;
                case "70":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Prizoner of Azkaban"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Order of the Phoenix"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Goblet of Fire"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Half-Blood Prince"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Deathly Hollows"));
                    break;
                case "21":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new Book("Not a Harry POtter Book"));
                    break;
                case "140":
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Prizoner of Azkaban"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Order of the Phoenix"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Goblet of Fire"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Half-Blood Prince"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Deathly Hollows"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and Philosopher's Stone"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Chamber of Secrets"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Prizoner of Azkaban"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Order of the Phoenix"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Goblet of Fire"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Half-Blood Prince"));
                    basket.AddItems(new HarryPotterBook("Harry Potter and the Deathly Hollows"));
                    break;
                case "03":
                    basket.AddItems(new Book("Other Book 1"));
                    basket.AddItems(new Book("Other Book 2"));
                    basket.AddItems(new Book("Other Book 3"));
                    break;
                default:
                    break;
            }
        }

        [When(@"I check the shoping basket for (.*)")]
        public void WhenICheckTheShopingBasket(decimal discount)
        {
            price = basket.TotalPrice();
        }

        [Then(@"the total price of the basket would be (.*) pounds")]
        public void ThenTheTotalPriceOfTheBasketWouldBePounds(decimal totalPrice)
        {
            price.ShouldBe(totalPrice);
        }
    }


}
