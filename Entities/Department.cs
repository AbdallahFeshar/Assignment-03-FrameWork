using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Entities
{
    internal class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public int? InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
