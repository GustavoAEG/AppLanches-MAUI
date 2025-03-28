using AppLanches.Services;

namespace AppLanches.Pages;

public partial class LoginPage : ContentPage
{
    private readonly ApiService _apiservice;
    public LoginPage(ApiService apiservice)
    {
        InitializeComponent();
        _apiservice = apiservice;
    }

    private void BtnSignIn_Clicked(object sender, EventArgs e)
    {

    }

    private void TapRegister_Tapped(object sender, TappedEventArgs e)
    {

    }
}