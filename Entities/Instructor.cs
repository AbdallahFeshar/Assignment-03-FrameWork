using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Entities
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> CourseInstructors { get; set; }
    }
}
