using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Li4Fase3.Server;
using Li4Fase3.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Li4Fase3.Shared.DTOs;

namespace Li4Fase3.Client.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public VendasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VendasDetailsDTO>>> Get()
        {
            List<VendasDetailsDTO> vendas = new List<VendasDetailsDTO>();
            var listModels = await context.Venda.Include(x => x.Produto).ThenInclude(x => x.Condicao)
                                                .Include(x => x.Produto).ThenInclude(x => x.Expansao)
                                                .Include(x => x.Produto).ThenInclude(x => x.Linguagem)
                                                .Include(x => x.Vendedor).ThenInclude(x => x.Localizacao)
                                                .Take(15)
                                                .ToListAsync();


            for (int i = 0; i < listModels.Count(); i++)
            {
                var model = new VendasDetailsDTO();
                model.Venda = listModels[i];
                model.Produto = listModels[i].Produto.Nome;
                model.Condicao = listModels[i].Produto.Condicao.Designação;
                model.Expansao = listModels[i].Produto.Expansao.Designação;
                model.Linguagem = listModels[i].Produto.Linguagem.Designação;
                model.Vendedor = listModels[i].Vendedor.Nome;
                model.VendedorLocal = listModels[i].Vendedor.Localizacao.Designação;

                vendas.Add(model);
            }

            return vendas;
        }

        [HttpGet("{venda}")]
        public async Task<ActionResult<List<VendasDetailsDTO>>> Get(string venda)
        {
            string[] splitted = venda.Split('_');
            
            List<VendasDetailsDTO> vendas = new List<VendasDetailsDTO>();
            var listModels = await context.Venda.Where(x => (splitted[0] == " " || x.Produto.Nome == splitted[0]) &&
                                                            (splitted[1] == " " || x.Produto.Condicao.Designação == splitted[1]) &&
                                                            (splitted[2] == " " || x.Produto.Expansao.Designação == splitted[2]) &&
                                                            (splitted[3] == " " || x.Produto.Linguagem.Designação == splitted[3]) &&
                                                            (splitted[4] == " " || x.Vendedor.Localizacao.Designação == splitted[4]) &&
                                                            x.Preço <= Convert.ToDouble(splitted[5]))
                                                .Include(x => x.Produto).ThenInclude(x => x.Condicao)
                                                .Include(x => x.Produto).ThenInclude(x => x.Expansao)
                                                .Include(x => x.Produto).ThenInclude(x => x.Linguagem)
                                                .Include(x => x.Vendedor).ThenInclude(x => x.Localizacao)
                                                .Take(15)
                                                .ToListAsync();


            for (int i = 0; i < listModels.Count(); i++)
            {
                var model = new VendasDetailsDTO();
                model.Venda = listModels[i];
                model.Produto = listModels[i].Produto.Nome;
                model.Condicao = listModels[i].Produto.Condicao.Designação;
                model.Expansao = listModels[i].Produto.Expansao.Designação;
                model.Linguagem = listModels[i].Produto.Linguagem.Designação;
                model.Vendedor = listModels[i].Vendedor.Nome;
                model.VendedorLocal = listModels[i].Vendedor.Localizacao.Designação;

                vendas.Add(model);
            }

            return vendas;

        }
    }
}