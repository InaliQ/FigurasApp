using FigApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FigApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosDbContext _context;

        public ProductosController(ProductosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("ListaProductos")]
        public async Task<IActionResult> Lista() {
            var productos = await _context.Productos.ToArrayAsync();
            return Ok(productos);
        }
    }
}
