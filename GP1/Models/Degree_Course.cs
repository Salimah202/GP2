using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP1.Models
{
    public class Degree_Course
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CRS_NO")]
        public Course course { get; set; }
        [ForeignKey("Plan_ID")]
        public DegreeProgressPlan DegreeProgressPlan { get; set; }

    }
}
