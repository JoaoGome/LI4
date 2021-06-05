using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class Produto
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public string Nome {get; set;}

        public Condicao Condicao {get; set;}
        public Expansao Expansao {get; set;}
        public Linguagem Linguagem {get; set;}
        public ICollection<Venda> Vendas {get; set;}
        public ICollection<Aviso> Avisos {get; set;}
    }
}