namespace DropDownsAnidadosMVC.Models;

public class Producto
{
    public int Id { get; set; }
    
    public string Nombre { get; set; }
    
    public double Precio { get; set; }
    
    // FK
    public int CategoriaId { get; set; }
    
    // Propiedad de navegacion
    public Categoria Categoria { get; set; }
}