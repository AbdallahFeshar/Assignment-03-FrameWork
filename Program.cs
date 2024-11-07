using Assignment_02.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItiContext DBcontext=new ItiContext();

            //CRUD Operations:
            #region Student
            #region Create
            try
            {
                using (var context = new ItiContext())
                {
                    var department = context.Departments.FirstOrDefault();

                    if (department == null)
                    {

                        department = new Department { Name = "Computer Science" };
                        context.Departments.Add(department);
                        context.SaveChanges();

                        Console.WriteLine("Department created successfully.");
                    }


                    var newStudent = new Student
                    {
                        FirstName = "Abdallah",
                        LastName = "Feshar",
                        Address = "123 Main St",
                        Age = 22,
                        DepartmentID = department.ID
                    };

                    context.Students.Add(newStudent);
                    context.SaveChanges();
                    Console.WriteLine("Student created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating student: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var students = context.Students.ToList();
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No students found.");
                    }
                    else
                    {
                        foreach (var student in students)
                        {
                            Console.WriteLine($"ID: {student.ID}, Name: {student.FirstName}{student.LastName} Address: {student.Address}, Age: {student.Age}, Department ID: {student.DepartmentID}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading students: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }

            #endregion

            #region Update
            try
            {
                using (var context = new ItiContext())
                {
                    var studentToUpdate = context.Students.Find(1); 
                    if (studentToUpdate != null)
                    {
                        studentToUpdate.Address = "456 Elm St";
                        studentToUpdate.FirstName = "Ahmed";
                        context.SaveChanges();
                        Console.WriteLine("Student updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found for update.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating student: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var studentToDelete = context.Students.Find(1);
                    if (studentToDelete != null)
                    {
                        context.Students.Remove(studentToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Student deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found for deletion.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting student: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }

            #endregion

            #endregion


            #region Department


            #region Create
            try
            {
                using (var context = new ItiContext())
                {
                    var newDepartment = new Department
                    {
                        Name = "Information Technology"
                    };

                    context.Departments.Add(newDepartment);
                    context.SaveChanges();
                    Console.WriteLine("Department created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating department: {ex.Message}");
            }

            #endregion

            #region Read
            try
            {
                using (var context = new ItiContext())
                {
                    var departments = context.Departments.ToList();
                    foreach (var department in departments)
                    {
                        Console.WriteLine($"ID: {department.ID}, Name: {department.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading departments: {ex.Message}");
            }

            #endregion

            #region  Update
            try
            {
                using (var context = new ItiContext())
                {
                    var departmentToUpdate = context.Departments.Find(1); // Example with ID = 1
                    if (departmentToUpdate != null)
                    {
                        departmentToUpdate.Name = "Computer Engineering";
                        context.SaveChanges();
                        Console.WriteLine("Department updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating department: {ex.Message}");
            }

            #endregion

            #region Delete
            try
            {
                using (var context = new ItiContext())
                {
                    var departmentToDelete = context.Departments.Find(1); // Example with ID = 1
                    if (departmentToDelete != null)
                    {
                        context.Departments.Remove(departmentToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Department deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting department: {ex.Message}");
            }

            #endregion
            #endregion

            #region Course

            #region Create
            try
            {
                using (var context = new ItiContext())
                {
                    var newCourse = new Course
                    {
                        Name = "Database Systems",
                        Duration = "12 weeks",
                        Description = "Introduction to database systems",
                        TopicID= 1 
                    };

                    context.Courses.Add(newCourse);
                    context.SaveChanges();
                    Console.WriteLine("Course created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating course: {ex.Message}");
            }

            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var courses = context.Courses.ToList();
                    foreach (var course in courses)
                    {
                        Console.WriteLine($"ID: {course.ID}, Name: {course.Name}, Duration: {course.Duration}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading courses: {ex.Message}");
            }

            #endregion

            #region Update
            try
            {
                using (var context = new ItiContext())
                {
                    var courseToUpdate = context.Courses.Find(1); 
                    if (courseToUpdate != null)
                    {
                        courseToUpdate.Duration = "14 weeks";
                        context.SaveChanges();
                        Console.WriteLine("Course updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating course: {ex.Message}");
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var courseToDelete = context.Courses.Find(1); 
                    if (courseToDelete != null)
                    {
                        context.Courses.Remove(courseToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Course deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting course: {ex.Message}");
            }

            #endregion
            #endregion

            #region instractor

            #region create
            try
            {
                using (var context = new ItiContext())
                {
                    var newInstructor = new Instructor
                    {
                        Name = "Dr. Smith",
                        Salary = 100000,
                        Address= "789 Park Ave",
                        HourRate = 50,
                        DepartmentID=1 
                    };

                    context.Instructors.Add(newInstructor);
                    context.SaveChanges();
                    Console.WriteLine("Instructor created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating instructor: {ex.Message}");
            }

            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var instructors = context.Instructors.ToList();
                    foreach (var instructor in instructors)
                    {
                        Console.WriteLine($"ID: {instructor.ID}, Name: {instructor.Name}, Salary: {instructor.Salary}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading instructors: {ex.Message}");
            }

            #endregion

            #region Update
            try
            {
                using (var context = new ItiContext())
                {
                    var instructorToUpdate = context.Instructors.Find(1); 
                    if (instructorToUpdate != null)
                    {
                        instructorToUpdate.Salary = 120000;
                        context.SaveChanges();
                        Console.WriteLine("Instructor updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating instructor: {ex.Message}");
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var instructorToDelete = context.Instructors.Find(1); 
                    if (instructorToDelete != null)
                    {
                        context.Instructors.Remove(instructorToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Instructor deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting instructor: {ex.Message}");
            }

            #endregion
            #endregion


            #region Topic
            #region create
            try
            {
                using (var context = new ItiContext())
                {
                    var newTopic = new Topic
                    {
                        Name = "Software Engineering"
                    };

                    context.Topics.Add(newTopic);
                    context.SaveChanges();
                    Console.WriteLine("Topic created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating topic: {ex.Message}");
            }

            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var topics = context.Topics.ToList();
                    foreach (var topic in topics)
                    {
                        Console.WriteLine($"ID: {topic.ID}, Name: {topic.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading topics: {ex.Message}");
            }

            #endregion

            #region Update
            try
            {
                using (var context = new ItiContext())
                {
                    var topicToUpdate = context.Topics.Find(1); // Example with ID = 1
                    if (topicToUpdate != null)
                    {
                        topicToUpdate.Name = "Advanced Software Engineering";
                        context.SaveChanges();
                        Console.WriteLine("Topic updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating topic: {ex.Message}");
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var topicToDelete = context.Topics.Find(1); // Example with ID = 1
                    if (topicToDelete != null)
                    {
                        context.Topics.Remove(topicToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Topic deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting topic: {ex.Message}");
            }

            #endregion
            #endregion

            #region Student-Course
            #region create
            try
            {
                using (var context = new ItiContext())
                {
                    var newStudCourse = new Stud_Course
                    {
                        StudentID= 1, 
                        CourseID=1,  
                        Grade = "90"
                    };

                    context.Stud_Courses.Add(newStudCourse);
                    context.SaveChanges();
                    Console.WriteLine("Student-Course enrollment created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating student-course enrollment: {ex.Message}");
            }

            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var studCourses = context.Stud_Courses.ToList();
                    foreach (var studCourse in studCourses)
                    {
                        Console.WriteLine($"Student ID: {studCourse.StudentID}, Course ID: {studCourse.CourseID}, Grade: {studCourse.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading student-course enrollments: {ex.Message}");
            }

            #endregion

            #region update
            try
            {
                using (var context = new ItiContext())
                {
                    var studCourseToUpdate = context.Stud_Courses.Find(1, 1); 
                    if (studCourseToUpdate != null)
                    {
                        studCourseToUpdate.Grade = "91";
                        context.SaveChanges();
                        Console.WriteLine("Student-Course enrollment updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating student-course enrollment: {ex.Message}");
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var studCourseToDelete = context.Stud_Courses.Find(1, 1); // Example with Student ID = 1 and Course ID = 1
                    if (studCourseToDelete != null)
                    {
                        context.Stud_Courses.Remove(studCourseToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Student-Course enrollment deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting student-course enrollment: {ex.Message}");
            }

            #endregion
            #endregion

            #region Course-Instructor
            #region create
            try
            {
                using (var context = new ItiContext())
                {
                    var newCourseInst = new Course_Inst
                    {
                        InstructorID = 1, 
                        CourseID = 1   
                    };

                    context.Course_Insts.Add(newCourseInst);
                    context.SaveChanges();
                    Console.WriteLine("Course-Instructor assignment created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating course-instructor assignment: {ex.Message}");
            }

            #endregion

            #region read
            try
            {
                using (var context = new ItiContext())
                {
                    var courseInsts = context.Course_Insts.ToList();
                    foreach (var courseInst in courseInsts)
                    {
                        Console.WriteLine($"Instructor ID: {courseInst.InstructorID}, Course ID: {courseInst.CourseID}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading course-instructor assignments: {ex.Message}");
            }

            #endregion

            #region update
            try
            {
                using (var context = new ItiContext())
                {
                    var courseInstToUpdate = context.Course_Insts.Find(1, 1); 
                    if (courseInstToUpdate != null)
                    {
                        courseInstToUpdate.InstructorID = 2; 
                        context.SaveChanges();
                        Console.WriteLine("Course-Instructor assignment updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating course-instructor assignment: {ex.Message}");
            }

            #endregion

            #region delete
            try
            {
                using (var context = new ItiContext())
                {
                    var courseInstToDelete = context.Course_Insts.Find(1, 1); 
                    if (courseInstToDelete != null)
                    {
                        context.Course_Insts.Remove(courseInstToDelete);
                        context.SaveChanges();
                        Console.WriteLine("Course-Instructor assignment deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting course-instructor assignment: {ex.Message}");
            }

            #endregion
            #endregion




        }
    }
}
