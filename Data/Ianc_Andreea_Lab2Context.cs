using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ianc_Andreea_Lab2.Models;

namespace Ianc_Andreea_Lab2.Data
{
    public class Ianc_Andreea_Lab2Context : DbContext
    {
        public Ianc_Andreea_Lab2Context (DbContextOptions<Ianc_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ianc_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ianc_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ianc_Andreea_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Ianc_Andreea_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Ianc_Andreea_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Ianc_Andreea_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
