/// <summary>
/// Author: Chintan Patel
/// Class: CIS 400
/// Purpose: A class representing the MenuItemSelectionControl.xaml
/// </summary>
using System;
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initializes components withing the MenuItemSelectionControl class.
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            //Entrees
            AddCowpokeChiliButton.Click += OnItemAddButton_Clicked;
            AddRustlersRibsButton.Click += OnItemAddButton_Clicked;
            AddPecosPulledPorkButton.Click += OnItemAddButton_Clicked;
            AddTrailBurgerButton.Click += OnItemAddButton_Clicked;
            AddDakotaDoubleBurgerButton.Click += OnItemAddButton_Clicked;
            AddTexasTripleBurgerButton.Click += OnItemAddButton_Clicked;
            AddAngryChickenButton.Click += OnItemAddButton_Clicked;

            //Sides
            AddChiliCheeseFriesButton.Click += OnItemAddButton_Clicked;
            AddCornDodgersButton.Click += OnItemAddButton_Clicked;
            AddPanDeCampoButton.Click += OnItemAddButton_Clicked;
            AddBakedBeansButton.Click += OnItemAddButton_Clicked;

            //Drinks
            AddJerkedSodaButton.Click += OnItemAddButton_Clicked;
            AddTexasTeaButton.Click += OnItemAddButton_Clicked;
            AddCowboyCoffeeButton.Click += OnItemAddButton_Clicked;
            AddWaterButton.Click += OnItemAddButton_Clicked;
        }

        /// <summary>
        /// Creates an object 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemAddButton_Clicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var entreeCowpokeChili = new CowpokeChili();
                            var screenCowpokeChili = new CustomizeCowpokeChili();
                            screenCowpokeChili.DataContext = entreeCowpokeChili;
                            order.Add(entreeCowpokeChili);
                            orderControl.SwapScreen(screenCowpokeChili);
                            break;
                        case "RustlersRibs":
                            var entreeRustlersRibs = new RustlersRibs();
                            var screenRustlersRibs = new CustomizeRustlersRibs();
                            screenRustlersRibs.DataContext = entreeRustlersRibs;
                            order.Add(entreeRustlersRibs);
                            orderControl.SwapScreen(screenRustlersRibs);
                            break;
                        case "PecosPulledPork":
                            var entreePecosPulledPork = new PecosPulledPork();
                            var screenPecosPulledPork = new CustomizePecosPulledPork();
                            screenPecosPulledPork.DataContext = entreePecosPulledPork;
                            order.Add(entreePecosPulledPork);
                            orderControl.SwapScreen(screenPecosPulledPork);
                            break;
                        case "TrailBurger":
                            var entreeTrailBurger = new TrailBurger();
                            var screenTrailBurger = new CustomizeTrailBurger();
                            screenTrailBurger.DataContext = entreeTrailBurger;
                            order.Add(entreeTrailBurger);
                            orderControl.SwapScreen(screenTrailBurger);
                            break;
                        case "DakotaDoubleBurger":
                            var entreeDakotaDoubleBurger = new DakotaDoubleBurger();
                            var screenDakotaDoubleBurger = new CustomizeDakotaDoubleBurger();
                            screenDakotaDoubleBurger.DataContext = entreeDakotaDoubleBurger;
                            order.Add(entreeDakotaDoubleBurger);
                            orderControl.SwapScreen(screenDakotaDoubleBurger);
                            break;
                        case "TexasTripleBurger":
                            var entreeTexasTripleBurger = new TexasTripleBurger();
                            var screenTexasTripleBurger = new CustomizeTexasTripleBurger();
                            screenTexasTripleBurger.DataContext = entreeTexasTripleBurger;
                            order.Add(entreeTexasTripleBurger);
                            orderControl.SwapScreen(screenTexasTripleBurger);
                            break;
                        case "AngryChicken":
                            var entreeAngryChicken = new AngryChicken();
                            var screenAngryChicken = new CustomizeAngryChicken();
                            screenAngryChicken.DataContext = entreeAngryChicken;
                            order.Add(entreeAngryChicken);
                            orderControl.SwapScreen(screenAngryChicken);
                            break;
                        case "ChiliCheeseFries":
                            var sideChiliCheeseFries = new ChiliCheeseFries();
                            var screenChiliCheeseFries = new CustomizeChiliCheeseFries();
                            screenChiliCheeseFries.DataContext = sideChiliCheeseFries;
                            order.Add(sideChiliCheeseFries);
                            orderControl.SwapScreen(screenChiliCheeseFries);
                            break;
                        case "CornDodgers":
                            var sideCornDodgers = new CornDodgers();
                            var screenCornDodgers = new CustomizeCornDodgers();
                            screenCornDodgers.DataContext = sideCornDodgers;
                            order.Add(sideCornDodgers);
                            orderControl.SwapScreen(screenCornDodgers);
                            break;
                        case "PanDeCampo":
                            var sidePanDeCampo = new PanDeCampo();
                            var screenPanDeCampo = new CustomizePanDeCampo();
                            screenPanDeCampo.DataContext = sidePanDeCampo;
                            order.Add(sidePanDeCampo);
                            orderControl.SwapScreen(screenPanDeCampo);
                            break;
                        case "BakedBeans":
                            var sideBakedBeans = new BakedBeans();
                            var screenBakedBeans = new CustomizeBakedBeans();
                            screenBakedBeans.DataContext = sideBakedBeans;
                            order.Add(sideBakedBeans);
                            orderControl.SwapScreen(screenBakedBeans);
                            break;
                        case "JerkedSoda":
                            var drinkJerkedSoda = new JerkedSoda();
                            var screenJerkedSoda = new CustomizeJerkedSoda();
                            screenJerkedSoda.DataContext = drinkJerkedSoda;
                            order.Add(drinkJerkedSoda);
                            orderControl.SwapScreen(screenJerkedSoda);
                            break;
                        case "TexasTea":
                            var drinkTexasTea = new TexasTea();
                            var screenTexasTea = new CustomizeTexasTea();
                            screenTexasTea.DataContext = drinkTexasTea;
                            order.Add(drinkTexasTea);
                            orderControl.SwapScreen(screenTexasTea);
                            break;
                        case "CowboyCoffee":
                            var drinkCowboyCoffee = new CowboyCoffee();
                            var screenCowboyCoffee = new CustomizeCowboyCoffee();
                            screenCowboyCoffee.DataContext = drinkCowboyCoffee;
                            order.Add(drinkCowboyCoffee);
                            orderControl.SwapScreen(screenCowboyCoffee);
                            break;
                        case "Water":
                            var drinkWater = new Water();
                            var screenWater = new CustomizeWater();
                            screenWater.DataContext = drinkWater;
                            order.Add(drinkWater);
                            orderControl.SwapScreen(screenWater);
                            break;
                    }
                }
            }
        }
    }
}
