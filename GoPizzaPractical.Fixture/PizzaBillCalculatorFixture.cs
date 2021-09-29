using System;
using System.Collections.Generic;
using Xunit;

namespace GoPizzaPractical.Fixture
{
    public class PizzaBillCalculatorFixture
    {
        [Fact]
        public void ShouldReturnPriceForPizza()
        {
            var pizza = new Pizza()
            {
                Name = "Chicken Supreme",
                Price = 200
            };

            var menu = new Menu()
            {
                Pizzas = new List<Pizza>() { pizza }
            };

            var calculator = new PizzaBillCalculator(menu);
            var result = calculator.CalculateTotalCost(pizza.Name);

            Assert.Equal(pizza.Price, result);
        }

        [Fact]
        public void ShouldThrowExceptionIfPizzaDoNotExistInMenu()
        {
            var menu = new Menu()
            {
                Pizzas = new List<Pizza>()
            };

            var calculator = new PizzaBillCalculator(menu);
            var exception = Assert.Throws<Exception>(() => calculator.CalculateTotalCost("NonExistingPizza"));
            Assert.Equal("Pizza do not exists", exception.Message);
        }
    }
}
