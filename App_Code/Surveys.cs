using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Surveys
/// </summary>

public class Surveys
{
    public Survey GetSurvey()
    {
        Survey survey = new Survey(); 

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand GetCommand = new SqlCommand();
        GetCommand.Connection = meretas;
        GetCommand.CommandType = CommandType.StoredProcedure;
        GetCommand.CommandText = "GetSurvey";

        SqlDataReader Reader = GetCommand.ExecuteReader();

        if(Reader.HasRows)
        {
            while(Reader.Read())
            {
                survey.Description = Reader["Description"].ToString(); 
            }
        }

        return survey;
    }
}