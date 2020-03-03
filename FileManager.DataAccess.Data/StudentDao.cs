using FileManager.Common.Layer;
using FileManager.DataAcces.Data;
using System;

//con ayuda de David

namespace FileManager.Business.Layer
{
    public class StudentBs
    {
        public void Add(string Name, string Surname, DateTime DateofBirth, string typo)
        {
            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.DateofBirth = DateofBirth.ToString();
            StudentDao studenCreator = FactoryProvider.GetFactory(typo).Creator(typo);
            studenCreator.Add(student);
        }
        public void Delete(string Name, string Surname, DateTime DateofBirth,string StudentId, string typo)
        {
            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.DateofBirth = DateofBirth.ToString();
            student.StudentId = Int32.Parse(StudentId);
            StudentDao studenCreator = FactoryProvider.GetFactory(typo).Creator(typo);
            studenCreator.Delete(student);
        }
        public void Update(string Name, string Surname, DateTime DateofBirth, string StudentId, string typo)
        {
            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.DateofBirth = DateofBirth.ToString();
            student.StudentId = Int32.Parse(StudentId);
            StudentDao studenCreator = FactoryProvider.GetFactory(typo).Creator(typo);
            studenCreator.Update(student);
        }
    }
}
