/// <summary>
/// Author: Chintan Patel
/// Reference: Nathan Bean
/// Class: CIS 400
/// Purpose: A class representing the CashRegisterControl.xaml class.
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        /// <summary>
        /// Receipt printer to store the user's order.
        /// </summary>
        private ReceiptPrinter receiptPrinter = new ReceiptPrinter();

        private Order order;

        public CashRegisterControl()
        {
        }

        public CashRegisterControl(Order order, double total)
        {
            InitializeComponent();

            this.order = order;
        }

        /// <summary>
        /// Allows the user to cancel the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        private void OnCancelButton_Clicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }

        /// <summary>
        /// Completes order and prints the receipt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCompleteButton_Clicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashRegisterModelView view)
            {
                receiptPrinter.Print(order.Receipt(false, 0, 0));
                var screen = new OrderControl();
                this.Content = screen;
            }

        }


    }
}
