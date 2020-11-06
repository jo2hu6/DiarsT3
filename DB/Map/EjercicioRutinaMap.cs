using DiarsT3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiarsT3.DB.Map
{
    public class EjercicioRutinaMap : IEntityTypeConfiguration<EjercicioRutina>
    {
        public void Configure(EntityTypeBuilder<EjercicioRutina> builder)
        {
            builder.ToTable("EjercicioRutina");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.Rutina).WithMany(o => o.EjercicioRutinas).HasForeignKey(o => o.RutinaId);
            builder.HasOne(o => o.Ejercicio).WithMany(o => o.EjercicioRutinas).HasForeignKey(o => o.EjercicioId);
        }
    }
}
