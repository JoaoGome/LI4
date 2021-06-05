using System;
using System.Collections.Generic;
using System.Text;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Shared.DTOs
{
    public class VendasDetailsDTO
    {

        public Venda Venda { get; set; }
        public string Produto { get; set; }
        public string Condicao { get; set; }
        public string Expansao { get; set; }
        public string Linguagem { get; set; }
        public string Vendedor { get; set; }
        public string VendedorLocal { get; set; }


    }
}
