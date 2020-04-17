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
    }
}
