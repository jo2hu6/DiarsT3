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
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Exercise> Ejercicios { get; set; }
        public DbSet<Routine> Rutinas { get; set; }
        public DbSet<ExerciseRoutine> EjercicioRutinas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JOSUERIVERA\\SQLEXPRESS;Database=DiarsT3;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ExerciseMap());
            modelBuilder.ApplyConfiguration(new RoutineMap());
            modelBuilder.ApplyConfiguration(new ExerciseRoutineMap());
        }
    }
}
