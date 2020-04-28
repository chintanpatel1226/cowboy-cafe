using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CowboyCafe.Data;
using Xunit;

namespace MenuTests
{
    public class MenuTests
    {
        /// <summary>
        /// The menu should return all of the items.
        /// </summary>
        [Fact]
        public void ShouldReturnAllItems()
        {
            var item = Menu.All;
            var results = Menu.CompleteMenu();
            Assert.Equal(item.Count(), results.Count());
        }

        /// <summary>
        /// The menu should return all different types of items.
        /// </summary>
        /// <param name="type">The different options of items.</param>
        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void ShouldReturnAllType(string type)
        {
            var list = new List<IOrderItem>();
            switch (type)
            {
                case "Entree":
                    list = (List<IOrderItem>)Menu.Entrees();
                    break;
                case "Side":
                    list = (List<IOrderItem>)Menu.Sides();
                    break;
                case "Drink":
                    list = (List<IOrderItem>)Menu.Drinks();
                    break;
            }
            foreach(IOrderItem item in list)
            {
                if (type.Equals("Entree"))
                {
                    if(!(item is Entree))
                    {
                        Assert.False(false);
                    }
                }
                else if (type.Equals("Side"))
                {
                    if (!(item is Side))
                    {
                        Assert.False(false);
                    }
                }
                else if (type.Equals("Drink"))
                {
                    if (!(item is Drink))
                    {
                        Assert.False(false);
                    }
                }
            }
            Assert.True(true);
        }

        /// <summary>
        /// Adding entrees should return only entrees.
        /// </summary>
        /// <param name="type">An entree.</param>
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        public void EntreesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        /// <summary>
        /// Adding sides should return only sides.
        /// </summary>
        /// <param name="type">A side.</param>
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        /// <summary>
        /// Adding drinks should return only drinks.
        /// </summary>
        /// <param name="type">A drink.</param>
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        /// <summary>
        /// There should only be 7 total entrees.
        /// </summary>
        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        /// <summary>
        /// There should only be 12 total sides based on the sizes.
        /// </summary>
        [Fact]
        public void SidesShouldHaveOnlyTwelveItemsIncludingSize()
        {
            Assert.Equal(12, Menu.Sides().Count());
        }

        /// <summary>
        /// There should only be 12 total drinks based on the sizes.
        /// </summary>
        [Fact]
        public void DrinksShouldHaveOnlyTwelveItemsIncludingSize()
        {
            Assert.Equal(12, Menu.Drinks().Count());
        }

        /// <summary>
        /// Menu should return only entrees added.
        /// </summary>
        [Fact]
        public void MenuEntreesShouldContainExpectedStuff()
        {
            Assert.Collection(
                Menu.Entrees(),
                (angryChicken) => { Assert.IsType<AngryChicken>(angryChicken); },
                (cowpokeChili) => { Assert.IsType<CowpokeChili>(cowpokeChili); },
                (dakotaDoubleBurger) => { Assert.IsType<DakotaDoubleBurger>(dakotaDoubleBurger); },
                (pecosPulledPork) => { Assert.IsType<PecosPulledPork>(pecosPulledPork); },
                (rustlersRibs) => { Assert.IsType<RustlersRibs>(rustlersRibs); },
                (texasTripleBurger) => { Assert.IsType<TexasTripleBurger>(texasTripleBurger); },
                (trailBurger) => { Assert.IsType<TrailBurger>(trailBurger); }
                );
        }

        /// <summary>
        /// Menu should return only sides added.
        /// </summary>
        [Fact]
        public void MenuSidesShouldContainExpectedStuff()
        {
            Assert.Collection(
                Menu.Sides(),
                (smallItem) => { Assert.IsType<BakedBeans>(smallItem); },
                (mediumItem) => { Assert.IsType<BakedBeans>(mediumItem); },
                (largeItem) => { Assert.IsType<BakedBeans>(largeItem); },

                (smallItem) => { Assert.IsType<ChiliCheeseFries>(smallItem); },
                (mediumItem) => { Assert.IsType<ChiliCheeseFries>(mediumItem); },
                (largeItem) => { Assert.IsType<ChiliCheeseFries>(largeItem); },

                (smallItem) => { Assert.IsType<CornDodgers>(smallItem); },
                (mediumItem) => { Assert.IsType<CornDodgers>(mediumItem); },
                (largeItem) => { Assert.IsType<CornDodgers>(largeItem); },

                (smallItem) => { Assert.IsType<PanDeCampo>(smallItem); },
                (mediumItem) => { Assert.IsType<PanDeCampo>(mediumItem); },
                (largeItem) => { Assert.IsType<PanDeCampo>(largeItem); }
                );
        }

        /// <summary>
        /// Menu should return only drinks added.
        /// </summary>
        [Fact]
        public void MenuDrinksShouldContainExpectedStuff()
        {
            Assert.Collection(
                Menu.Drinks(),
                (smallItem) => { Assert.IsType<CowboyCoffee>(smallItem); },
                (mediumItem) => { Assert.IsType<CowboyCoffee>(mediumItem); },
                (largeItem) => { Assert.IsType<CowboyCoffee>(largeItem); },

                (smallItem) => { Assert.IsType<JerkedSoda>(smallItem); },
                (mediumItem) => { Assert.IsType<JerkedSoda>(mediumItem); },
                (largeItem) => { Assert.IsType<JerkedSoda>(largeItem); },

                (smallItem) => { Assert.IsType<TexasTea>(smallItem); },
                (mediumItem) => { Assert.IsType<TexasTea>(mediumItem); },
                (largeItem) => { Assert.IsType<TexasTea>(largeItem); },

                (smallItem) => { Assert.IsType<Water>(smallItem); },
                (mediumItem) => { Assert.IsType<Water>(mediumItem); },
                (largeItem) => { Assert.IsType<Water>(largeItem); }
                );
        }

        /// <summary>
        /// Filtering a term should return the expected number of items.
        /// </summary>
        /// <param name="term">The term to search.</param>
        /// <param name="expected">The number of items expected.</param>
        [Theory]
        [InlineData(" ", 31)]
        [InlineData(null, 31)]
        [InlineData("Cowboy", 3)]
        [InlineData("B", 10)]
        public void ShouldFilterBySearch(string term, int expected)
        {
            Assert.Equal(expected, Menu.Search(term).Count());
        }
        
        /// <summary>
        /// Filtering by the options should return the expected number of items.
        /// </summary>
        /// <param name="options">The selected options.</param>
        /// <param name="expected">The number of items expected.</param>
        [Theory]
        [InlineData(null, 31)]
        [InlineData(new string[] { "Entree" }, 7)]
        [InlineData(new string[] { "Entree", "Drink" }, 19)]
        [InlineData(new string[] { "Side","Drink" }, 24)]
        public void ShouldFilterByOptions(string[] options, int expected)
        {
            var item = Menu.All;
            var results = Menu.FilterByOptions(Menu.All, options);

            if(results is List<IOrderItem> val)
            {
                Assert.Equal(expected, val.Count);
            }
        }

        /// <summary>
        /// Filtering by the number of calories should return the expected number of calories.
        /// </summary>
        /// <param name="min">The minimum number of calories.</param>
        /// <param name="max">The maximum number of calories.</param>
        /// <param name="expected">The total calories expected.</param>
        [Theory]
        [InlineData(0, 20, 7)]
        [InlineData(200, 400, 6)]
        [InlineData(0, 1000, 31)]
        public void ShouldFilterByCalories(int? min, int? max, int expected)
        {
            Assert.Equal(expected, Menu.FilterByCalories(Menu.All, min, max).Count());
        }

        /// <summary>
        /// Filtering by the number of price should return the expected price.
        /// </summary>
        /// <param name="min">The minimum number of price.</param>
        /// <param name="max">The maximum number of price.</param>
        /// <param name="expected">The total price expected.</param>
        [Theory]
        [InlineData(0 ,3, 23)]
        [InlineData(5, 10, 6)]
        [InlineData(0, 100, 31)]
        public void ShouldFilterByPrice(double? min, double? max, double expected)
        {
            Assert.Equal(expected, Menu.FilterByPrice(Menu.All, min, max).Count());
        }
    }
}
