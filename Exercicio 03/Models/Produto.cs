using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicio_03.Models
{
    public class Produto
    {
        public DateTime DataCadastro { get; set; }

        public decimal Valor { get; set; }

        public int ProdutoId { get; set; }

        public bool Nacional { get; set; }

        public string Descricao { get; set; }

        public string Titulo { get; set; }
    }
}