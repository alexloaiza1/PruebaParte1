using Microsoft.EntityFrameworkCore;
using PruebaPart1.Models;
using System;

namespace PruebaPart1.Data
{
    public class AppDBContex : DbContext
    {
        public AppDBContex(DbContextOptions<AppDBContex>  options) : base(options)
        {
        }
        public DbSet<Persona_client>? Persona_cliente { get; set; }
    }
}
