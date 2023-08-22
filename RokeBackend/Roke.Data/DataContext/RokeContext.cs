using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Roke.Core.Model;
using RokeBackend.Model;

namespace RokeBackend.data.DataContext
{
    public partial class RokeContext : DbContext
    {

        public RokeContext(DbContextOptions<RokeContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //if (!optionsBuilder.IsConfigured)
        //    //{
        //    //    optionsBuilder.UseSqlServer(cnnstr);
        //    //}
        //}

        public DbSet<user> users { get; set; }
        public DbSet<Ticket>tickets{get;set;}
     

    }
}
