using System.Collections.Generic;
namespace CourseApp.Models
{
    public static class Repository
    {

        private static List<Student> _students = new List<Student>();

        //Repository.Students
        public static List<Student> Students
        {
            get
            {
                return _students;
            }
        }

        //repository.AddStudents(student);

        public static void AddStudents(Student student)
        {
            _students.Add(student);
        }


    }
}
