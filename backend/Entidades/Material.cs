namespace LucyBellBD.Entidades
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
