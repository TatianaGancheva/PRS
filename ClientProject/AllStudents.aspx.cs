using ClientProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientProject
{
    public partial class AllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErr.Text = "";
            ShowAll();
        }

        protected void ShowAll()
        {
            string choose = DropDown.SelectedValue;
            string searchedFor = searching.Text;
            StudentInfo stdInf = new StudentInfo();
            stdInf.SearchWord = searchedFor;
            List<string> list = stdInf.ShowAllNames(choose);
            names.DataSource = null;
            names.DataSource = list;
            names.DataBind();
        }

        protected void btnSrc_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (names.SelectedIndex > 0)
            {
                ListViewItem item = names.Items[names.SelectedIndex];
                Label lbl = (Label)item.FindControl("lblSel");
                string finalResult = lbl.Text;
                StudentInfo stInf = new StudentInfo();
                stInf.SelectedOne = finalResult;
                stInf.removeStudent();

            }
            else
            {
                lblErr.Text = "You must select an Item!";
            }
        }

        protected void names_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (names.SelectedIndex >= 1)
            {
                //view state//
            }
            else
            {
                ViewState["SelectedKey"] = null;            }
        }

        protected void btnOvrvw_Click(object sender, EventArgs e)
        {
            if (names.SelectedIndex > 0)
            {
                ListViewItem item = names.Items[names.SelectedIndex];
                Label lbl = (Label)item.FindControl("lblSel");
                string finalResult = lbl.Text;
                if (finalResult != null)
                {
                    Session["sel"] = finalResult;
                    Response.Redirect("Review.aspx");

                }
            }
            else
            {
                lblErr.Text = "You must select an Item!";
            }
        }
    }
}