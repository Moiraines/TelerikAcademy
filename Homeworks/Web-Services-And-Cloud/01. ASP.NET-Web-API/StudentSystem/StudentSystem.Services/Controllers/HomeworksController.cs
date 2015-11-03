namespace StudentSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Web.Models;

    public class HomeworksController : ApiController
    {
        private const string NoSuchId = "Invalid id. No homework with such id was found.";
        private IStudentSystemDbContext db;

        public HomeworksController()
            :this(new StudentSystemDbContext())
        {
        }

        public HomeworksController(IStudentSystemDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IQueryable All()
        {
            var homeworks = db.Homeworks.Select(HomeworkModel.FromHomework);
            return homeworks;
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            var homework = GetHomeworkById(id);
            if (homework == null)
            {
                return BadRequest(NoSuchId);
            }

            return Ok(homework);
        }

        [HttpPost]
        public IHttpActionResult Create(HomeworkModel homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newHomework = new Homework
            {
                FileUrl = homework.FileUrl,
                TimeSent = homework.TimeSent,
                StudentIdentification = homework.StudentIdentification,
                CourseId = homework.CourseId
            };

            this.db.Homeworks.Add(newHomework);
            this.db.SaveChanges();

            homework.HomeworkId = newHomework.Id;

            return Ok(newHomework);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Homework homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingHomework = GetHomeworkById(id);

            if (existingHomework == null)
            {
                return BadRequest(NoSuchId);
            }

            existingHomework.FileUrl = homework.FileUrl;
            existingHomework.TimeSent = homework.TimeSent;
            existingHomework.StudentIdentification = homework.StudentIdentification;
            existingHomework.CourseId = homework.CourseId;

            this.db.SaveChanges();

            homework.Id = existingHomework.Id;
            return Ok(homework);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingHomework = GetHomeworkById(id);

            if (existingHomework == null)
            {
                return BadRequest(NoSuchId);
            }

            this.db.Homeworks.Remove(existingHomework);
            this.db.SaveChanges();

            return Ok();
        }

        private Homework GetHomeworkById(int id)
        {
            return db.Homeworks
                .FirstOrDefault(h => h.Id == id);
        }
    }
}