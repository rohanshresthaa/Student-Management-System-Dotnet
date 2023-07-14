
using Microsoft.EntityFrameworkCore;

namespace Student_Management_System.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> context):base(context) 
        {
            
        }
        public DbSet<SignUp> signUps { get; set; }
    }
}
