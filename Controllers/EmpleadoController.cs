using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            return PartialView("_PartialViewCrearEmpleado", nEmpleado);
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        public ActionResult Create(Empleado nuevoEmpleado)
        {
            if (ModelState.IsValid)
            {
                dbConnection.Add(nuevoEmpleado);
                dbConnection.SaveChanges();
            }
			return PartialView("_PartialViewCrearEmpleado", nuevoEmpleado);
			/*try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }*/
		}

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            Empleado empleado = dbConnection.Empleado.FirstOrDefault(e => e.IdEmpleado == id);
            return PartialView("_PartialViewEditarEmpleado", empleado);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        public ActionResult Edit(Empleado editEmpleado)
        {
            if (ModelState.IsValid)
            {
                dbConnection.Update(editEmpleado); 
                dbConnection.SaveChanges();
            }
            return PartialView("_PartialViewEditarEmpleado", editEmpleado);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var empleado = dbConnection.Empleado.FirstOrDefault(e =>e.IdEmpleado == id);
            if (empleado != null)
            {
                empleado.Estatus= 0;
                dbConnection.Update(empleado);
                dbConnection.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
