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
    [Route("api/expansao")]
    public class ExpansaoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ExpansaoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Expansao>>> Get()
        {
            return await context.Expansao.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post (Expansao expansao)
        {
            context.Add(expansao);
            await context.SaveChangesAsync();
            return expansao.Id;
        }

    }
}