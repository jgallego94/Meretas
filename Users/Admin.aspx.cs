using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Response.Cookies["MemberID"].Value = null;
        Response.Cookies["MemberID"].Expires = DateTime.Now.AddDays(-1d);

        Response.Cookies["isAdmin"].Value = null;
        Response.Cookies["isAdmin"].Expires = DateTime.Now.AddDays(-1d);

        Response.Redirect("../Default.aspx");
    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        //DateTime date = DateTime.Now;
        //string day = date.Date.ToString();
        //string time = date.TimeOfDay.ToString();

        MeretasCodeHandler MCH = new MeretasCodeHandler();
        //MCH.newCreditCard(cardName.Text, relLink.Text, Convert.ToInt32(addCardID.Text), day, time);

    }

    protected void delButton_Click(object sender, EventArgs e)
    {
        MeretasCodeHandler MCH = new MeretasCodeHandler();


    }
}