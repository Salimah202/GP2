using System.ComponentModel.DataAnnotations;

namespace GP1.Models
{
    public class DegreeProgressPlan
    {
        [Key]
        [Required]
        public int PlanID { get; set; }
        [Required]
        [StringLength(1, ErrorMessage = "Status cannot be longer than 1 number .")]
        public int STATUS {  get; set; }
        [StringLength(4, ErrorMessage = "Spec code cannot be longer than 4 number .")]
        public int SPEC_CODE { get; set; }
        [StringLength(1, ErrorMessage = "Smster number cannot be longer than 1 number .")]
        public int SMST_NO { get; set; }
        [StringLength(5, ErrorMessage = "cannot be longer than 5 number .")]
        public int SPEC_YYT{ get; set; }
        [StringLength(1, ErrorMessage = "cannot be longer than 1 number .")]
        public int SPEC_LVL { get; set; }
        public ICollection<Student> Student { get; set; }
        public ICollection<Degree_Course> degree_Courses { get; set; }

    }
}
