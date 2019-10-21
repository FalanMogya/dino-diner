using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {

        [Fact]
        public void AddingItemShouldChangeTheSubtotalCost()
        {
            Order order = new Order();
            order.Items.Add(new SteakosaurusBurger());
            Assert.Equal<double>(5.15, order.SubtotalCost);
        }

        [Fact]
        public void AddingMultipleItemsShouldBeCorrectSubtotalCost()
        {
            Order order = new Order();
            order.Items.Add(new SteakosaurusBurger());
            order.Items.Add(new TRexKingBurger());
            Assert.Equal<double>(13.60, order.SubtotalCost);
        }

        [Fact]
        public void SubtotalCostShouldNotNegative()
        {
            Order order = new Order();
            SteakosaurusBurger item = new SteakosaurusBurger();
            item.Price = -10.00;
            order.Items.Add(item);
            Assert.Equal<double>(10.00, order.SubtotalCost);
        }
    }
}
