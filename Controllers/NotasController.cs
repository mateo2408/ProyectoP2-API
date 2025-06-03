// Controllers/NotasController.cs
using Microsoft.AspNetCore.Mvc;
using ProyectoP2.Models;

[ApiController]
[Route("api/[controller]")]
public class NotasController : ControllerBase
{
    private static readonly List<NotaAcademica> notas = new()
    {
        new NotaAcademica { Id = 1, EstudianteId = 1, Materia = "Matemáticas", Nota = 9.5 },
        new NotaAcademica { Id = 2, EstudianteId = 2, Materia = "Historia", Nota = 8.0 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<NotaAcademica>> Get() => notas;
}