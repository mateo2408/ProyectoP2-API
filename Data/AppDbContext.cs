using Microsoft.EntityFrameworkCore;
using NotasAcademicasApi.Models;

namespace NotasAcademicasApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<NotaAcademica> Notas { get; set; }
}