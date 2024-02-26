using System.ComponentModel.DataAnnotations;

namespace GP1.Models
{
    public class Schedule
    {
        [Key]
        [Required]
        public int SceduleID { get; set; }
        [Required]
        public int Sections { get; set; }
        public ICollection<Student_Schedule> student_Schedules { get; set; }
        public ICollection<Section_Schedule> section_Schedules { get; set; }


    }
}
