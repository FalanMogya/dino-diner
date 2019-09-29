using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveIceSetToFalse()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveLemonSetToTrue()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water w = new Water();
            List<string> ingredients = w.Ingredients;
            Assert.Contains<string>("Water", ingredients);
        }

        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Lemon", w.Ingredients);
        }
    }
}
