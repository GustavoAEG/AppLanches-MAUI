using AppLanches.Pages;
using AppLanches.Services;

namespace AppLanches
{
    public partial class App : Application
    {
        private readonly ApiService _apiservice;
        public App(ApiService apiservice)
        {
            InitializeComponent();
            _apiservice = apiservice;
            MainPage = new NavigationPage(new InscricaoPage(_apiservice));
          
        }
    }
}
