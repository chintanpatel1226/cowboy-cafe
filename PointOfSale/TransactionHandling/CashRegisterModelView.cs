/// <summary>
/// Author: Chintan Patel
/// Reference: Nathan Bean
/// Class: CIS 400
/// Purpose: A class representing the CashRegisterModelView.xaml class.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CashRegister;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses.
        /// </summary>
        static CashDrawer drawer = new CashDrawer();

        public double TotalOwed { get; set; }

        public bool SufficientFunds
        {
            get
            {
                return TotalValue > TotalOwed;
            }
        }

        private double totalValue = 0;
        /// <summary>
        /// The total current value of the drawer.
        /// </summary>
        public double TotalValue => totalValue;

        private int countPennies = 0;
        /// <summary>
        /// Get or sets the number of Pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    countPennies++;
                    totalValue += 0.01;
                    drawer.AddCoin(Coins.Penny, quantity);
                }
                else
                {
                    countPennies--;
                    totalValue -= 0.01;
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                }
                InvokePropertyChanged("Pennies");
            }
        }

        private int countNickels = 0;
        /// <summary>
        /// Get or sets the number of Nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    countNickels++;
                    totalValue += 0.05;
                    drawer.AddCoin(Coins.Nickel, quantity);
                }
                else
                {
                    countNickels--;
                    totalValue -= 0.05;
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                }
                InvokePropertyChanged("Nickels");
            }
        }

        private int countDimes = 0;
        /// <summary>
        /// Get or sets the number of Dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    countDimes++;
                    totalValue += 0.10;
                    drawer.AddCoin(Coins.Dime, quantity);
                }
                else
                {
                    countDimes--;
                    totalValue -= 0.10;
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                }
                InvokePropertyChanged("Dimes");
            }
        }

        private int countQuarters = 0;
        /// <summary>
        /// Get or sets the number of Quarters in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    countQuarters++;
                    totalValue += 0.25;
                    drawer.AddCoin(Coins.Quarter, quantity);
                }
                else
                {
                    countQuarters--;
                    totalValue -= 0.25;
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                }
                InvokePropertyChanged("Quarters");
            }
        }

        private int countHalfDollars = 0;
        /// <summary>
        /// Get or sets the number of HalfDollars in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    countHalfDollars++;
                    totalValue += 0.50;
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                }
                else
                {
                    countHalfDollars--;
                    totalValue -= 0.50;
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        private int countDollars = 0;
        /// <summary>
        /// Get or sets the number of Dollars in the cash register
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    countDollars++;
                    totalValue += 1;
                    drawer.AddCoin(Coins.Dollar, quantity);
                }
                else
                {
                    countDollars--;
                    totalValue -= 1;
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                }
                InvokePropertyChanged("Dollars");
            }
        }

        private int countOnes = 0;
        /// <summary>
        /// Get or sets the number of Ones in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    countOnes++;
                    totalValue += 1;
                    drawer.AddBill(Bills.One, quantity);
                }
                else
                {
                    countOnes--;
                    totalValue += 1;
                    drawer.RemoveBill(Bills.One, -quantity);
                }
                InvokePropertyChanged("Ones");
            }
        }

        private int countTwos = 0;
        /// <summary>
        /// Get or sets the number of Twos in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    countTwos++;
                    totalValue += 2;
                    drawer.AddBill(Bills.Two, quantity);
                }
                else
                {
                    countTwos--;
                    totalValue -= 2;
                    drawer.RemoveBill(Bills.Two, -quantity);
                }
                InvokePropertyChanged("Twos");
            }
        }

        private int countFives = 0;
        /// <summary>
        /// Get or sets the number of Fives in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    countFives++;
                    totalValue += 5;
                    drawer.AddBill(Bills.Five, quantity);
                }
                else
                {
                    countFives--;
                    totalValue -= 5;
                    drawer.RemoveBill(Bills.Five, -quantity);
                }
                InvokePropertyChanged("Fives");
            }
        }

        private int countTens = 0;
        /// <summary>
        /// Get or sets the number of Tens in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    countTens++;
                    totalValue += 10;
                    drawer.AddBill(Bills.Ten, quantity);
                }
                else
                {
                    countTens--;
                    totalValue -= 10;
                    drawer.RemoveBill(Bills.Ten, -quantity);
                }
                InvokePropertyChanged("Tens");
            }
        }

        private int countTwenties = 0;
        /// <summary>
        /// Get or sets the number of Twenties in the cash register.
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    countTwenties++;
                    totalValue += 20;
                    drawer.AddBill(Bills.Twenty, quantity);
                }
                else
                {
                    countTwenties--;
                    totalValue -= 20;
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                }
                InvokePropertyChanged("Twenties");
            }
        }

        private int countFifties = 0;
        /// <summary>
        /// Get or sets the number of Fifties in the cash register.
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    countFifties++;
                    totalValue += 50;
                    drawer.AddBill(Bills.Fifty, quantity);
                }
                else
                {
                    countFifties--;
                    totalValue -= 50;
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanged("Fifties");
            }
        }

        private int countHundred = 0;
        /// <summary>
        /// Get or sets the number of Hundreds in the cash register.
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    countHundred++;
                    totalValue += 100;
                    drawer.AddBill(Bills.Hundred, quantity);
                }
                else
                {
                    countHundred--;
                    totalValue -= 100;
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties and the total value.
        /// </summary>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
