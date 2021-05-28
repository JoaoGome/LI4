using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LI4.Shared.Entities
{
    public class Vendedor
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public string Nome {get; set;}
        public string Email {get; set;}

        public Localizacao Localizacao {get; set;}

        public ICollection<Venda> Vendas {get; set;}
        
    }
}