using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCatalogFall2016.Models.Entity;

namespace StudentCatalogFall2016.Models.Interface
{
    interface StudentModelRepositoryInterface
    {
        // get all students
        List<StudentModel> getAll();

        //find a student
        StudentModel findId(int id);

        //search by some value
        IQueryable<StudentModel> Search(string searchString);

        //delete a student
        void Delete(int id);

        //creates a new student or updates an existing if already exist.
        void InsertOrUpdate(StudentModel student);

    }
}
