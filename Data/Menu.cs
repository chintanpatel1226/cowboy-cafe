/// <summary>
/// Author:  Chintan Patel
/// Class: CIS 400
/// Purpose: A static class representing menu options.
/// </summary>
using System;
using System.Collections.Generic;
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
            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());
            return menu;
        }

        /// <summary>
        /// Static class returning a list of all avaiable sides.
        /// </summary>
        /// <returns>A list of all available sides.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new CowboyCoffee());
            menu.Add(new JerkedSoda());
            menu.Add(new TexasTea());
            menu.Add(new Water());
            return menu;
        }

        /// <summary>
        /// Static class returning a list of the complete menu.
        /// </summary>
        /// <returns>A list of the complete menu.</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());

            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());

            menu.Add(new CowboyCoffee());
            menu.Add(new JerkedSoda());
            menu.Add(new TexasTea());
            menu.Add(new Water());
            return menu;
        }

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

        public static IEnumerable<IOrderItem> FilterByOptions(IEnumerable<IOrderItem> items, string[] options)
        {
            if (options == null || options.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (string option in options)
            {
                if(option is "Entree")
                {
                    foreach (IOrderItem item in items)
                    {
                        if (item is Entree) result.Add(item);
                    }
                }
                else if(option is "Side")
                {
                    foreach (IOrderItem item in items)
                    {
                        if (item is Side) result.Add(item);
                    }
                }
                else
                {
                    foreach (IOrderItem item in items)
                    {
                        if (item is Drink) result.Add(item);
                    }
                }
            }
            return items;
        }

        public static IEnumerable<IOrderItem> FilterByIMDBRating(IEnumerable<IOrderItem> items, double? min, double? max)
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
    }
}
