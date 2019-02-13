using School.Common.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Contracts
{
    public interface IStudentRepository<U> where U : DbContext, new()
    {
        int AddStudent(Student student);
        int UpdateStudent(Student student, string studentId);
        int RemoveStudent(Student student, string studentId);
        List<Student> GetStudents();
        Student GetStudent(string studdentId);
    }
}
