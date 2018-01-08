using ClientProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientProject.Controllers
{
    public class AddNew
    {
        private Student _student;
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }

        public void addNewStudent()
        {
            ServiceReference2.StudentInfoSOAPSoapClient servc = new ServiceReference2.StudentInfoSOAPSoapClient();
            string name = Student.Name;
            int age = Student.Age;
            int course = Student.Course;
            string classes = Student.Class;
            double avrgmark = Student.AverageMark;
            StudentInfo info = new StudentInfo();
            List<Student> students = info.ShowAllStudentsInData();
            string ok = "";
            foreach(Student s in students)
            {
                if (name == s.Name)
                {
                    ok = "ok";
                }
                if (ok.Equals(""))
                {
                    servc.AddNewStudent(name, age, course, classes, avrgmark);
                }
            }

        }
    }
}