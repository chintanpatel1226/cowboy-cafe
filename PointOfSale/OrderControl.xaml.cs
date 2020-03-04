/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the OrderControl.xaml
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes components of the class and creates an instance of the order class.
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
            ItemSelectionButton.Click += ItemSelectionButton_Clicked;
            CancelOrderButton.Click += CancelOrderButton_Clicked;
            CompleteOrderButton.Click += CompleteOrderButton_Clicked;
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// [NOT IMPLEMENTED] Displays the item selection.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        void ItemSelectionButton_Clicked(object sender, RoutedEventArgs e)
        {

        }
        

        /// <summary>
        /// Cancels the current order and creates a new order.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Completes the current order and creates a new order.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        void CompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
