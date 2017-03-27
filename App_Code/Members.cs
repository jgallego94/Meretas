using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Members
/// </summary>
public class Members
{
    public Member loginMember(string email, string password)
    {
        Member activeMember = new Member();

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand LoginCommand = new SqlCommand();
        LoginCommand.Connection = meretas;
        LoginCommand.CommandType = CommandType.StoredProcedure;
        LoginCommand.CommandText = "AuthenticateLogin";

        SqlParameter EmailParameter = new SqlParameter();
        EmailParameter.ParameterName = "@UserEmail";
        EmailParameter.SqlDbType = SqlDbType.VarChar;
        EmailParameter.Value = email;
        EmailParameter.Direction = ParameterDirection.Input;

        SqlParameter PassParameter = new SqlParameter();
        PassParameter.ParameterName = "@UserPassword";
        PassParameter.SqlDbType = SqlDbType.VarChar;
        PassParameter.Value = password;
        PassParameter.Direction = ParameterDirection.Input;

        LoginCommand.Parameters.Add(EmailParameter);
        LoginCommand.Parameters.Add(PassParameter);

        SqlDataReader LoginReader = LoginCommand.ExecuteReader();

        if(LoginReader.HasRows)
        {
            while(LoginReader.Read())
            {
                activeMember.memberID = LoginReader[0].ToString();
                activeMember.isAdmin = Convert.ToInt32(LoginReader[1]);
            }
        }

        meretas.Close();

        return activeMember;

    }
}