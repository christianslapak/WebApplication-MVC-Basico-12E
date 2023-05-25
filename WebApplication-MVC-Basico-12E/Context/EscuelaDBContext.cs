using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_MVC_Basico_12E.Models;

namespace WebApplication_MVC_Basico_12E.Context
{
    public class EscuelaDBContext : DbContext
    {
        public EscuelaDBContext(DbContextOptions<EscuelaDBContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
