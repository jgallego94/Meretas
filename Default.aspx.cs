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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Surveys surveysbutt = new Surveys();
        
        //Needs a survey ID

        //surveysbutt.GetSurvey();
    }

    protected void Login_Click(object sender, EventArgs e)
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand login = new SqlCommand("SELECT Email, Role FROM Users WHERE Email = @Email AND Password = @Password", meretas);
        login.CommandType = CommandType.Text;

        login.Parameters.AddWithValue("@Email", Email.Text);
        login.Parameters.AddWithValue("@Password", Password.Text);

        SqlDataAdapter DataAdapter = new SqlDataAdapter(login);
        DataAdapter.TableMappings.Add("UserName", "Role");
        DataAdapter.SelectCommand = login;



        DataTable loginTable = new DataTable();

        DataSet loginSet = new DataSet("Users");
        DataAdapter.Fill(loginSet);

        loginSet.Tables.Add(loginTable);


        if(loginTable.Rows.Count>0)
        {
            Response.Cookies["UserName"].Value = loginTable.Rows[0].ToString();
            Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(1);

            if (loginTable.Rows[0].ToString().Equals("admin"))
            {
                Response.Redirect("Users/Admin.aspx");
            }
            else if(loginTable.Rows[0].ToString().Equals("member"))
            {
                Response.Redirect("Users/Main.aspx");
            } 
        }
               


    }
}