using AppLanches.Services;
using AppLanches.Validations;

namespace AppLanches.Pages;

public partial class LoginPage : ContentPage
{
    private readonly ApiService _apiservice;
    private readonly IValidator _validator;
    public LoginPage(ApiService apiservice, IValidator validator)
    {
        InitializeComponent();
        _apiservice = apiservice;
        _validator = validator;
    }

    private async void BtnSignIn_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(EntEmail.Text))
        {
            await DisplayAlert("Erro", "Informe o email", "Cancelar");
            return;
        }

        if (string.IsNullOrEmpty(EntPassword.Text))
        {
            await DisplayAlert("Erro", "Informe a senha", "Cancelar");
            return;
        }

        var response = await _apiservice.Login(EntEmail.Text, EntPassword.Text);

        if (!response.HasError)
        {
            Application.Current!.MainPage = new AppShell(_apiservice, _validator);
        }
        else
        {
            await DisplayAlert("Erro", "Algo deu errado", "Cancelar");
        }
    }

    private async void TapRegister_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new InscricaoPage(_apiservice, _validator));
    }
}