using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactStudent
{
    public class ContactStudentDbContext:DbContext
    {
        public ContactStudentDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<GetStudent> Employees { get; set; }
    }
}
