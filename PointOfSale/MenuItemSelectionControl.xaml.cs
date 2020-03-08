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
                            var entreeTrailBurger = new PecosPulledPork();
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
                            order.Add(entreeTexasTripleBurger);
                            orderControl.SwapScreen(screenTexasTripleBurger);
                            break;
                        case "AngryChicken":
                            var entreeAngryChicken = new AngryChicken();
                            var screenAngryChicken = new CustomizeAngryChicken();
                            order.Add(entreeAngryChicken);
                            orderControl.SwapScreen(screenAngryChicken);
                            break;
                        case "ChiliCheeseFries":
                            var sideChiliCheeseFries = new ChiliCheeseFries();
                            var screenChiliCheeseFriese = new CustomizeChiliCheeseFries();
                            order.Add(sideChiliCheeseFries);
                            orderControl.SwapScreen(screenChiliCheeseFriese);
                            break;
                        case "CornerDodgers":
                            var sideCornDodgers = new CornDodgers();
                            var screenCornDodgers = new CustomizeCornDodgers();
                            order.Add(sideCornDodgers);
                            orderControl.SwapScreen(screenCornDodgers);
                            break;
                        case "PanDeCampo":
                            var sidePanDeCampo = new PanDeCampo();
                            var screenPanDeCampo = new CustomizePanDeCampo();
                            order.Add(sidePanDeCampo);
                            orderControl.SwapScreen(screenPanDeCampo);
                            break;
                        case "BakedBeans":
                            var sideBakedBeans = new BakedBeans();
                            var screenBakedBeans = new CustomizeBakedBeans();
                            order.Add(sideBakedBeans);
                            orderControl.SwapScreen(screenBakedBeans);
                            break;
                        case "JerkedSoda":
                            var drinkJerkedSoda = new JerkedSoda();
                            var screenJerkedSoda = new CustomizeJerkedSoda();
                            order.Add(drinkJerkedSoda);
                            orderControl.SwapScreen(screenJerkedSoda);
                            break;
                        case "TexasTea":
                            var drinkTexasTea = new TexasTea();
                            var screenTexasTea = new CustomizeTexasTea();
                            order.Add(drinkTexasTea);
                            orderControl.SwapScreen(screenTexasTea);
                            break;
                        case "CowboyCoffee":
                            var drinkCowboyCoffee = new CowboyCoffee();
                            var screenCowboyCoffee = new CustomizeCowboyCoffee();
                            order.Add(drinkCowboyCoffee);
                            orderControl.SwapScreen(screenCowboyCoffee);
                            break;
                        case "Water":
                            var drinkWater = new Water();
                            var screenWater = new CustomizeWater();
                            order.Add(drinkWater);
                            orderControl.SwapScreen(screenWater);
                            break;
                    }
                }
            }
        }
    }
}
