using school.Organization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school.Organization.Domain;

namespace school.Organization.Domain
{
    public class SchoolAppService : IRepositorySchool
    {
        private readonly List<Student> Students = new List<Student>();
        public int AddStudent(Student student)
        {
            Students.Add(student);
            return student.Id;
        }
        public int GetAllStudent()
        {
            return Students.Count;
        }
    }
}
