using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persona.Models;

namespace Persona.Controllers
{
    public class PersonaController : Controller
    {
        private PersonaContext _context;
        public PersonaController(PersonaContext context)
        {
            _context = context;

        }
        [HttpGet]
        public ActionResult Index()
        {
            var personas = _context.Personas.ToList();
            var model = _context.Personas.Include(o => o.NomCiudad).ToList();
            return View(personas);
        }

        [HttpGet]
        public ActionResult Create() // GET
        {
            ViewBag.Ciudades = _context.Ciudades.ToList();
            return View("Create", new Personas());
        }
        [HttpPost]
        public ActionResult Create(Personas persona) // POST
        {

            if (!ModelState.IsValid)
            {
                ViewBag.Ciudades = _context.Ciudades.ToList();
                return View(persona);
            }
            _context.Personas.Add(persona);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Personas = new List<string> { "Nombre", "Apellido", "FechaNac", "Dni", "Genero", "Ciudad", "Direccion", "Correo", "UserName", "Contrasena" };
            ViewBag.Ciudades = _context.Ciudades.ToList();
            var persona = _context.Personas.Where(o => o.Id == id).FirstOrDefault();

            return View("Edit", persona);
        }

        [HttpPost]
        public ActionResult Edit(Personas persona)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Ciudades = _context.Ciudades.ToList();
                _context.Personas.Update(persona);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Product = persona;
            return View("Edit");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var persona = _context.Personas.Where(o => o.Id == id).FirstOrDefault();
            _context.Personas.Remove(persona);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
