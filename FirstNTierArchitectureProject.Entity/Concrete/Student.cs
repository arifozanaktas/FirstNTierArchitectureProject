using FirstNTierArchitectureProject.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNTierArchitectureProject.Entity.Concrete;
public class Student : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Identity { get; set; }
    public DateTime? BirthDate { get; set; }
}
