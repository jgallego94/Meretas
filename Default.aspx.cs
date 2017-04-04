using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Login_Click(object sender, EventArgs e)
    {
        MeretasCodeHandler MCH = new MeretasCodeHandler();
        Member activeMember = new Member();

        activeMember = MCH.LoginMember(Email.Text, Password.Text);

        Response.Cookies["MemberID"].Value = activeMember.memberID;
        Response.Cookies["isAdmin"].Value = activeMember.isAdmin.ToString();

        if(activeMember.memberID != null)
        {
            if(activeMember.isAdmin == 1)
            {
                Response.Redirect("Users/Admin.aspx");
            }
            else
            {
                Response.Redirect("Users/Main.aspx");
            }
        }
    }

    protected void startButton_Click(object sender, EventArgs e)
    {
        Application["SurveyID"] = 1;
        Response.Redirect("Questions/dynamicTest.aspx");
    }
}