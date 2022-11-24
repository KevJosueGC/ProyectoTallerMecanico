using Microsoft.AspNetCore.Mvc;
using ProyectoTallerMecanico.Models;

namespace ProyectoTallerMecanico.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly TallerContext _context;
        public CategoriaController(TallerContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(this._context.Categoria.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);            

        }

        [HttpPost]
        public async Task<IActionResult> Editar(int? id, [Bind("IdCategoria","Nombre","Descripcion","Estatus")] Categoria categoria)
        {

            if (id != categoria.IdCategoria)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                _context.Update(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);            

        }

        public async Task<IActionResult> Eliminar(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);            

        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(int id)
        {
            var especialidad = _context.Categoria.Find(id);
            _context.Categoria.Remove(especialidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));    
        }
    }
}