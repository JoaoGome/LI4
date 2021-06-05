using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class Linguagem
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public string Designação {get; set;}
        public ICollection<Produto> Produtos {get; set;}
    }
}