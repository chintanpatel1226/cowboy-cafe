/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the interaction logic for CustomizeJerkedSoda.xaml
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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        /// <summary>
        /// Constructor initializing components
        /// </summary>
        public CustomizeJerkedSoda()
        {
            InitializeComponent();

            BirchBeerRadioButton.Checked += OnFlavorSelection_Clicked;
            CreamSodaRadioButton.Checked += OnFlavorSelection_Clicked;
            OrangeSodaRadioButton.Checked += OnFlavorSelection_Clicked;
            RootBeerRadioButton.Checked += OnFlavorSelection_Clicked;
            SarsparillaRadioButton.Checked += OnFlavorSelection_Clicked;

            BirchBeerRadioButton.Loaded += FlavorSelection_Loaded;
            CreamSodaRadioButton.Loaded += FlavorSelection_Loaded;
            OrangeSodaRadioButton.Loaded += FlavorSelection_Loaded;
            RootBeerRadioButton.Loaded += FlavorSelection_Loaded;
            SarsparillaRadioButton.Loaded += FlavorSelection_Loaded;

            SmallRadioButton.Click += OnSize_Checked;
            MediumRadioButton.Click += OnSize_Checked;
            LargeRadioButton.Click += OnSize_Checked;

            SmallRadioButton.Loaded += RadioButtonSelection_Loaded;
            MediumRadioButton.Loaded += RadioButtonSelection_Loaded;
            LargeRadioButton.Loaded += RadioButtonSelection_Loaded;
        }

        /// <summary>
        /// Sets the flavor of the drink object based on user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Event argument.</param>
        private void OnFlavorSelection_Clicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is JerkedSoda soda)
            {
                if(sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "BirchBeer":
                            soda.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "CreamSoda":
                            soda.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "OrangeSoda":
                            soda.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "RootBeer":
                            soda.Flavor = SodaFlavor.RootBeer;
                            break;
                        case "Sarsparilla":
                            soda.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        default:
                            throw new NotImplementedException("No flavor selection.");
                    }
                }
            }
        }

        /// <summary>
        /// Sets the radio button to the respective flavor selected.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">The event args.</param>
        private void FlavorSelection_Loaded(object sender, RoutedEventArgs args)
        {
            if(DataContext is JerkedSoda soda)
            {
                switch (soda.Flavor)
                {
                    case SodaFlavor.BirchBeer:
                        BirchBeerRadioButton.IsChecked = true;
                        break;
                    case SodaFlavor.CreamSoda:
                        CreamSodaRadioButton.IsChecked = true;
                        break;
                    case SodaFlavor.OrangeSoda:
                        OrangeSodaRadioButton.IsChecked = true;
                        break;
                    case SodaFlavor.RootBeer:
                        RootBeerRadioButton.IsChecked = true;
                        break;
                    case SodaFlavor.Sarsparilla:
                        SarsparillaRadioButton.IsChecked = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets the size of the drink object based on the user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Event argument.</param>
        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            if (DataContext is JerkedSoda soda)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Small":
                            soda.Size = Size.Small;
                            break;
                        case "Medium":
                            soda.Size = Size.Medium;
                            break;
                        case "Large":
                            soda.Size = Size.Large;
                            break;
                        default:
                            throw new NotImplementedException("Size not Avialable");
                    }
                }
            }
        }

        /// <summary>
        /// Sets the button loaded to the user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">The event args.</param>
        private void RadioButtonSelection_Loaded(object sender, RoutedEventArgs args)
        {
            if (DataContext is JerkedSoda drink)
            {
                switch (drink.Size)
                {
                    case Size.Small:
                        SmallRadioButton.IsChecked = true;
                        break;
                    case Size.Medium:
                        MediumRadioButton.IsChecked = true;
                        break;
                    case Size.Large:
                        LargeRadioButton.IsChecked = true;
                        break;
                }
            }
        }
    }
}
