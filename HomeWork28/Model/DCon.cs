using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork28.Model
{
    public class DCon : DbContext
    {
        public DCon(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Frazi> Frazes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Frazi>().HasData(new Frazi() { Id = 1, Text = "Vsyo Menyaetsya", Author = "Hurshed", Date = DateTime.Parse("30.05.2020") },
                                                    new Frazi() { Id = 2, Text = "Ploxo sojelet o tom chto ne tak jil", Author = "Payrav", Date = DateTime.Parse("30.05.2020") },
                                                    new Frazi() { Id = 3, Text = "Vigral grin kartu", Author = "Firdavs", Date = DateTime.Parse("30.05.2020") },
                                                    new Frazi() { Id = 4, Text = "Vzlom wifi", Author = "Shahzod", Date = DateTime.Parse("30.05.2020") },
                                                    new Frazi() { Id = 5, Text = "Jivi dolgo", Author = "Karim", Date = DateTime.Parse("30.05.2020") });
        }

    }
}
