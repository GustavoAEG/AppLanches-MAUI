using AppLanches.Pages;

namespace AppLanches
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InscricaoPage());
        }
    }
}
