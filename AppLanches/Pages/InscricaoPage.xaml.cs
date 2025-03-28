using AppLanches.Services;

namespace AppLanches.Pages;

public partial class InscricaoPage : ContentPage
{
    private readonly ApiService _apiservice;
    public InscricaoPage(ApiService apiservice)
    {
        InitializeComponent();
        _apiservice = apiservice;
    }
    private async void BtnSignup_ClickedAsync(object sender, EventArgs e)
    {

        var response = await _apiservice.RegistrarUsuario(EntNome.Text, EntEmail.Text,
                                                          EntPhone.Text, EntPassword.Text);

        if (!response.HasError)
        {
            await DisplayAlert("Aviso", "Sua conta foi criada com sucesso !!", "OK");
            await Navigation.PushAsync(new LoginPage(_apiservice));
        }
        else
        {
            await DisplayAlert("Erro", "Algo deu errado!!!", "Cancelar");
        }
    }

    private async void TapLogin_TappedAsync(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginPage(_apiservice));
    }

    private void BtnSignup_Clicked(object sender, EventArgs e)
    {

    }

    private void TapLogin_Tapped(object sender, TappedEventArgs e)
    {

    }
}