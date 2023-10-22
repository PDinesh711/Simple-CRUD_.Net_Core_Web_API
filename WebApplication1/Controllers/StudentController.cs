using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Dto;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController
    {
        [HttpGet("getAll")]
        public List<StudentGet> getAllStudent()
        {
            return StudentData.StudentList;
        }

        [HttpGet("get/{id}")]
        public StudentGet getStudentById(int id)
        {
            return StudentData.StudentList.FirstOrDefault(get => get.Id == id);
        }

        [HttpPost("save")]
        public StudentGet createStudent([FromBody] StudentGet studentGet) {    
           studentGet.Id = StudentData.StudentList.OrderByDescending(get=> get.Id).FirstOrDefault().Id+1;
           StudentData.StudentList.Add(studentGet);
            return studentGet;
        }

        [HttpDelete("delete/{id}")]
        public string  deleteStudent(int id)  {
            var villa = StudentData.StudentList.FirstOrDefault(e => e.Id == id);
            StudentData.StudentList.Remove(villa);
            return "Deleted SuccessFully !";
        }

        [HttpPut("update/{id}")]
        public String updateStudent(int id , [FromBody] StudentGet studentGet)
        {
            var student = StudentData.StudentList.FirstOrDefault(u=>u.Id == id);
            student.Id = studentGet.Id;
            student.Name= studentGet.Name;
            return "Updated";
        }
    }
}
