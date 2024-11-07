using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Entities
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TopicID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> StudentCourses { get; set; }
        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}
