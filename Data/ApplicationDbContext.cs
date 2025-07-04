using Microsoft.EntityFrameworkCore;
using student_portal.Models.Entities;



namespace student_portal.Data
{

    public class ApplicationDbContext : DbContext
    {
        // Use for Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        // Creating a property as a DB_set

        //public collection_type<_type_> Table_name { get; set; }

        public DbSet<Student>Students { get; set; }

    }

    
    
}
