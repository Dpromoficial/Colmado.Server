namespace Colmado.Server.Database
{
    public class VentasCls
    {
        public int IdVenta  { get; set; }
        public long EAN_Producto  { get; set; }
        public string Nombre { get; set; }
        public int Cantidad  { get; set; }
        public decimal Precio  { get; set; }
        public decimal SubTotal  { get; set; }
        public decimal Total  { get; set; }
        public decimal TotalArticulo  { get; set; }
        

    }
}
