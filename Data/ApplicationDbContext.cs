using Microsoft.EntityFrameworkCore;


namespace student_portal.Data
{

    public class ApplicationDbContext : DbContext
    {
        // Use for Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

    }

    
    
}
