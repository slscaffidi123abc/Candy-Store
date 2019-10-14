using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candy_Store.Data;

namespace Candy_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candy_Store.Data.Manufacturers> Manufacturers { get; set; }
        public DbSet<Candy_Store.Data.Candy> Candy { get; set; }
        public DbSet<Candy_Store.Data.Store> Store { get; set; }
    }
}
