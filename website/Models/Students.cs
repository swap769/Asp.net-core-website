namespace website.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string? Name { get; set; }

    }
    public class StudentModel
    {
       public Students? students { get; set; }
        public Courses? courses { get; set; } 
    }
}
