using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UclLib.Objects;

namespace UclLib.Data
{
    public static class GetData
    {
        public static List<Student> GetStudents()
        {
            List<Student> studentsList = new List<Student>();
            for(int i = 1; i <= 45; i++)
            {
                Student student = new Student()
                {
                    Address = new Address(),
                    CPR = 12345678 + i,
                    Email = string.Format("student{0}@edu.ucl.dk", i),
                    IsErasmusStudent = false,
                    Name = "Student Doe" + i,
                    Phone = 87964512 + i
                };
                studentsList.Add(student);
            }
            return studentsList;
        }

        public static List<Teacher> GetTeachers()
        {
            List<Teacher> teachersList = new List<Teacher>();
            for (int i = 1; i <= 45; i++)
            {
                Teacher teacher = new Teacher()
                {
                    Address = new Address(),
                    CPR = 12345678 + i,
                    Email = string.Format("teacher{0}@ucl.dk", i),
                    Name = "Teacher Doe" + i,
                    Phone = 87964512 + i
                };
                teachersList.Add(teacher);
            }
            return teachersList;
        }

        // TODO: Create a combined list of students AND teachers
        public static List<Person> GetAllUclData()
        {
            List<Person> personsList = new List<Person>();
            personsList.AddRange(GetStudents());
            personsList.AddRange(GetTeachers());

            return personsList;
        }
    }
}
