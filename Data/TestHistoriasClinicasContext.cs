using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestHistoriasClinicas.Models;

namespace TestHistoriasClinicas.Data
{
    public class TestHistoriasClinicasContext : DbContext
    {
        public TestHistoriasClinicasContext(DbContextOptions<TestHistoriasClinicasContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Episodio> Episodios { get; set; }
        public DbSet<Epicrisis> Epicrisis { get; set; }
        public DbSet<Evolucion> Evoluciones { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        //public DbSet<Persona> Persona { get; set; }
        /*public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Episodio> Episodios { get; set; }

        public DbSet<Epicrisis> Epicrisis { get; set; }
        public DbSet<Evolucion> Evoluciones { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        */
    }
}
