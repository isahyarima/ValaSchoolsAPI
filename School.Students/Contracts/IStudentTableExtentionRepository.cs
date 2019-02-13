using School.Common.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Contracts
{
    public interface IStudentTableExtentionRepository 
    {
        int AddStudentTableExtention(StudentTableExtention studentTableExtention);
        int UpdateStudentTableExtention(StudentTableExtention studentTableExtention, string studentTableExtentionId);
        int RemoveStudentTableExtention(StudentTableExtention studentTableExtention, string studentTableExtentionId);
        List<StudentTableExtention> GetStudentTableExtentions();
        StudentTableExtention GetStudentTableExtention(string studentTableExtentionId);
    }
}
