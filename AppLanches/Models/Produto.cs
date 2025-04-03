using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanches.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public string? Detalhe { get; set; }
        public string? UrlImagem { get; set; }
        public string? CaminhoImagem => AppConfig.BaseUrl + UrlImagem;
    }
}
