using System.ComponentModel;
using System.Data; // Kasutame tulemuse arvutamiseks DataTable
using System.Windows.Input;

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

        public ICommand ResetCommand { get; }
        public ICommand NumberInputCommand { get; }
        public ICommand MathOperatorCommand { get; }
        public ICommand CalculateCommand { get; }
        public ICommand BackspaceCommand { get; }

        public CalculatorViewModel()
        {
            ResetCommand = new Command(OnReset);
            NumberInputCommand = new Command<string>(OnNumberInput);
            MathOperatorCommand = new Command<string>(OnMathOperator);
            CalculateCommand = new Command(OnCalculate);
            BackspaceCommand = new Command(OnBackspace);
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
