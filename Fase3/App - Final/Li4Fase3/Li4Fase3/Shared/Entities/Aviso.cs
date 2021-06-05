using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class Aviso
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public double Preço {get; set;}

        public String metodo {get;set;}
        public Cliente Cliente {get; set;}
        public Produto Produto {get; set;}
    }
}