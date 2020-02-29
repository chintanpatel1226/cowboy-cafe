using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            //Entrees
            AddCowpokeChiliButton.Click += AddCowpokeChiliButton_Clicked;
            AddRustlersRibsButton.Click += AddRustlersRibsButton_Clicked;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButton_Clicked;
            AddTrailBurgerButton.Click += AddTrailBurgerButton_Clicked;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButton_Clicked;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButton_Clicked;
            AddAngryChickenButton.Click += AddAngryChickenButton_Clicked;

            //Sides
            AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButton_Clicked;
            AddCornDodgersButton.Click += AddCornerDodgersButton_Clicked;
            AddPanDeCampoButton.Click += AddPanDeCampoButton_Clicked;
            AddBakedBeansButton.Click += AddBakedBeansButton_Clicked;

            //Drinks
            AddJerkedSodaButton.Click += AddJerkedSodaButton_Clicked;
            AddTexasTeaButton.Click += AddTexasTeaButton_Clicked;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButton_Clicked;
            AddWaterButton.Click += AddWaterButton_Clicked;
        }

        /// <summary>
        /// Adds the item "Cowpoke Chili" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddCowpokeChiliButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Adds the item "Rustler's Ribs" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddRustlersRibsButton_Clicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Adds the item "Peco's Pulled Pork" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddPecosPulledPorkButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Adds the item "Trail Burger" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddTrailBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Adds the item "Dakota Double Burger" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddDakotaDoubleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Adds the item "Texas Triple Burger" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddTexasTripleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds the item "Angry Chicken" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddAngryChickenButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds the item "Chili Cheese Fries" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddChiliCheeseFriesButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Adds the item "Corner Dodgers" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddCornerDodgersButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Adds the item "Pan de Campo" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddPanDeCampoButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Adds the item "Baked Beans" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddBakedBeansButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Adds the item "Jerked Soda" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddJerkedSodaButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Adds the item "Texas Tea" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddTexasTeaButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Adds the item "Cowboy Coffee" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddCowboyCoffeeButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Adds the item "Water" to the Order list view.
        /// </summary>
        /// <param name="sender">The user input.</param>
        /// <param name="e">The data associated with the routed event.</param>
        void AddWaterButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        
    }
}
