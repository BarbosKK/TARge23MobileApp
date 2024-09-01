using Calc.ViewModels;


namespace Calc.Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();

            // Sidume lehe ViewModeliga
            BindingContext = new CalculatorViewModel();
        }
    }
}