using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Li4Fase3.Server;
using Li4Fase3.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Li4Fase3.Client.Controllers
{
    [ApiController]
    [Route("api/linguagem")]
    public class LinguagemController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LinguagemController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Linguagem>>> Get()
        {
            return await context.Linguagem.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Linguagem linguagem)
        {
            context.Add(linguagem);
            await context.SaveChangesAsync();
            return linguagem.Id;
        }

    }
}