namespace DropDownsAnidadosMVC.Models;

public class Categoria
{
    public int Id { get; set; }
    
    public string Nombre { get; set; }
    
    // FK
    public int SucursalId { get; set; }
    
    // Propiedad de navegacion
    public Sucursal Sucursal { get; set; }
    
    // Relacion 1:N
    public ICollection<Producto> Productos { get; set; }
}