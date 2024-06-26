using AutoMapper;
using LucyBellBD.DTOs;
using LucyBellBD.Entidades;

namespace LucyBellBD.Utilidades
{
	public class AutoMapperProfiles: Profile
	{
        public AutoMapperProfiles()
        {
			//Para mappear va priemro la Fuente y luego el Destino
			//CreateMap<Fuente, Destino>();

			CreateMap<CategoriaCreacionDTO, Categoria>(); //Mapeo para POST
			CreateMap<Categoria, CategoriaDTO>(); //Mapeo para Get
			CreateMap<SubCategoriaCreacionDTO, SubCategoria>(); //Mapeo para POST
			CreateMap<SubCategoria, SubCategoriaDTO>(); //Mapeo para Get
		}
    }
}
