using System.ComponentModel.DataAnnotations;

namespace GP1.Models
{
    public class Section
    {
        [Key]
        [Required]
        public int SEID_CID { get; set; }
        [Required]
        public int Days {  get; set; }
        [Required]
        public string Hall {  get; set; }
        [Required]
        public string DR_NAME {  get; set; }

        public Course course { get; set; }
        public ICollection<Section_Schedule> section_Schedules { get; set; }
    }
}
