/// <summary>
/// Author: Chintan Patel
/// Reference: Nathan Bean
/// Class: CIS 400
/// Purpose: A class representing the CoinControl.xaml class.
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register(
            "Denomination",
            typeof(Coins),
            typeof(CoinControl),
            new PropertyMetadata(Coins.Penny)
            );

        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public Coins Denomination
        {
            get => (Coins)GetValue(DenominationProperty);
            set => SetValue(DenominationProperty, value);
        }

        /// <summary>
        /// The DependencyProperty for the QuantityProperty
        /// </summary>
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
            "Quantity",
            typeof(int),
            typeof(CoinControl),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
            );

        /// <summary>
        /// The quantity of the coin denomination.
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        /// <summary>
        /// Public constructor
        /// </summary>
        public CoinControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the quantity of the bound coinage by one.
        /// </summary>
        /// <param name="sender">The coinage quantity.</param>
        /// <param name="e">The event args.</param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases the quantity of the bound coinage by one.
        /// </summary>
        /// <param name="sender">The coinage quantity.</param>
        /// <param name="e">The event args.</param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            if(Quantity > 0)
            {
                Quantity--;
            }
            else
            {
                Quantity = 0;
            }
        }
    }
}
