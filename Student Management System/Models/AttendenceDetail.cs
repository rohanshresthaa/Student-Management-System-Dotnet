namespace Student_Management_System.Models
{
    public class AttendenceDetail
    {
        public int Id { get; set; }
        public int AttedanceId { get; set; }
        public int StudentId { get; set; }
        public byte AbsentPresentStatus { get; set; }
        public Attendence? Attendences { get; set; }
    }
}
