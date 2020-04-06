/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the OrderSummaryControl.xaml
/// </summary>
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
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initializes components withing the OrderSummaryControl class.
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
           
        }

        /// <summary>
        /// Removes the instance of an item
        /// </summary>
        /// <param name="sender">The user's interaction..</param>
        /// <param name="args">Argument data.</param>
        private void OnItemRemoveButton_Clicked(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps to an instance of an order already created.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Argument data.</param>
        private void ItemSelectionChanged(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is ListBox listBox)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (listBox.SelectedItem is IOrderItem item)
                    {
                        FrameworkElement screen = null;
                        if (item is AngryChicken)
                        {
                            screen = new CustomizeAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CowpokeChili)
                        {
                            screen = new CustomizeCowpokeChili();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is DakotaDoubleBurger)
                        {
                            screen = new CustomizeDakotaDoubleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PecosPulledPork)
                        {
                            screen = new CustomizePecosPulledPork();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is RustlersRibs)
                        {
                            screen = new CustomizeRustlersRibs();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTripleBurger)
                        {
                            screen = new CustomizeTexasTripleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TrailBurger)
                        {
                            screen = new CustomizeTrailBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is BakedBeans)
                        {
                            screen = new CustomizeBakedBeans();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is ChiliCheeseFries)
                        {
                            screen = new CustomizeChiliCheeseFries();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CornDodgers)
                        {
                            screen = new CustomizeCornDodgers();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PanDeCampo)
                        {
                            screen = new CustomizePanDeCampo();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CowboyCoffee)
                        {
                            screen = new CustomizeCowboyCoffee();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is JerkedSoda)
                        {
                            screen = new CustomizeJerkedSoda();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTea)
                        {
                            screen = new CustomizeTexasTea();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is Water)
                        {
                            screen = new CustomizeWater();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                    }
                }
            }
        }

    }
}
