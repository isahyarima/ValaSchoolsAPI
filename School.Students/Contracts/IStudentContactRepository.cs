
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Contracts
{
   public interface IStudentContactRepository
    {
        int AddStudentContact(StudentContact studentContact);
        int UpdateStudentContact(StudentContact student, string studentContactId);
        int RemoveStudentContact(StudentContact student, string studentContactId);
        List<StudentContact> GetStudentContacts();
        StudentContact GetStudentContact(string studentContactId);
    }
}
