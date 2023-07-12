using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data;
public class DiagramaCitasContext : DbContext{
    public DiagramaCitasContext(DbContextOptions<DiagramaCitasContext> options) : base (options){
        
    }
    public DbSet<Usuario> ? Usuarios { get; set; }
    public DbSet<Medico> ? Medicos { get; set; }
    public DbSet<Genero> ? Generos { get; set;}
    public DbSet<GeneroUser> ? Datos { get; set; }
    public DbSet<Especialidad> ? Especialidades { get; set;}
    public DbSet<Estado> ? Estados { get; set; }
    public DbSet<EstadoCita> ? Consulta { get; set; }
    public DbSet<Consultorio> ? Consultorios { get; set; }
    public DbSet<Cita> ? Citas { get; set; }
    public DbSet<CitaUser> ? Consultas { get; set;}
    public DbSet<Acudiente> ? Acudientes { get; set;}
    public DbSet<AcudienteUser> ? Contactos { get; set; }

}
