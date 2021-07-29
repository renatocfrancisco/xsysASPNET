using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XSYSDesafioProduto.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Coloque um nome/Descreva o Produto")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Quantos tem no estoque?")]

        public int Estoque { get; set; }

        [Required(ErrorMessage = "Insira um preço!")]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }
    }
}
