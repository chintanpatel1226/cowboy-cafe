﻿/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the interaction logic for CustomizeChiliCheeseFries.xaml
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
    /// Interaction logic for CustomizeChiliCheeseFries.xaml
    /// </summary>
    public partial class CustomizeChiliCheeseFries : UserControl
    {
        public CustomizeChiliCheeseFries()
        {
            InitializeComponent();
            SmallRadioButton.Checked += OnSize_Checked;
            MediumRadioButton.Checked += OnSize_Checked;
            LargeRadioButton.Checked += OnSize_Checked;

            SmallRadioButton.Loaded += RadioButtonSelection_Loaded;
            MediumRadioButton.Loaded += RadioButtonSelection_Loaded;
            LargeRadioButton.Loaded += RadioButtonSelection_Loaded;
        }
        
        /// <summary>
        /// Sets the size of the side object based on the user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Event argument.</param>
        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            if (DataContext is ChiliCheeseFries chili)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Small":
                            chili.Size = Size.Small;
                            break;
                        case "Medium":
                            chili.Size = Size.Medium;
                            break;
                        case "Large":
                            chili.Size = Size.Large;
                            break;
                        default:
                            throw new NotImplementedException("Size not Available");
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
            if (DataContext is ChiliCheeseFries side)
            {
                switch (side.Size)
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
