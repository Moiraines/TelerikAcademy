namespace StudentSystem.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using StudentSystem.Models;


    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get
            {
                return s => new StudentModel
                {
                    StudentIdentification = s.StudentIdentification,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Level = s.Level,
                    Assistant = s.Assistant,
                    AdditionalInformation = s.AdditionalInformation
                };
            }
        }

        [Key]
        public int StudentIdentification { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public int Level { get; set; }

        public virtual Student Assistant { get; set; }

        //[InverseProperty("Assistant")]
        //public virtual ICollection<Student> Trainees { get; set; }
        //
        //public virtual ICollection<Course> Courses { get; set; }
        //
        //public virtual ICollection<Homework> Homeworks { get; set; }
        //
        public StudentInfo AdditionalInformation { get; set; }
        
        //[NotMapped]
        //public bool IsAssistant
        //{
        //    get
        //    {
        //        return this.Trainees.Count > 0;
        //    }
        //}
    }
}