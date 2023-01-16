namespace website.Models
{
    public class Schooldata
    {
        public class Teacher
        {
            public int TeacherId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string EnrollmentNo { get; set; }
        }

    }
}
