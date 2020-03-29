﻿/// <summary>
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

        private void ItemSelectionChanged(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (sender is ListBox listBox)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (listBox.SelectedItem is IOrderItem item)
                    {
                        if (item is AngryChicken)
                        {
                            var screen = new CustomizeAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is CowpokeChili)
                        {
                            var screen = new CustomizeCowpokeChili();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is DakotaDoubleBurger)
                        {
                            var screen = new CustomizeDakotaDoubleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PecosPulledPork)
                        {
                            var screen = new CustomizePecosPulledPork();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is RustlersRibs)
                        {
                            var screen = new CustomizeRustlersRibs();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTripleBurger)
                        {
                            var screen = new CustomizeTexasTripleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TrailBurger)
                        {
                            var screen = new CustomizeTrailBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is BakedBeans)
                        {
                            var screen = new CustomizeBakedBeans();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is ChiliCheeseFries)
                        {
                            var screen = new CustomizeChiliCheeseFries();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CornDodgers)
                        {
                            var screen = new CustomizeCornDodgers();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PanDeCampo)
                        {
                            var screen = new CustomizePanDeCampo();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CowboyCoffee)
                        {
                            var screen = new CustomizeCowboyCoffee();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is JerkedSoda)
                        {
                            var screen = new CustomizeJerkedSoda();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTea)
                        {
                            var screen = new CustomizeTexasTea();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is Water)
                        {
                            var screen = new CustomizeWater();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                    }
                }
            }
        }

    }
}
