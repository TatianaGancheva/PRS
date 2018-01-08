using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientProject.Model
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _age;
        private int _course;
        private string _class;
        private double _averageMark;

        public int ID
        {
            get
            {
            return _id;
            }
            set
            {
                _id = value;
            }
        }
        
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

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
            }
        }

        public string Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
            }
        }

        public double AverageMark
        {
            get
            {
                return _averageMark;
            }
            set
            {
                _averageMark = value;
            }
        }

        public Student() { }
    }

    
}