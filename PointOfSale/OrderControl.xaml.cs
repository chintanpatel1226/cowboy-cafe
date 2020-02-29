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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var order = new Order();
            this.DataContext = order;
            ItemSelectionButton.Click += ItemSelectionButton_Clicked;
            CancelOrderButton.Click += CancelOrderButton_Clicked;
            CompleteOrderButton.Click += CompleteOrderButton_Clicked;
        }

        void ItemSelectionButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void CompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
