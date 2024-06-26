using AutoMapper;
using LucyBellBD.DTOs;
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
		private readonly IMapper mapper;

		public SubCategoriasController(ApplicationDbContext context, IMapper mapper)
        {
			this.context = context;
			this.mapper = mapper;
		}

		[HttpGet("(id:int)")]
		public async Task<ActionResult<SubCategoriaDTO>> Get(int id)
		{
			var subcategoria = await context.SubCategorias.FirstOrDefaultAsync(x => x.Id == id);
			return mapper.Map<SubCategoriaDTO>(subcategoria);
		}

		[HttpPost]
		public async Task<ActionResult> Post(SubCategoriaCreacionDTO subCategoriaCreacionDTO)
		{
			//var existeCategoria = await context.Categorias.AnyAsync(x => x.Id == subCategoriaCreacionDTO.CategoriaId);

			//if (!existeCategoria) 
			//{
			//	return BadRequest($"No existe la Categoria de Id: {subCategoriaCreacionDTO.CategoriaId}");
			//}

			var subCategoria = mapper.Map<Categoria>(subCategoriaCreacionDTO);

			context.Add(subCategoria);
			await context.SaveChangesAsync();
			return Ok();
		}
	}
}
