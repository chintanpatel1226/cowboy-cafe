/// <summary>
/// Author:  Chintan Patel
/// Class: CIS 400
/// Purpose: A static class representing menu options.
/// References: Nathan Bean
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Static class representing menu options.
    /// </summary>
    public static class Menu
    {
        public static IEnumerable<IOrderItem> All => CompleteMenu(); 

        /// <summary>
        /// Static class returning a list of all avaiable entrees.
        /// </summary>
        /// <returns>A list of all available entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());
            return menu;
        }

        /// <summary>
        /// Static class returning a list of all avaiable sides.
        /// </summary>
        /// <returns>A list of all available sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans side = new BakedBeans();
                side.Size = size;
                menu.Add(side);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                ChiliCheeseFries side = new ChiliCheeseFries();
                side.Size = size;
                menu.Add(side);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CornDodgers side = new CornDodgers();
                side.Size = size;
                menu.Add(side);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                PanDeCampo side = new PanDeCampo();
                side.Size = size;
                menu.Add(side);
            }
            return menu;
        }

        /// <summary>
        /// Static class returning a list of all avaiable sides.
        /// </summary>
        /// <returns>A list of all available sides.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee drink = new CowboyCoffee();
                drink.Size = size;
                menu.Add(drink);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                JerkedSoda drink = new JerkedSoda();
                drink.Size = size;
                menu.Add(drink);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                TexasTea drink = new TexasTea();
                drink.Size = size;
                menu.Add(drink);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Water drink = new Water();
                drink.Size = size;
                menu.Add(drink);
            }
            return menu;
        }

        /// <summary>
        /// Static class returning a list of the complete menu.
        /// </summary>
        /// <returns>A list of the complete menu.</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            foreach(IOrderItem item in Menu.Entrees())
            {
                menu.Add(item);
            }
            foreach (IOrderItem item in Menu.Sides())
            {
                menu.Add(item);
            }
            foreach (IOrderItem item in Menu.Drinks())
            {
                menu.Add(item);
            }
            return menu;
        }

        /// <summary>
        /// The term to search for in the menu.
        /// </summary>
        /// <param name="terms">The menu option being searched for.</param>
        /// <returns>A list of IOrderItems based on the search term.</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return All;
            foreach(IOrderItem item in CompleteMenu())
            {
                if(item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the available options.
        /// </summary>
        public static string[] Options => new string[] { "Entree", "Side", "Drink" };

        /// <summary>
        /// Filters the provided menu options based on the options selected.
        /// </summary>
        /// <param name="items">The menu options filitered.</param>
        /// <param name="options">The options to include.</param>
        /// <returns>A collection containing onnly the options provided.</returns>
        public static IEnumerable<IOrderItem> FilterByOptions(IEnumerable<IOrderItem> items, IEnumerable<String> option)
        {
            if (option == null || option.Count() == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (String opt in option)
            {
                if(opt.Equals("Entree"))
                {
                    foreach (IOrderItem item in Menu.Entrees())
                    {
                        result.Add(item);
                    }
                }
                else if(opt.Equals("Side"))
                {
                    foreach (IOrderItem item in Menu.Sides())
                    {
                        result.Add(item);
                    }
                }
                else if(opt.Equals("Drink"))
                {
                    foreach (IOrderItem item in Menu.Drinks())
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Filters the provided collection of menu options to those of the ranges provided.
        /// </summary>
        /// <param name="items">The menu options filtered.</param>
        /// <param name="min">The minimum price range.</param>
        /// <param name="max">The maximum price range.</param>
        /// <returns>The filtered menu option.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a minimum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            // only a maximum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu options to those of the ranges provided.
        /// </summary>
        /// <param name="items">The menu options filtered.</param>
        /// <param name="min">The minimum calories range.</param>
        /// <param name="max">The maximum calories range.</param>
        /// <returns>The filtered menu option.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a minimum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            // only a maximum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
