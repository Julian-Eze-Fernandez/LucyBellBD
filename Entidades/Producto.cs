namespace LucyBellBD.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public List<DetalleCarrito> DetallesCarrito { get; set; }
        public List<VarianteProducto> VariantesProducto { get; set; }
        public List<Carrousel> Carrouseles { get; set; }
        public List<DetallePedido> DetallesPedido { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int SubCategoriaId { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }

    }
}
