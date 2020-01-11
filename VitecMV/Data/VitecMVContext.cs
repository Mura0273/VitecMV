using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VitecMV.Models;

namespace VitecMV.Data
{
    public class VitecMVContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public VitecMVContext(DbContextOptions<VitecMVContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
