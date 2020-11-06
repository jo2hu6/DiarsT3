using DiarsT3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiarsT3.DB.Map
{
    public class RutinaMap : IEntityTypeConfiguration<Rutina>
    {
        public void Configure(EntityTypeBuilder<Rutina> builder)
        {
            builder.ToTable("Rutina");
            builder.HasKey(o => o.Id);
            builder.HasMany(o => o.EjercicioRutinas).WithOne(o => o.Rutina).HasForeignKey(o => o.RutinaId);
        }
    }
}
