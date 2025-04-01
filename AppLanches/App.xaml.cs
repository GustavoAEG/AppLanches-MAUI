using AppLanches.Pages;
using AppLanches.Services;
using AppLanches.Validations;

namespace AppLanches
{
    public partial class App : Application
    {
        private readonly ApiService _apiservice;
        private readonly IValidator _validator;
        public App(ApiService apiservice, IValidator validator)
        {
            InitializeComponent();
            _apiservice = apiservice;
            _validator = validator;
            SetMainPage();

        }
        private void SetMainPage()
        {
            var acessToken = Preferences.Get("accessToken", string.Empty);

            if (string.IsNullOrEmpty(acessToken))
            {
                MainPage = new NavigationPage(new LoginPage(_apiservice,_validator));
                return;
            }
            MainPage = new AppShell();
        }
    }
}
