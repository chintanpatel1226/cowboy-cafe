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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancels the current order and creates a new order.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            if (DataContext is Order order)
            {
                screen.DataContext = order;
                this.Content = screen;
            }
        }
    }
}
