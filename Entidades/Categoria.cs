namespace LucyBellBD.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
        public List<SubCategoria> SubCategorias { get; set; }
    }
}
