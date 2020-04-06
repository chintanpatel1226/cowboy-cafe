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

        public void CreditPaymentButton_Clicked(object sender, RoutedEventArgs e)
        {
            FrameworkElement screen = null;
            if (DataContext is Order order)
            {
                switch (cardTerminal.ProcessTransaction(order.TotalWithTax))
                {
                    case ResultCode.Success:
                        //receiptPrinter.Print(order.Receipt(false, order.));
                        screen = new OrderControl();
                        this.Content = screen;
                        break;
                    case ResultCode.InsufficentFunds:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.CancelledCard:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.ReadError:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    case ResultCode.UnknownErrror:
                        screen = new TransactionControl();
                        screen.DataContext = order;
                        this.Content = screen;
                        break;
                    default:
                        throw new NotImplementedException("No results.");
                }
            }
        }
        
    }
}
