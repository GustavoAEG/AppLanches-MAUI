
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

    }
}