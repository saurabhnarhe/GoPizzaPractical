using System;
namespace GoPizzaPractical
{
    public class PizzaBillCalculator
    {
        private Menu _menu;

        public PizzaBillCalculator(Menu menu)
        {
            _menu = menu;
        }

        public decimal CalculateTotalCost(string order)
        {
            var pizza = _menu.Pizzas.Find(pizza => pizza.Name.Equals(order));

            if (pizza != null) return pizza.Price;
            else throw new Exception("Pizza do not exists");
        }
    }
}
