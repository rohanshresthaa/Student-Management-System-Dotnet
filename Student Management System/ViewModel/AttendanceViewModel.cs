using Student_Management_System.Models;
using System.Text.RegularExpressions;

namespace Student_Management_System.ViewModel
{
    public class AttendanceViewModel
    {

        public AttendanceViewModel()
        {
            GroupData = new List<Models.Group>();
            CourseData = new List<Course>();
            LevelData = new List<Level>();
        }
        public List<Models.Group> GroupData { get; set; }
        public List<Course> CourseData { get; set; }
        public List<Level> LevelData { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public int LevelId { get; set; }
        public int GroupId { get; set; }
        public int Id { get; set; }
    }
}
