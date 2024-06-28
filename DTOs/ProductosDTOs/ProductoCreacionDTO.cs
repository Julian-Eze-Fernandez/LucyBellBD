﻿using LucyBellBD.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace LucyBellBD.DTOs.ProductosDTOs
{
	public class ProductoCreacionDTO
	{
		[Required(ErrorMessage = "El campo {0} es requerido")]
		[StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe tener más de {1} carácteres")]
		[PrimeraLetraMayuscula]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "El campo {0} es requerido")]
		public decimal Precio { get; set; }
		public string Descripcion { get; set; }
	}
}
