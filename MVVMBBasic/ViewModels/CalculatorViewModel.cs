using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; }

        public ICommand SubtractCommand { get; }

        public ICommand MultiplyCommand { get; }

        public ICommand DivideCommand { get; }

        //public ICommand NavigateToWelcomeMenuCommand { get; }


        public CalculatorViewModel()
        {
            Title = "מחשבון מתמטי";
            AddCommand = new Command(Add);
            SubtractCommand = new Command(Subtract);
            MultiplyCommand = new Command(Multiply);
            DivideCommand = new Command(Divide);
            //NavigateToWelcomeMenuCommand = new Command(async () =>
            //{
            //    await Shell.Current.GoToAsync("//WelcomeMenu");
            //});
        }

        private double _firstNumber;

        public double FirstNumber
        {
            get => _firstNumber;
            set
            {
                if (_firstNumber != value)
                {
                    _firstNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _secondNumber;

        public double SecondNumber
        {
            get => _secondNumber;
            set
            {
                if (_secondNumber != value)
                {
                    _secondNumber = value;
                    OnPropertyChanged();
                }
            }
        }

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

        // פעולת חיבור (+)
        private void Add()
        {
            double result = FirstNumber + SecondNumber;
            Result = result.ToString();
        }

        // פעולת חיסור (-)
        private void Subtract()
        {
            double result = FirstNumber - SecondNumber;
            Result = result.ToString();
        }

        // פעולת כפל (*)
        private void Multiply()
        {
            double result = FirstNumber * SecondNumber;
            Result = result.ToString();
        }

        // פעולת חילוק (/)
        private void Divide()
        {
            if (SecondNumber == 0)
            {
                Result = "שגיאה: חלוקה באפס";
                return;
            }
            double result = FirstNumber / SecondNumber;
            Result = result.ToString();
        }


    }
}
