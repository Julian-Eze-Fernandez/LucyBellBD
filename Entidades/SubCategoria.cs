namespace LucyBellBD.Entidades
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<Producto> Porductos { get; set; }

    }
}
