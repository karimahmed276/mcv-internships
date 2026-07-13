using Microsoft.AspNetCore.Mvc;
using studentmanagment.api.models;

namespace studentmanagment.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        // قائمة الطلاب
        private static List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Ahmed",
                Age = 20,
                DepartmentName = "Computer Science"
            },
            new Student
            {
                Id = 2,
                Name = "Mohamed",
                Age = 21,
                DepartmentName = "Information Systems"
            },
            new Student
            {
                Id = 3,
                Name = "Sara",
                Age = 19,
                DepartmentName = "Artificial Intelligence"
            }
        };

        // Task 2
        [HttpGet("welcome")]
        public IActionResult Welcome()
        {
            return Ok("Welcome to Student Management API");
        }

        // Task 3
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }
        // Task 4
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            return Ok(student);
        }
        // Task 5
        [HttpGet("search")]
        public IActionResult SearchStudents(string name)
        {
            var result = students
                .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(result);
        }
        // Task 6
        [HttpGet("filter-by-age")]
        public IActionResult FilterByAge()
        {
            var result = students
                .Where(s => s.Age >= 18 && s.Age <= 22)
                .OrderBy(s => s.Age)
                .ToList();

            return Ok(result);
        }
        // Task 7
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            student.Id = students.Max(s => s.Id) + 1;

            students.Add(student);

            return Ok(student);
        }
        // Task 8
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.DepartmentName = updatedStudent.DepartmentName;

            return Ok(student);
        }
        // Task 9
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student Not Found");
            }

            students.Remove(student);

            return Ok("Student Deleted Successfully");
        }
    }
}