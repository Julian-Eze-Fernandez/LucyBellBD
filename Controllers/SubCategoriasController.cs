using LucyBellBD.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LucyBellBD.Controllers
{
	[ApiController]
	[Route ("api/subCategorias")]
	public class SubCategoriasController : ControllerBase
	{
		private readonly ApplicationDbContext context;

		public SubCategoriasController(ApplicationDbContext context)
        {
			this.context = context;
		}

		[HttpGet("(id:int)")]
		public async Task<ActionResult<SubCategoria>> Get(int id)
		{
			return await context.SubCategorias.Include(x => x.Categoria).FirstOrDefaultAsync(x => x.Id == id);
		}

		[HttpPost]
		public async Task<ActionResult> Post(SubCategoria subCategoria)
		{
			var existeCategoria = await context.Categorias.AnyAsync(x => x.Id == subCategoria.CategoriaId);

			if (!existeCategoria) 
			{
				return BadRequest($"No existe la Categoria de Id: {subCategoria.CategoriaId}");
			}

			context.Add(subCategoria);
			await context.SaveChangesAsync();
			return Ok();
		}
	}
}
