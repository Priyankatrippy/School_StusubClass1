using System.ComponentModel.DataAnnotations;

namespace WebApp_1._44_PracticeProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        [Required]
        public int Name { get; set; }

        public int Age { get; set; }

    }

}

