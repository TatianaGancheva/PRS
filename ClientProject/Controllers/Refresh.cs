using ClientProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientProject.Controllers
{
    public class Refresh
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private Student _student;
        public Student student
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

        public void refresh()
        {
            ServiceReference2.StudentInfoSOAPSoapClient service = new ServiceReference2.StudentInfoSOAPSoapClient();
            int id = student.ID;
            string name = student.Name;
            int age = student.Age;
            int course = student.Course;
            string classes = student.Class;
            double avrgMarks = student.AverageMark;
            service.refresh(id, name, age, course, classes, avrgMarks);

        }

        public Student getStudent()
        {
            StudentInfo stdInf = new StudentInfo();
            List<Student> students = stdInf.ShowAllStudentsInData();
            Student returned = new Student();
            string name = Name;
            foreach(Student s in students)
            {
                if (name.Equals(s.Name))
                {
                    returned = s;
                    student = s;
                }
            }
            return returned;
        }

    }
}