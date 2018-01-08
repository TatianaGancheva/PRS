using ClientProject.Controllers;
using ClientProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientProject.WebPage
{
    public partial class Review : System.Web.UI.Page
    {
       

        Refresh up = new Refresh();
        Student student = new Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            string field = (string)(Session["sel"]);
            up.Name = field;
            student = up.getStudent();
            display(field);
        }

        public void display(string field)
        {
            up.Name = field;
            student = up.getStudent();
            if (!IsPostBack)
            {
                txtName.Text = student.Name;
                txtAge.Text = student.Age.ToString();
                txtCourse.Text = student.Course.ToString();
                txtClass.Text = student.Class.ToString();
                txtAverageMark.Text = student.AverageMark.ToString();

            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Student NewStudent = up.student;
            student.ID = NewStudent.ID;
            student.Name = txtName.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            student.Course = Convert.ToInt32(txtCourse.Text);
            student.Class = txtClass.Text;
            student.AverageMark = Convert.ToDouble(txtAverageMark.Text);
            up.refresh();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew add = new AddNew();
            student.Name = txtName.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            student.Course = Convert.ToInt32(txtCourse.Text);
            student.Class = txtClass.Text;
            student.AverageMark = Convert.ToDouble(txtAverageMark.Text);
            add.Student = student;
            add.addNewStudent();
        }
    }
}