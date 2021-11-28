using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arseni_Teodora_Madalina_Lab8.Models;

namespace Arseni_Teodora_Madalina_Lab8.Data
{
    public class Arseni_Teodora_Madalina_Lab8Context : DbContext
    {
        public Arseni_Teodora_Madalina_Lab8Context (DbContextOptions<Arseni_Teodora_Madalina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Arseni_Teodora_Madalina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Arseni_Teodora_Madalina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Arseni_Teodora_Madalina_Lab8.Models.Category> Category { get; set; }
    }
}
