namespace StudentSystem.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Web.Models;

    public class CoursesController : ApiController
    {
        private const string NoSuchId = "Invalid id. No course with such id was found.";
        private IStudentSystemDbContext db;

        public CoursesController()
            : this(new StudentSystemDbContext())
        {
        }

        public CoursesController(IStudentSystemDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IQueryable All()
        {
            var courses = db.Courses.Select(CourseModel.FromCourse);
            return courses;
        }

        [HttpGet]
        public IHttpActionResult ById(Guid id)
        {
            var course = GetCourseById(id);
            if (course == null)
            {
                return BadRequest(NoSuchId);
            }

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseModel course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCourse = new Course
            {
                Name = course.Name,
                Description = course.Description
            };

            this.db.Courses.Add(newCourse);
            this.db.SaveChanges();

            course.CourseId = newCourse.Id;

            return Ok(newCourse);
        }

        [HttpPut]
        public IHttpActionResult Update(Guid id, Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCourse = GetCourseById(id);

            if (existingCourse == null)
            {
                return BadRequest(NoSuchId);
            }

            existingCourse.Id = course.Id;
            existingCourse.Name = course.Name;
            existingCourse.Description = course.Description;
            this.db.SaveChanges();

            course.Id = existingCourse.Id;
            return Ok(course);
        }

        [HttpDelete]
        public IHttpActionResult Delete(Guid id)
        {
            var existingCourse = GetCourseById(id);

            if (existingCourse == null)
            {
                return BadRequest(NoSuchId);
            }

            this.db.Courses.Remove(existingCourse);
            this.db.SaveChanges();

            return Ok();
        }

        private Course GetCourseById(Guid id)
        {
            return db.Courses
                .FirstOrDefault(c => c.Id == id);
        }
    }
}