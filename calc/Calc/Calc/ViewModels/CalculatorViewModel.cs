using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Input;
//using Xamarin.Forms;

namespace Calc.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _inputText;
        private string _calculateResult;

        public string InputText
        {
            get => _inputText;
            set
            {
                if (_inputText != value)
                {
                    _inputText = value;
                    OnPropertyChanged(nameof(InputText));
                }
            }
        }

        public string CalculateResult
        {
            get => _calculateResult;
            set
            {
                if (_calculateResult != value)
                {
                    _calculateResult = value;
                    OnPropertyChanged(nameof(CalculateResult));
                }
            }
        }

        // Defineerime erinevad käsud
        public ICommand ResetCommand { get; }
        public ICommand NumberInputCommand { get; }
        public ICommand MathOperatorCommand { get; }
        public ICommand CalculateCommand { get; }
        public ICommand BackspaceCommand { get; }
        public ICommand ScientificOperatorCommand { get; } // Ühtne käsk teaduslike operatsioonide jaoks

        public CalculatorViewModel()
        {
            ResetCommand = new Command(OnReset);
            NumberInputCommand = new Command<string>(OnNumberInput);
            MathOperatorCommand = new Command<string>(OnMathOperator);
            CalculateCommand = new Command(OnCalculate);
            BackspaceCommand = new Command(OnBackspace);
            ScientificOperatorCommand = new Command<string>(OnScientificOperator); // Kasutame ühtset meetodit
        }

        private void OnReset()
        {
            InputText = string.Empty;
            CalculateResult = string.Empty;
        }

        private void OnNumberInput(string number)
        {
            InputText += number;
        }

        private void OnMathOperator(string mathOperator)
        {
            InputText += $" {mathOperator} ";
        }

        private void OnCalculate()
        {
            try
            {
                var result = new DataTable().Compute(InputText, null);
                CalculateResult = result.ToString();
            }
            catch
            {
                CalculateResult = "Error";
            }
        }

        private void OnBackspace()
        {
            if (!string.IsNullOrEmpty(InputText))
            {
                InputText = InputText.Substring(0, InputText.Length - 1);
            }
        }

        private void OnScientificOperator(string operation)
        {
            try
            {
                double number;
                if (double.TryParse(InputText, out number))
                {
                    double result = operation switch
                    {
                        "sin" => Math.Sin(number),
                        "cos" => Math.Cos(number),
                        "tan" => Math.Tan(number),
                        "asin" => Math.Asin(number),
                        "acos" => Math.Acos(number),
                        "atan" => Math.Atan(number),
                        "log" => Math.Log(number),
                        "log10" => Math.Log10(number),
                        "exp" => Math.Exp(number),
                        "sqrt" => Math.Sqrt(number),
                        "abs" => Math.Abs(number),
                        "fact" => Factorial(number), // Lisa oma funktsioon faktoriaali jaoks
                       
                        // Teised funktsioonid...
                        _ => throw new NotSupportedException($"Operation {operation} not supported.")
                    };

                    CalculateResult = result.ToString();
                }
                else
                {
                    CalculateResult = "Invalid Input";
                }
            }
            catch (Exception ex)
            {
                CalculateResult = "Error: " + ex.Message;
            }
        }

        private double Factorial(double n)
        {
            if (n < 0) return double.NaN; // Faktoriaal pole negatiivsete arvude jaoks defineeritud
            if (n == 0) return 1;

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}