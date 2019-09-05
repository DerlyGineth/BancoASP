using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoGL.Models;
using AppWebProductosCF.Models;

    public class BancoGLContext : DbContext
    {
        public BancoGLContext (DbContextOptions<BancoGLContext> options)
            : base(options)
        {
        }

        public DbSet<BancoGL.Models.Categoria> Categoria { get; set; }

        public DbSet<AppWebProductosCF.Models.Producto> Producto { get; set; }
    }
