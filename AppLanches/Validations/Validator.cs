using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppLanches.Validations;

public class Validator : IValidator
{
    public string NomeErro { get; set; } = "";
    public string EmailErro { get; set; } = "";
    public string TelefoneErro { get; set; } = "";
    public string SenhaErro { get; set; } = "";

    private const string NomeVazioErroMsg = "Por favor, informe o seu nome";
    private const string NomeInvalidoErroMsg = "Por favor, um nome válido";
    private const string EmailVazioErroMsg = "Por favor, informe um e-mail";
    private const string EmailInvalidaoErroMsg = "Por favor, informe um e-mail válido";
    private const string TelefoneVazioErroMsg = "Por favor, informe um telefone";
    private const string TelefoneInvalidoErroMsg = "Por favor, informe um telefone válido";
    private const string SenhaVaziaErroMensagem = "Por favor, informe a senha";
    private const string SenhaInvalidaErroMensagem = "A senha deve conter pelo menos 8 caracteres, números e letras Maiúsculas e minúsculas";

    public Task<bool> Validar(string nome, string email, string telefone, string senha)
    {
        var isNomeValido = ValidarNome(nome);
        var isEmailValido = ValidarEmail(email);
        var isTelefoneValido = ValidarTelefone(telefone);
        var isSenhaValida = ValidarSenha(senha);

        return Task.FromResult(isNomeValido && isEmailValido && isTelefoneValido && isSenhaValida); 
    }
    private bool ValidarNome(string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            return false;

        }
        if(nome.Length < 3)
        {
            NomeErro = NomeInvalidoErroMsg;
            return false;
        }

        NomeErro = "";
        return true;

    }
    private bool ValidarEmail(string email) 
    {
        if (string.IsNullOrEmpty(email))
        {
            EmailErro = EmailVazioErroMsg;
            return false;
        }
        if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
        {
            EmailErro = EmailInvalidaoErroMsg;
            return false;
        }
        EmailErro = "";
        return true;
    }

    private bool ValidarTelefone(string telefone)
    {
        if(string.IsNullOrEmpty(telefone))
        {
            TelefoneErro = TelefoneVazioErroMsg;
            return false;
        }
        if (telefone.Length < 12)
        {
            TelefoneErro=TelefoneInvalidoErroMsg;
            return false;
        }
        TelefoneErro = "";
        return true;
    }
    private bool ValidarSenha(string senha)
    {
        if(string.IsNullOrEmpty (senha))
        {
            SenhaErro = SenhaVaziaErroMensagem;
            return false;
        }
        if (senha.Length < 8 || !Regex.IsMatch(senha, @"[a-zA-Z]") || !Regex.IsMatch(senha, @"\d"))
        {
            SenhaErro = SenhaInvalidaErroMensagem;
            return false;
        }
        SenhaErro = "";
        return true;
    }
}
