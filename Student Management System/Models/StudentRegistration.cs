namespace Student_Management_System.Models
{
    public class StudentRegistration
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int LevelId { get; set; }
        public int CourseId { get; set; }

        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
    }
}
