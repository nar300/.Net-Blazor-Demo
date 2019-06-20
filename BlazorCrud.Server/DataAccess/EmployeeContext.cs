using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
  
        public class EmployeeContext : DbContext
        {
            public virtual DbSet<Employee> tblEmployee { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"server=LOTUS\SQLEXPRESS;database=EmployeeNDB;integrated security=true;");
                }
            }
        }
    }

