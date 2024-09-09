using MauiPlanets.Views;

namespace MauiPlanets
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage();
        }
    }
}
