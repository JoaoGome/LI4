using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Li4Fase3.Shared.Entities
{
    public class VendaForm
    {
        public double Preço { get; set; }
        public string Produto{ get; set; }
        public string Condicao { get; set; }
        public string Expansao{ get; set; }
        public string Linguagem { get; set; }
        public string Localizacao { get; set; }
    }
}