using System.ComponentModel.DataAnnotations;

namespace GP1.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string password {  get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DegreeProgressPlan DegreeProgressPlan { get; set; }

        public ICollection<Student_Schedule> student_Schedules { get; set; }
    }
}
