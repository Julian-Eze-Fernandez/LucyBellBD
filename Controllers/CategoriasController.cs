using LucyBellBD.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LucyBellBD.Controllers
{
	[ApiController]
	[Route("api/categorias")]
	public class CategoriasController : ControllerBase
	{
		private readonly ApplicationDbContext context;

		public CategoriasController(ApplicationDbContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<Categoria>>> Get()
		{
			return await context.Categorias.Include(x => x.SubCategorias).ToListAsync();
		}

		[HttpGet("{id:int}")]
		public async Task<ActionResult<Categoria>> Get(int id)
		{
			var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);

			if (categoria == null)
			{
				return NotFound();
			}

			return categoria;
		}

		[HttpPost]
		public async Task<ActionResult> Post(Categoria categoria)
		{
			var existeCategoriaConElMismoNombre = await context.Categorias.AnyAsync(x => x.Nombre == categoria.Nombre);

			if (existeCategoriaConElMismoNombre)
			{
				return BadRequest($"Ya existe una categoria con el nombre {categoria.Nombre}");
			}

			context.Add(categoria);
			await context.SaveChangesAsync();
			return Ok();
		}

		[HttpPut("(id:int)")]
		public async Task<ActionResult> Put(Categoria categoria, int id)
		{
			if (categoria.Id != id)
			{
				return BadRequest("El id de la categoria no coincide con el id del URL");
			}

			var existe = await context.Categorias.AnyAsync(x => x.Id == id);

			if (!existe)
			{
				return NotFound();
			}

			context.Update(categoria);
			await context.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete("(id:int)")]
		public async Task<ActionResult> Delete(int id)
		{
			var existe = await context.Categorias.AnyAsync(x => x.Id == id);

			if (!existe)
			{
				return NotFound();
			}

			context.Remove(new Categoria() { Id = id });
			await context.SaveChangesAsync();
			return Ok();
		}
	}
}
