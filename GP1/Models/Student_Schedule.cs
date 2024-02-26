using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GP1.Models
{
    public class Student_Schedule
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Student_ID")]
        public Student student { get; set; }
        [ForeignKey("Schedule_ID")]
        public Schedule schedule { get; set; }
    }
}
