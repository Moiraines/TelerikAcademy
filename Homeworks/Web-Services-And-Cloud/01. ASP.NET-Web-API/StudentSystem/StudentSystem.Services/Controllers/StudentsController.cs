namespace StudentSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Web.Models;

    public class StudentsController : ApiController
    {
        private IStudentSystemDbContext db;
        private const string NoSuchId = "Invalid Id. No student with such Id was found.";

        public StudentsController()
            : this(new StudentSystemDbContext())
        {
            
        }

        public StudentsController(IStudentSystemDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IQueryable All()
        {
            var students = db.Students.Select(StudentModel.FromStudent);
            return students;
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            var student = GetStudentById(id);
            if (student == null)
            {
                return BadRequest(NoSuchId);
            }

            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level,
                Assistant = student.Assistant,
                AdditionalInformation = student.AdditionalInformation
            };

            this.db.Students.Add(newStudent);
            this.db.SaveChanges();

            student.StudentIdentification = newStudent.StudentIdentification;

            return Ok(newStudent);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingStudent = GetStudentById(id);

            if (existingStudent == null)
            {
                return BadRequest(NoSuchId);
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Level = student.Level;
            existingStudent.Assistant = student.Assistant;
            existingStudent.AdditionalInformation = student.AdditionalInformation;

            this.db.SaveChanges();

            student.StudentIdentification = existingStudent.StudentIdentification;

            return Ok(existingStudent);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingStudent = GetStudentById(id);

            if (existingStudent == null)
            {
                return BadRequest(NoSuchId);
            }

            this.db.Students.Remove(existingStudent);
            this.db.SaveChanges();

            return Ok();
        }

        private Student GetStudentById(int id)
        {
            return db.Students
                .FirstOrDefault(s => s.StudentIdentification == id);
        }


    }
}