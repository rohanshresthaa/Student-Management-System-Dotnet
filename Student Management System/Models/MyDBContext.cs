
using Microsoft.EntityFrameworkCore;

namespace Student_Management_System.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> context):base(context) 
        {
            
        }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Level> Levels { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentRegistration> StudentRegistrations { get; set;}
        public DbSet<Attendence> Attendances { get; set; }
        public DbSet<AttendenceDetail> AttendenceDetails { get; set; }
    }
}
