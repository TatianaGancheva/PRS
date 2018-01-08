using ClientProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace ClientProject.Controllers
{
    public class StudentInfo : ApiController
    {
        private string _searchW;
        private string _selected;
        private List<Student> _students;
        private List<string> _nme;

        public List<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }

        public List<string> Nme
        {
            get
            {
                return _nme;
            }
            set
            {
                _nme = value;
            }
        }

        public string SearchWord
        {
            get
            {
                return _searchW;
            }
            set
            {
                _searchW = value;
            }
        }

        public string SelectedOne
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public List<Student> ShowAllStudentsInData()
        {
            ServiceReference2.StudentInfoSOAPSoapClient NewService = new ServiceReference2.StudentInfoSOAPSoapClient();
            var enumerbl = NewService.ShowAllStudents().AsEnumerable();
            List<Student> allSt = new List<Student>();
            allSt =
                (from item in enumerbl
                 select new Student
                 {
                     ID = item.Field<int>("Id"),
                     Name = item.Field<string>("Name"),
                     Age = item.Field<int>("Age"),
                     Course = item.Field<int>("Course"),
                     Class = item.Field<string>("Class"),
                     AverageMark = item.Field<double>("AverageMark")
                 }).ToList();
            return allSt;

        }

        public List<Student> SearchStudent(string searchOption)
        {
            string Sword = null;
            Sword = SearchWord;
            string name = null;
            int age = 0;
            int course = 0;
            string classes = null;
            double avrgMrk = 0;
            List<Student> fndtStudent = new List<Student>();
            if (searchOption.Equals("Name"))
            {
                name = SearchWord;

            }
            else if (searchOption.Equals("Class"))
            {
                classes = SearchWord;
            }
            List<Student> allStudents = ShowAllStudentsInData();

            foreach (Student searchedStudnt in allStudents)
            {
                if (SearchWord.Equals(""))
                {
                    fndtStudent = allStudents;
                }

                else if (name != null && name.Equals(searchedStudnt.Name))
                {
                    fndtStudent.Add(searchedStudnt);
                }
                else if (classes!=null&&classes.Equals(searchedStudnt.Class))
                {
                    fndtStudent.Add(searchedStudnt);
                }

            }
            Students = fndtStudent;
            return Students;

        }

        public List<string> ShowAllNames(string srch)
        {
            List<Student> students = SearchStudent(srch);
            List<Student> show = new List<Student>();
            List<string> names = new List<string>();
            if (students.Equals(null))
            {
                show = ShowAllStudentsInData();
            }
            else
            {
                show = Students;
            }
            string name = null;
            foreach(Student st in show)
            {
                name = st.Name;
                names.Add(name);
            }
            Nme = names;
            return Nme;
        }

        public void removeStudent()
        {
            ServiceReference2.StudentInfoSOAPSoapClient service = new ServiceReference2.StudentInfoSOAPSoapClient();
            int ID = 0;
            string selected = SelectedOne;
            List<Student> students = ShowAllStudentsInData();
            foreach(Student std in students)
            {
                if (selected.Equals(std.Name))
                {
                    ID = std.ID;
                    service.RemoveStudent(ID);
                }
            }
        }

    }
}