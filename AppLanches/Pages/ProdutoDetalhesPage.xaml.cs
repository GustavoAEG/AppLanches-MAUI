
using AppLanches.Services;
using AppLanches.Validations;

namespace AppLanches.Pages;

public partial class ProdutoDetalhesPage : ContentPage
{
	private readonly ApiService apiService;
	private readonly IValidator _validator;
	private int _produtoId;
	private bool _loginPageDisplayed = false;
    public ProdutoDetalhesPage(int produtoId,string produtoNome, ApiService apiService, IValidator validator)
    {
        InitializeComponent();
        this.apiService = apiService;
        _validator = validator;
        _produtoId = produtoId;
        Title = produtoNome ?? "Detalhe do Produto";

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetProdutoDetalhes(_produtoId);
    }

    private async Task GetProdutoDetalhes(int produtoId)
    {
        throw new NotImplementedException();
    }

    private void ImagemBtnFavorito_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnRemove_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnAdiciona_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnIncluirNoCarrinho_Clicked(object sender, EventArgs e)
    {

    }
}