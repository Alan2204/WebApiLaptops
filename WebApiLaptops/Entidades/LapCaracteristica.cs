namespace WebApiLaptops.Entidades
{
    public class LapCaracteristica
    {
        public int LapId { get; set; }
        public int ModeloId { get; set; }
        public Laptop Laptop { get; set; }
        public Caracteristicas Caracteristicas { get; set; }
    }
}
