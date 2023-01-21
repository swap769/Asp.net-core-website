using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace website.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        //[ForeignKey("CourseId")]
        //public int? CourseId { get; set; }
        //public Course? course { get; set; }
    }
}
