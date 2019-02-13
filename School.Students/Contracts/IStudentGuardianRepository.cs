using School.Common.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Contracts
{
    public interface IStudentGuardianRepository  
    {
        int AddStudentGuardian(StudentGuardian studentGuardian);
        int UpdateStudentGuardian(StudentGuardian studentGuardian, string studentGuardianId);
        int RemoveStudentGuardian(StudentGuardian studentGuardian, string studentGuardianId);
        List<StudentGuardian> GetStudentGuardian();
        StudentGuardian GetStudentGuardian(string studentGuardianId);
    }
}
