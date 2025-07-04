using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace student_portal.Models.Entities
{
    public class Student
    {
        // Property
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}
