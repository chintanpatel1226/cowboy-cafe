/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the interaction logic for CustomizePanDeCampo.xaml
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
    /// Interaction logic for CustomizePanDeCampo.xaml
    /// </summary>
    public partial class CustomizePanDeCampo : UserControl
    {
        /// <summary>
        /// Constructor initializing components
        /// </summary>
        public CustomizePanDeCampo()
        {
            InitializeComponent();
            SmallRadioButton.Checked += OnSize_Checked;
            MediumRadioButton.Checked += OnSize_Checked;
            LargeRadioButton.Checked += OnSize_Checked;
        }

        /// <summary>
        /// Sets the size of the drink object based on the user's choice.
        /// </summary>
        /// <param name="sender">The user's interaction.</param>
        /// <param name="args">Event argument.</param>
        private void OnSize_Checked(object sender, RoutedEventArgs args)
        {
            if (DataContext is PanDeCampo pdc)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Small":
                            pdc.Size = Size.Small;
                            break;
                        case "Medium":
                            pdc.Size = Size.Medium;
                            break;
                        case "Large":
                            pdc.Size = Size.Large;
                            break;
                        default:
                            throw new NotImplementedException("Size not Avialable");
                    }
                }
            }
        }
    }
}
