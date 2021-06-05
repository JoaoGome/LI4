using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class Venda
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public double Preço {get; set;}
        public DateTime Data {get; set;}
        public string Notas {get; set;}
        public Vendedor Vendedor {get; set;}
        public Produto Produto {get; set;}
    }
}