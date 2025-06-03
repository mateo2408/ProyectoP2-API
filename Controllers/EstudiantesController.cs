// Controllers/EstudiantesController.cs
using Microsoft.AspNetCore.Mvc;
using ProyectoP2.Models;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private static readonly List<Estudiante> estudiantes = new()
    {
        new Estudiante { Id = 1, Nombre = "Juan" },
        new Estudiante { Id = 2, Nombre = "Maria" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Estudiante>> Get() => estudiantes;
}