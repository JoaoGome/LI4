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
    [Route("api/produto")]
    public class ProdutoController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProdutoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            return await context.Produto.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDetailsDTO>> Get(int id)
        {

            var produto = await context.Produto.Where(x => x.Id == id)
                                                .Include(x => x.Condicao)
                                                .Include(x => x.Expansao)
                                                .Include(x => x.Linguagem)
                                                .FirstOrDefaultAsync();

            if (produto == null) { return NotFound(); }

            var model = new ProdutoDetailsDTO();
            model.Produto = produto;
            model.Condicao = produto.Condicao.Designação;
            model.Expansao = produto.Expansao.Designação;
            model.Linguagem = produto.Linguagem.Designação;

            return model;

        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Produto produto)
        {
            context.Add(produto);
            await context.SaveChangesAsync();
            return produto.Id;
        }

    }
}

