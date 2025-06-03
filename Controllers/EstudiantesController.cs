using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasAcademicasApi.Data;
using NotasAcademicasApi.Models;

namespace NotasAcademicasApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly AppDbContext _context;
    public EstudiantesController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Estudiantes.ToListAsync());

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();
        return Ok(estudiante);
    }
}