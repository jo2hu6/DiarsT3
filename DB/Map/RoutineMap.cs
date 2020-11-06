using DiarsT3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiarsT3.DB.Map
{
    public class RoutineMap : IEntityTypeConfiguration<Routine>
    {
        public void Configure(EntityTypeBuilder<Routine> builder)
        {
            builder.ToTable("Routine");
            builder.HasKey(o => o.Id);
            builder.HasMany(o => o.EjercicioRutinas).WithOne(o => o.Rutina).HasForeignKey(o => o.RutinaId);
        }
    }
}
