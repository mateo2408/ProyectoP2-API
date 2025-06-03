// Models/NotaAcademica.cs
namespace ProyectoP2.Models;

public class NotaAcademica
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    public string Materia { get; set; }
    public double Nota { get; set; }
}