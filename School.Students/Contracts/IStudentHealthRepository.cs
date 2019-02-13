using School.Common.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Contracts
{
   public interface IStudentHealthRepository 
    {
        int AddStudentHealth(StudentHealth studentHealth);
        int UpdateStudentHealth(StudentHealth studentHealth, string studentHealthId);
        int RemoveStudentHealth(StudentHealth studentHealth, string studentHealthId);
        List<StudentHealth> GetStudentHealths();
        StudentHealth GetStudentHealth(string studentHealthId);
    }
}
