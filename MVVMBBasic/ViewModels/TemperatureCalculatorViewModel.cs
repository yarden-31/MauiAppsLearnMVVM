using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class TemperatureCalculatorViewModel : BaseViewModel
    {
        public ICommand ConvertToCelsiusCommand { get; }

        public TemperatureCalculatorViewModel()
        {
            Title = "מחשבון טמפרטורה";
            ConvertToCelsiusCommand = new Command(ConvertToCelsius);
        }

        // מאפיין לטמפרטורה במעלות פרנהייט
        private double _temperatureFahrenheit;
        public double TemperatureFahrenheit
        {
            get => _temperatureFahrenheit;
            set
            {
                if (_temperatureFahrenheit != value)
                {
                    _temperatureFahrenheit = value;
                    OnPropertyChanged();
                }
            }
        }

        // מאפיין לטמפרטורה במעלות צלזיוס
        private double _temperatureCelsius;
        public double TemperatureCelsius
        {
            get => _temperatureCelsius;
            set
            {
                if (_temperatureCelsius != value)
                {
                    _temperatureCelsius = value;
                    OnPropertyChanged();
                }
            }
        }

        // מאפיין לתוצאה של ההמרה
        private string _result = string.Empty;

        public string Result
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


        // פונקציה להמרת טמפרטורה ממעלות פרנהייט למעלות צלזיוס
        public void ConvertToCelsius()
        {
            if (double.TryParse(TemperatureFahrenheit.ToString(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                TemperatureCelsius = celsius;
                Result = $"הטמפרטורה במעלות צלזיוס היא: {celsius:F2}";
            }
        }
    }
}
