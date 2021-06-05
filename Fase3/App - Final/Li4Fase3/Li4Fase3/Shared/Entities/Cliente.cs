using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class Cliente
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "This field is required")]

        public string Nome {get; set;}
        public string Email {get; set;}
        public string Telemovel {get; set;}
        public string Password {get; set;}
        public ICollection<Aviso> Avisos {get; set;}
    }
}