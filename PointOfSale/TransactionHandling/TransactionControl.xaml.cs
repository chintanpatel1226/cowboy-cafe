/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the TransactionControl.xaml class.
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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        private CardTerminal cardTerminal = new CardTerminal();

        private ReceiptPrinter receiptPrinter = new ReceiptPrinter();

        /// <summary>
        /// Public constructor.
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancels the current order and creates a new order.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        private void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }

        /// <summary>
        /// Allows the user to pay with credit.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="e">Event data.</param>
        private void CreditPaymentButton_Clicked(object sender, RoutedEventArgs e)
        {
            FrameworkElement screen = null;
            if (DataContext is Order order)
            {
                switch (cardTerminal.ProcessTransaction(order.TotalWithTax))
                {
                    case ResultCode.Success:
                        receiptPrinter.Print(order.Receipt(true, 0 , 0));
                        MessageBox.Show("Transaction Was a success.");
                        screen = new OrderControl();
                        this.Content = screen;
                        break;
                    case ResultCode.InsufficentFunds:
                        MessageBox.Show("Insufficient Funds.");
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.CancelledCard:
                        MessageBox.Show("Card Denied.");
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.ReadError:
                        MessageBox.Show("Error reading card.");
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.UnknownErrror:
                        MessageBox.Show("Unknown Error.");
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                }
            }
        }
        
    }
}
