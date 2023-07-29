using Microsoft.AspNetCore.Mvc.Rendering;

namespace Student_Management_System.ViewModel
{
    public class StudentRegistrationViewModel
    {
        public StudentRegistrationViewModel()
        {
            GroupData = new List<SelectListItem>();
            LevelData = new List<SelectListItem>();
            CourseData = new List<SelectListItem>();
        }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string LevelName { get; set; }
        public string CourseName { get; set; }
        public int GroupId { get; set; }
        public int LevelId { get; set; }
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public List<SelectListItem>? GroupData { get; set; }
        public List<SelectListItem>? LevelData { get; set; }
        public List<SelectListItem>? CourseData { get; set; }
    }
}
