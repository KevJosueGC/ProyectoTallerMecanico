using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoTallerMecanico.Models;

namespace ProyectoTallerMecanico.Controllers
{
    public class EmpleadoController : Controller
    {
        // Realizar conexion a base de datos.
        private readonly TallerContext dbConnection;

        public EmpleadoController(TallerContext conexion)
        {
            this.dbConnection = conexion;
        }
        // GET: EmpleadoController
        public ActionResult Index()
        { 
            return View(dbConnection.Empleado.ToList());
        }

        // GET: EmpleadoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            Empleado nEmpleado = new Empleado();
            return PartialView("_PartialViewCrearEmpleado",nEmpleado);
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
