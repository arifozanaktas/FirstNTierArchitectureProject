using FirstNTierArchitectureProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNTierArchitectureProject.DataAccess.Concrete.Context;
public class FirstNTierArchitectureContext : DbContext
{
    public FirstNTierArchitectureContext(DbContextOptions<FirstNTierArchitectureContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; }
    public DbSet<School> Schools { get; set;}
}
