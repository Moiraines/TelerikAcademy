namespace StudentSystem.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;
    using StudentSystem.Models;

    public class CourseModel
    {
        public static Expression<Func<Course, CourseModel>> FromCourse
        {
            get
            {
                return c => new CourseModel
                {
                    CourseId = c.Id,
                    Name = c.Name,
                    Description = c.Description
                };
            }
        }
        public Guid CourseId { get; set; }

        [Column("CourseName")]
        public string Name { get; set; }

        public string Description { get; set; }

        //public virtual ICollection<Student> Students { get; set; }

        //public virtual ICollection<Homework> Homeworks { get; set; }
    }
}