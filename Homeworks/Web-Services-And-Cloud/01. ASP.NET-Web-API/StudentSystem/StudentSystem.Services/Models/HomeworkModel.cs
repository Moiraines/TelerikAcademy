namespace StudentSystem.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq.Expressions;
    using StudentSystem.Models;

    public class HomeworkModel
    {
        public static Expression<Func<Homework, HomeworkModel>> FromHomework
        {
            get
            {
                return h => new HomeworkModel
                {
                    HomeworkId = h.Id,
                    FileUrl = h.FileUrl,
                    TimeSent = h.TimeSent,
                    StudentIdentification = h.StudentIdentification,
                    CourseId = h.CourseId
                };
            }
        }
        public int HomeworkId { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

        [ForeignKey("Student")]
        public int StudentIdentification { get; set; }

        //public virtual Student Student { get; set; }

        public Guid CourseId { get; set; }

        //public virtual Course Course { get; set; }
    }
}