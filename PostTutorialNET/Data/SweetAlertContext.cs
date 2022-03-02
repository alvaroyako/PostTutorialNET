using Microsoft.EntityFrameworkCore;
using PostTutorialNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostTutorialNET.Data
{
    public class SweetAlertContext: DbContext
    {
        public SweetAlertContext(DbContextOptions<SweetAlertContext> options) : base(options) { }
        public DbSet<Juego> Juegos { get; set; }
    }
}
