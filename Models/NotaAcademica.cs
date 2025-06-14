using System;

namespace NotasAcademicasApi.Models;

public class NotaAcademica
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public DateTime Fecha { get; set; }
    public int EstudianteId { get; set; }
    public int MateriaId { get; set; }
    public double Calificacion { get; set; }
    public DateTime FechaEvaluacion { get; set; }
}