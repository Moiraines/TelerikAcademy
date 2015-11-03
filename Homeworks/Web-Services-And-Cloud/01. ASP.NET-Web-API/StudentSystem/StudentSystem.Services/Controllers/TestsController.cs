using System.Linq;
using System.Web.Http;
using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.Web.Models;

namespace StudentSystem.Web.Controllers
{
    public class TestsController : ApiController
    {
        private const string NoSuchId = "Invalid id. No course with such id was found.";
        private IStudentSystemDbContext db;

        public TestsController()
            : this(new StudentSystemDbContext())
        {
        }

        public TestsController(IStudentSystemDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IQueryable All()
        {
            var tests = db.Tests.Select(TestModel.FromTest);
            return tests;
        }

        [HttpGet]
        public IHttpActionResult ById(int id)
        {
            var test = GetTestById(id);
            if (test == null)
            {
                return BadRequest(NoSuchId);
            }

            return Ok(test);
        }

        [HttpPost]
        public IHttpActionResult Create(TestModel test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newTest = new Test
            {
            };

            this.db.Tests.Add(newTest);
            this.db.SaveChanges();

            test.TestId = newTest.Id;

            return Ok(newTest);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Test test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingTest = GetTestById(id);

            if (existingTest == null)
            {
                return BadRequest(NoSuchId);
            }

            this.db.SaveChanges();

            test.Id = existingTest.Id;
            return Ok(test);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingTest = GetTestById(id);

            if (existingTest == null)
            {
                return BadRequest(NoSuchId);
            }

            this.db.Tests.Remove(existingTest);
            this.db.SaveChanges();

            return Ok();
        }


        private Test GetTestById(int id)
        {
            return db.Tests
                .FirstOrDefault(t => t.Id == id);
        }
    }
}