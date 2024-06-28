using AutoMapper;
using LucyBellBD.DTOs;
using LucyBellBD.DTOs.CategoriaDTO;
using LucyBellBD.DTOs.MaterialesDTOs;
using LucyBellBD.DTOs.ProductosDTOs;
using LucyBellBD.DTOs.SubCategoriasDTOs;
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
			CreateMap<Categoria, CategoriaDTO>(); //Mapeo para GET
			CreateMap<SubCategoriaCreacionDTO, SubCategoria>(); //Mapeo para POST
			CreateMap<SubCategoria, SubCategoriaDTO>(); //Mapeo para GET
			CreateMap<MaterialCreacionDTO, Material>(); //Mapeo para POST
			CreateMap<Material, MaterialDTO>(); //Mapeo para GET
			CreateMap<ProductoCreacionDTO, Producto>(); //Mapeo para POST
			CreateMap<Producto, ProductoDTO>(); //Mapeo para GET
		}
    }
}
