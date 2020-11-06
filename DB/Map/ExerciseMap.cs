using DiarsT3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsT3.DB.Map
{
    public class ExerciseMap : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercise");
            builder.HasKey(o => o.Id);
            builder.HasMany(o => o.EjercicioRutinas).WithOne(o => o.Ejercicio).HasForeignKey(o => o.EjercicioId);
        }
    }
}
