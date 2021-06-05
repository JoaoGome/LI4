using System;
using System.Collections.Generic;
using System.Text;
using Li4Fase3.Shared.Entities;

namespace Li4Fase3.Shared.DTOs
{
    public class ProdutoDetailsDTO
    {

        public Produto Produto { get; set; }
        public string Condicao { get; set; }
        public string Expansao { get; set; }
        public string Linguagem { get; set; }
    }
}
