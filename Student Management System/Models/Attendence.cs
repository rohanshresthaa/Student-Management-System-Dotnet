using System.Collections;

namespace Student_Management_System.Models
{
    public class Attendence
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public int LevelId { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<AttendenceDetail>? attendenceDetails { get; set; }
    }
}
