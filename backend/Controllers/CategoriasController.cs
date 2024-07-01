using AutoMapper;
using LucyBellBD.DTOs;
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
		private readonly IMapper mapper;

		public CategoriasController(ApplicationDbContext context, IMapper mapper)
		{
			this.context = context;
			this.mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoriaDTO>>> Get()
		{
			var categorias = await context.Categorias.ToListAsync();
			return mapper.Map<List<CategoriaDTO>>(categorias);
		}
		
		[HttpGet("{id:int}")]
		public async Task<ActionResult<CategoriaDTO>> Get(int id)
		{
			var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.Id == id);

			if (categoria == null)
			{
				return NotFound();
			}

			return mapper.Map<CategoriaDTO>(categoria);
		}

		[HttpPost]
		public async Task<ActionResult> Post(CategoriaCreacionDTO categoriaCreacionDTO)
		{
			var existeCategoriaConElMismoNombre = await context.Categorias.AnyAsync(x => x.Nombre == categoriaCreacionDTO.Nombre);

			if (existeCategoriaConElMismoNombre)
			{
				return BadRequest($"Ya existe una categoria con el nombre {categoriaCreacionDTO.Nombre}");
			}

			var categoria = mapper.Map<Categoria>(categoriaCreacionDTO);

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
