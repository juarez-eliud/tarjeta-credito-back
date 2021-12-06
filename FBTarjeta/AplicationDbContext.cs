using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FBTarjeta.Models;

namespace FBTarjeta
{
    public class AplicationDbContext : DbContext
    {

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }      

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
