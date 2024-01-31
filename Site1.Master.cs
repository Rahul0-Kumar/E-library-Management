using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_library_Management1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;//userlogin link button
                    LinkButton2.Visible = true;// singup

                    LinkButton3.Visible = false;//logout link button
                    LinkButton5.Visible = false;// hello user

                    LinkButton6.Visible = true;//admin link button
                    LinkButton7.Visible = false;// author management
                    LinkButton8.Visible = false;//publisher mangement
                    LinkButton9.Visible = false;// book inventroy
                    LinkButton10.Visible = false;// book issuing
                    LinkButton11.Visible = false;//member management

                }
                else if (Session["role"].Equals("User"))
                {
                    LinkButton1.Visible =false;//userlogin link button
                    LinkButton2.Visible =false;// singup

                    LinkButton3.Visible = true;//logout link button
                    LinkButton5.Visible = true;// hello user
                    LinkButton5.Text = "Hello" + Session["username"].ToString();

                    LinkButton6.Visible = true;//admin link button
                    LinkButton7.Visible = false;// author management
                    LinkButton8.Visible = false;//publisher mangement
                    LinkButton9.Visible = false;// book inventroy
                    LinkButton10.Visible = false;// book issuing
                    LinkButton11.Visible = false;// member mangement

                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;//userlogin link button
                    LinkButton2.Visible = false;// singup

                    LinkButton3.Visible = true;//logout link button
                    LinkButton5.Visible = true;// hello user
                    LinkButton5.Text = "Hello Admin" + Session["username"].ToString();

                    LinkButton6.Visible = false;//admin link button
                    LinkButton7.Visible = true;// author management
                    LinkButton8.Visible = true;//publisher mangement
                    LinkButton9.Visible = true;// book inventroy
                    LinkButton10.Visible = true;// book issuing
                    LinkButton11.Visible = true;// member mangement
                }
            }
            catch (Exception ex)
            {

            }


        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true;//userlogin link button
            LinkButton2.Visible = true;// singup

            LinkButton3.Visible = false;//logout link button
            LinkButton5.Visible = false;// hello user

            LinkButton6.Visible = true;//admin link button
            LinkButton7.Visible = false;// author management
            LinkButton8.Visible = false;//publisher mangement
            LinkButton9.Visible = false;// book inventroy
            LinkButton10.Visible = false;// book issuing
            LinkButton11.Visible = false;//member management

            Response.Redirect("Homepage.aspx");

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

       

       
        
    }
}