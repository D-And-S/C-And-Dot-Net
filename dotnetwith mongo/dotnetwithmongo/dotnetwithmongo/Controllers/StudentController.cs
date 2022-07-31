using dotnetwithmongo.Entities;
using dotnetwithmongo.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetwithmongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentrepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentrepository = studentRepository;
        }

        [HttpGet("GetStudents")]
        public ActionResult<List<Student>> GetStudents()
        {
            return _studentrepository.Get();
        }

        [HttpGet("GetStudenById/{id}")]
        public ActionResult<Student> GetStudentById(string id)
        {
            var student = _studentrepository.Get(id);

            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost("InsertStudent")]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            _studentrepository.Create(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("UpdateStudent/{id}")]
        public ActionResult<Student> Put(string id, [FromBody] Student student) {
            var existingStudent = _studentrepository.Get(id);

            if(existingStudent == null) return NotFound();

            _studentrepository.Update(id, student);

            return Ok();
        }

        [HttpDelete("DeleteStudent/{id}")]
        public ActionResult<Student> DeleteStudent(string id)
        {
            var existingStudent = _studentrepository.Get(id);

            if (existingStudent == null) return NotFound();

            _studentrepository.Remove(id);

            return Ok();
        }

    }
}
