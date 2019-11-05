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
        public void AddingItemShouldBeCorrectSubtotalCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            Assert.Equal<double>(5.15, order.SubtotalCost);
        }

        [Fact]
        public void AddingMultipleItemsShouldBeCorrectSubtotalCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            order.Add(new TRexKingBurger());
            Assert.Equal<double>(13.60, order.SubtotalCost);
        }

        [Fact]
        public void AddingItemShouldBeCorrectSalesTaxCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            Assert.Equal(0.05, order.SalesTaxCost, 2);
        }

        [Fact]
        public void AddingMultipleItemsShouldBeCorrectSalesTaxCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            order.Add(new TRexKingBurger());
            Assert.Equal(0.14, order.SalesTaxCost, 2);
        }

        [Fact]
        public void AddingItemShouldBeCorrectTotalCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            Assert.Equal(5.20, order.TotalCost, 2);
        }

        [Fact]
        public void AddingMultipleItemsShouldBeCorrectTotalCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            order.Add(new TRexKingBurger());
            Assert.Equal(13.74, order.TotalCost, 2);
        }

        [Fact]
        public void SubtotalCostShouldNotNegative()
        {
            Order order = new Order();
            SteakosaurusBurger item = new SteakosaurusBurger();
            item.Price = -10.00;
            order.Add(item);
            Assert.Equal<double>(0, order.SubtotalCost);
        }
    }
}
