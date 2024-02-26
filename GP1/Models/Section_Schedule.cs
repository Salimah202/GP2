using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP1.Models
{
    public class Section_Schedule
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("SEID_CID")]
        public Section section { get; set; }
        [ForeignKey("Schedule_ID")]
        public Schedule schedule { get; set; }
    }
}