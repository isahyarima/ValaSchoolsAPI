
using School.Students.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School.Students.Repository
{
    public class StudentRepository : IStudentRepository<SchoolContext>
    {
        public int AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(string studdentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public int RemoveStudent(Student student, string studentId)
        {
            throw new NotImplementedException();
        }

        public int UpdateStudent(Student student, string studentId)
        {
            throw new NotImplementedException();
        }
    }

}
