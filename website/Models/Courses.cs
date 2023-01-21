using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
    }
}