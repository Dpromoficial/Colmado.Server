namespace Colmado.Server.Database
{
    public class ListaProducto
    {
        public long EAN_Producto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal TotalArticulo => Cantidad * Precio;
    }
}
