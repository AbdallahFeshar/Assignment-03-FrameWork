using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Entities
{
    internal class Student
    {

            [Key]
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }

            public int DepartmentID { get; set; }
            public Department Department { get; set; }

            public ICollection<Stud_Course> StudentCourses { get; set; }
        }
}
