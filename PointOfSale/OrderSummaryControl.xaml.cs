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
                        if(item is AngryChicken)
                        {
                            var screen = new CustomizeAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                    }
                }
            }
        }

    }
}
