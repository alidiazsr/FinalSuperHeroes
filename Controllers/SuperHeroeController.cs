using FinalSuperHeroes.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalSuperHeroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroeController : Controller
    {
        [HttpGet("crear")]
        public ActionResult CrearSuperheroe(string nombre, string tipo)
        {
            ISuperHeroe superheroe;
            try
            {
                superheroe = SuperHeroeFactory.CrearSuperheroe(nombre, tipo);
            }
            catch (ArgumentException)
            {
                return BadRequest("Tipo de Héroe no encontrado.");
            }
            return Ok(new
            {
                Nombre = superheroe.Nombre,
                PoderEspecial = superheroe.PoderEspecial,
                Fuerza = superheroe.Fuerza,
                Salud = superheroe.Salud
            });
        }

        [HttpGet("visitasAenfermeria")]
        public ActionResult VisitasAEnfermeria(string tipo, int saludActual, int cantidadVisitas)
        {
            if (cantidadVisitas < 1 || cantidadVisitas > 5)
            {
                return BadRequest("Las visitas deben ser entre 1 y 5.");
            }
            if (saludActual < 0 || saludActual > 5)
            {
                return BadRequest("La salud debe estar entre 0 y 5.");
            }

            if (string.IsNullOrEmpty(tipo))
            {
                return BadRequest("Es obligatorio incluir el tipo de superhéroe.");
            }

            var enfermeria = Enfermeria.ObtenerInstancia();

            bool atencion = enfermeria.VisitasAEnfermeria(ref saludActual, cantidadVisitas);

            if (atencion)
            {
                return Ok(new { Salud = saludActual });
            }
            else
            {
                return BadRequest("Cupo de visitas a la enfermería alcanzado.");
            }
        }
    }
}


       