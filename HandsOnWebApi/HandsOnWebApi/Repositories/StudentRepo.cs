using HandsOnWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnWebApi.Repositories
{
    public class StudentRepo
    {
        StudentDataBaseContext _context;
       public  StudentRepo(StudentDataBaseContext _context)
        {
            this._context = _context;

        }
        public void AddStudentRecords()
        {
            HandsOnWebApi.Models.Student Record = new HandsOnWebApi.Models.Student()
            { Id = 01, FirstName = "Divya", LastName = "Kancharla", Address = "xyz", City = "abc", State = "123" };
            _context.Add(Record);
            _context.SaveChanges();
        }
        public void AddStudent(Student student)
        {
            _context.Student.Add(student);
        }
        public List<Student> GetAllRecords()
        {
            return _context.Student.ToList();
        }
        public Student GetOneRecords(int id)
        {
            return _context.Student.Find(id);
        }
        public void UpdateRecord(int id)
        {
            Student student= _context.Student.Find(id);
            student.City ="abc";
            student.State ="xyz";
            _context.Student.Update(student);
            _context.SaveChanges();
        }
        public void DeleteRecord(int id)
        {
            Student student = _context.Student.Find(id);
            _context.Student.Remove(student);
            _context.SaveChanges();
        }
    }
}
