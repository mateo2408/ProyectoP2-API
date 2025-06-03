using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasAcademicasApi.Data;
using NotasAcademicasApi.Models;

namespace NotasAcademicasApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotasController : ControllerBase
{
    private readonly AppDbContext _context;
    public NotasController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Notas.ToListAsync());

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] NotaAcademica nota)
    {
        _context.Notas.Add(nota);
        await _context.SaveChangesAsync();
        return Ok(nota);
    }
}