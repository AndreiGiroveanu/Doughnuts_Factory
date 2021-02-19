using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoughnutsFactory.Models;

namespace DoughnutsFactory.Data
{
    public class DoughnutsFactoryContext : DbContext
    {
        public DoughnutsFactoryContext(DbContextOptions<DoughnutsFactoryContext> options)
            : base(options)
        {
        }

        public DbSet<DoughnutsFactory.Models.Doughnut> Doughnuts { get; set; }
    }
}