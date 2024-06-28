using LucyBellBD.DTOs.ProductosDTOs;

namespace LucyBellBD.DTOs.SubCategoriasDTOs
{
	public class SubCategoriaDTO
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
        public List<ProductoDTO> Productos { get; set; }
    }
}
