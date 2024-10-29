using System.Diagnostics;
using DropDownsAnidadosMVC.Data;
using Microsoft.AspNetCore.Mvc;
using DropDownsAnidadosMVC.Models;

namespace DropDownsAnidadosMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var sucursales = _context.Sucursal.ToList();
        
        var viewModel = new DropDownVM
        {
            Sucursales = sucursales
        };
        
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public JsonResult ObtenerCategorias(int sucursalId)
    {
        var categorias = _context.Categoria.Where(c => c.SucursalId == sucursalId).ToList();

        return Json(categorias);
    }

    [HttpGet]
    public JsonResult ObtenerProductos(int categoriaId)
    {
        var productos = _context.Producto.Where(c => c.CategoriaId == categoriaId).ToList();

        return Json(productos);
    }
}