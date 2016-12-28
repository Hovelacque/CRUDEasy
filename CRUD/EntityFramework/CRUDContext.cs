using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.EntityFramework
{
    public class CRUDContext : DbContext
    {

        public CRUDContext() : base("Default")
        {
        }

        public DbSet<Programador> Programadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}