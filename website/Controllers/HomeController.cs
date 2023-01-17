using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using website.Models;
using static website.Models.Schooldata;

namespace website.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();  
        }


        //List<Student> students= new List<Student>();
        //List<StudentInfo> studentInfo = new List<StudentInfo>();

        List<Students> stdname= new List<Students>();
        List<Courses> stdcourse= new List<Courses>();

        public IActionResult Studentdetails()
        {
            //insertDummyData();

            //var studentViewModel = from s in students
            //                       join st in studentInfo on s.Id equals st.StdId into st2
            //                       from st in st2.DefaultIfEmpty()
            //                       select new StudentViewModel { studentVm = s, studentInfoVm = st };

            //return View(studentViewModel);


            //var studentCourseModel = from sN in stdname
            //                        join c in stdcourse on sN.Id equals c.Id into st2
            //                        from c in st2.DefaultIfEmpty()
            //                        select new StudentModel { Students = sN, Courses = c };


            //return View(studentCourseModel);
            return View();
            
        }
        //public void insertDummyData()
        //{
            
        //    students.Add(new Student { Id = 1, Name = "Max", Stream = "Computer Science" });
        //    students.Add(new Student { Id = 2, Name = "Tony", Stream = "Life Sciences" });
        //    students.Add(new Student { Id = 3, Name = "Jhon", Stream = "Robotics" });
        //    students.Add(new Student { Id = 4, Name = "Jack", Stream = "Computer Science" });
        //    students.Add(new Student { Id = 5, Name = "Dominic", Stream = "Avaiation" });


        //    studentInfo.Add(new StudentInfo { Id = 100, StdId = 1, FatherName = "Mahesh", Address = "Noida" });
        //    studentInfo.Add(new StudentInfo { Id = 101, StdId = 2, FatherName = "Ramesh", Address = "Noida" });
        //    studentInfo.Add(new StudentInfo { Id = 102, StdId = 3, FatherName = "Suresh", Address = "Noida" });
        //    studentInfo.Add(new StudentInfo { Id = 103, StdId = 4, FatherName = "Ganesh", Address = "Noida" });
        //    studentInfo.Add(new StudentInfo { Id = 104, StdId = 5, FatherName = "Hitesh", Address = "Noida" });

        //}
        //public void insertDummyData()
        //{

        //    stdname.Add(new Students { Id = 1, Name = "Max"});
        //    stdname.Add(new Students { Id = 2, Name = "Tony" });
        //    stdname.Add(new Students { Id = 3, Name = "Jhon" });
        //    stdname.Add(new Students { Id = 4, Name = "Jack" });
        //    stdname.Add(new Students { Id = 5, Name = "Dominic" });


        //    stdcourse.Add(new Courses { Id = 100, CourseName = "computer" });
        //    stdcourse.Add(new Courses { Id = 101, CourseName = "computer" });
        //    stdcourse.Add(new Courses { Id = 102, CourseName = "computer" });
        //    stdcourse.Add(new Courses { Id = 103, CourseName = "computer" });
        //    stdcourse.Add(new Courses { Id = 104, CourseName = "computer" });

        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}