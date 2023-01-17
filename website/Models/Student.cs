namespace website.Models
{
    public class Students
    {
        public int Id { get; set; }
        public int stdId { get; set; }
        public string? Name { get; set; }

    }
    public class StudentModel
    {
       public Students? Students { get; set; }
       public Courses? Courses { get; set; } 
    }
}
