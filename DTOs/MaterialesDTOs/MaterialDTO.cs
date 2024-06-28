using LucyBellBD.DTOs.ProductosDTOs;

namespace LucyBellBD.DTOs.MaterialesDTOs
{
	public class MaterialDTO
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
        public List<ProductoDTO> Productos { get; set; }
    }
}
