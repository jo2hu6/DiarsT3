using DiarsT3.DB.Map;
using DiarsT3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.DB.Context
{
    public class DiarsT3Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<EjercicioRutina> EjercicioRutinas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JOSUERIVERA\\SQLEXPRESS;Database=DiarsT3;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EjercicioMap());
            modelBuilder.ApplyConfiguration(new RutinaMap());
            modelBuilder.ApplyConfiguration(new EjercicioRutinaMap());
        }
    }
}
