using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCatalogFall2016.Models.Entity;
using StudentCatalogFall2016.Models.Interface;
namespace StudentCatalogFall2016.Models
{
    public class StudentRepository : StudentModelRepositoryInterface
    {
        private Models.ApplicationDbContext db = new Models.ApplicationDbContext();

        public void Delete(int id)
        {
            StudentModel student = findId(id);
            db.Students.Remove(student);
            db.SaveChanges();
            
        }

        public StudentModel findId(int id)
        {
            StudentModel student = db.Students.Find(id);
            if (student == null)
            {
                Console.WriteLine("Student not found");
            }
            return student;
        }

        public List<StudentModel> getAll()
        {
            List<StudentModel> students = db.Students.ToList();
            Console.WriteLine(students);
            return students;
        }

        public void InsertOrUpdate(StudentModel student)
        {
            //StudentModel newStudent = findId(student.StudentModelId);
            if(student.StudentModelId == 0)
            {
                db.Students.Add(student);
                db.SaveChanges();
                
            }
            else
            {
                using (var context = new Models.ApplicationDbContext())
                {
                    context.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        public IQueryable<StudentModel> Search(string searchString)
        {
            var students = from m in db.Students select m;

            if(!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s =>  s.Firstname.Contains(searchString)  ||
                                                s.Lastname.Contains(searchString)   ||
                                                s.Email.Contains(searchString)      ||
                                                s.MobilePhone.Contains(searchString)
                                                );
           }
            return students;
        }
    }
}