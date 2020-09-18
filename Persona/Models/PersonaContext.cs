using Microsoft.EntityFrameworkCore;
using Persona.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Models
{
    public class PersonaContext : DbContext
    {
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Personas> Personas { get; set; }

        public PersonaContext(DbContextOptions<PersonaContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new CiudadMap());
        }
    }
}
