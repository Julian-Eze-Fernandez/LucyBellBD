using LucyBellBD.DTOs.ProductosDTOs;
using LucyBellBD.DTOs.SubCategoriasDTOs;

namespace LucyBellBD.DTOs.CategoriaDTO
{
	public class CategoriaDTO
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
        public List<SubCategoriaDTO> SubCategorias { get; set; }
        public List<ProductoDTO> Productos { get; set; }
    }
}
