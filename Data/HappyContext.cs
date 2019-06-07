using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Happy.Models;

    public class HappyContext : DbContext
    {
        public HappyContext (DbContextOptions<HappyContext> options)
            : base(options)
        {
        }

        public DbSet<Happy.Models.Categoria> Categoria { get; set; }
    }
