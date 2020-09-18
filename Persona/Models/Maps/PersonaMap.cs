using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Models.Maps
{
    public class PersonaMap : IEntityTypeConfiguration<Personas>
    {
        public void Configure(EntityTypeBuilder<Personas> builder)
        {
            builder.ToTable("Personas");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.NomCiudad).WithMany().HasForeignKey(o => o.Ciudad);
        }
    }
}
