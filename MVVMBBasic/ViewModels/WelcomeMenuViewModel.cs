using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeMenuViewModel : BaseViewModel
    {
        public ICommand NavigateToTemperatureCommand { get; }

        public ICommand NavigateToCalcAgeCommand { get; }

        public ICommand NavigateToMathCommand { get; }

        public ICommand NavigateToCurrencyCommand { get; }


        public WelcomeMenuViewModel()
        {
            NavigateToTemperatureCommand = 
                new Command(async () =>await Shell.Current.GoToAsync("//TemperatureCalculator"));

            NavigateToCalcAgeCommand =
                new Command(async () => await Shell.Current.GoToAsync("//CalcAge"));

            NavigateToMathCommand =
                new Command(async () => await Shell.Current.GoToAsync("//Calculator"));

            NavigateToCurrencyCommand =
                new Command(async () => await Shell.Current.GoToAsync("//CurrencyCalculator"));

            Title = "Calculator Menu:";
        }
    }
}
