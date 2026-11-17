using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class CurrencyCalculatorViewModel : BaseViewModel
    {
        public ICommand CurrecnyCalculatorCommand { get; }

        //public ICommand NavigateToWelcomeMenuCommand { get; }

        public List<string> Currencies { get; } = new List<string> { "Shekels", "Dollars", "Euros", "Pounds" };

        public CurrencyCalculatorViewModel()
        {
            Title = "מחשבון מטבעות";
            CurrecnyCalculatorCommand = new Command(CurrecnyCalculator);
            //NavigateToWelcomeMenuCommand = new Command(async () =>
            //{
            //    await Shell.Current.GoToAsync("//WelcomeMenu");
            //});
        }

        private string _fromCurrency = "Shekels";
        public string FromCurrency
        {
            get => _fromCurrency;
            set
            {
                if (_fromCurrency != value)
                {
                    _fromCurrency = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _toCurrency = "Dollars";
        public string ToCurrency
        {
            get => _toCurrency;
            set
            {
                if (_toCurrency != value)
                {
                    _toCurrency = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _result;
        public double Result
        {
            get => _result;
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged();
                }
            }
        }

        private void CurrecnyCalculator()
        {
            double rate = GetRate(FromCurrency, ToCurrency);
            Result = Amount * rate;
        }

        private double GetRate(string from, string to)
        {
            if (from == to)
                return 1;

            double shekelsRate = from switch
            {
                "Shekels" => 1,
                "Dollars" => 3.5,
                "Euros" => 4.0,
                "Pounds" => 4.5,
                _ => 1
            };

            double targetRate = to switch
            {
                "Shekels" => 1,
                "Dollars" => 3.5,
                "Euros" => 4.0,
                "Pounds" => 4.5,
                _ => 1
            };

            return shekelsRate / targetRate;
        }
    }
}
