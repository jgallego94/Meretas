using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class Surveys
{
    //using surveyID to return survey, still needs work
    public Survey LoadSurvey(int SurveyID)
    {
        Survey survey = new Survey();
        
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand LoadCommand = new SqlCommand();
        LoadCommand.Connection = meretas;
        LoadCommand.CommandType = CommandType.StoredProcedure;
        LoadCommand.CommandText = "LoadSurvey";

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveyID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        LoadCommand.Parameters.Add(SurveyIDParameter);

        SqlDataReader LoadReader = LoadCommand.ExecuteReader();

        if(LoadReader.HasRows)
        {
            while(LoadReader.Read())
            {
                Question newQuestion = new Question();
                newQuestion.QuestionID = Convert.ToInt32(LoadReader["QuestionID"]);
                newQuestion.QuestionText = LoadReader["QuestionText"].ToString();

                List<Choice> questionChoices = new List<Choice>();
                questionChoices = LoadChoices(newQuestion.QuestionID);

                for (int i = 0; i < questionChoices.Count; i++)
                {
                    newQuestion.Choices.Add(questionChoices[i]);
                }
                
                survey.Questions.Add(newQuestion);
            }
        }

        return survey;
    }

    public List<Choice> LoadChoices(int QuestionID)
    {
        List<Choice> Choices = new List<Choice>();

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand LoadCommand = new SqlCommand();
        LoadCommand.Connection = meretas;
        LoadCommand.CommandType = CommandType.StoredProcedure;
        LoadCommand.CommandText = "LoadChoices";

        SqlParameter IDParameter = new SqlParameter();
        IDParameter.ParameterName = "@QuestionID";
        IDParameter.SqlDbType = SqlDbType.Int;
        IDParameter.Direction = ParameterDirection.Input;

        LoadCommand.Parameters.Add(IDParameter);

        SqlDataReader ChoiceDataReader = LoadCommand.ExecuteReader();

        if(ChoiceDataReader.HasRows)
        {
            while(ChoiceDataReader.Read())
            {
                Choice newChoice = new Choice();
                newChoice.QuestionID = Convert.ToInt32(ChoiceDataReader["QuestionID"]);
                newChoice.Description = ChoiceDataReader["ChoiceText"].ToString();

                Choices.Add(newChoice);
            }
        }

        return Choices;
    }

    public bool AddQuestion(int QuestionID, int SurveyID, string Description)
    {
        bool Success = false;

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand AddCommand = new SqlCommand();
        AddCommand.Connection = meretas;
        AddCommand.CommandType = CommandType.StoredProcedure;
        AddCommand.CommandText = "AddQuestion";

        SqlParameter QuestionIDParameter = new SqlParameter();
        QuestionIDParameter.ParameterName = "@QuestionID";
        QuestionIDParameter.SqlDbType = SqlDbType.Int;
        QuestionIDParameter.Value = QuestionID;
        QuestionIDParameter.Direction = ParameterDirection.Input;

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveryID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        SqlParameter DescriptionParameter = new SqlParameter();
        DescriptionParameter.ParameterName = "@Description";
        DescriptionParameter.SqlDbType = SqlDbType.VarChar;
        DescriptionParameter.Value = Description;
        DescriptionParameter.Direction = ParameterDirection.Input;

        AddCommand.Parameters.Add(QuestionIDParameter);
        AddCommand.Parameters.Add(SurveyIDParameter);
        AddCommand.Parameters.Add(DescriptionParameter);

        AddCommand.ExecuteNonQuery();

        Success = true;

        meretas.Close();

        return Success; 
    }

    public bool AddResponse(int ResponseID, int QuestionID, int SurveyID, string Description)
    {
        bool Success = false;

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand AddCommand = new SqlCommand();
        AddCommand.Connection = meretas;
        AddCommand.CommandType = CommandType.StoredProcedure;
        AddCommand.CommandText = "AddResponse";

        SqlParameter ResponseIDParameter = new SqlParameter();
        ResponseIDParameter.ParameterName = "@ResponseID";
        ResponseIDParameter.SqlDbType = SqlDbType.Int;
        ResponseIDParameter.Value = ResponseID;
        ResponseIDParameter.Direction = ParameterDirection.Input;

        SqlParameter QuestionIDParameter = new SqlParameter();
        QuestionIDParameter.ParameterName = "@QuestionID";
        QuestionIDParameter.SqlDbType = SqlDbType.Int;
        QuestionIDParameter.Value = QuestionID;
        QuestionIDParameter.Direction = ParameterDirection.Input;

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveryID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        SqlParameter DescriptionParameter = new SqlParameter();
        DescriptionParameter.ParameterName = "@Description";
        DescriptionParameter.SqlDbType = SqlDbType.VarChar;
        DescriptionParameter.Value = Description;
        DescriptionParameter.Direction = ParameterDirection.Input;

        AddCommand.Parameters.Add(ResponseIDParameter);
        AddCommand.Parameters.Add(QuestionIDParameter);
        AddCommand.Parameters.Add(SurveyIDParameter);
        AddCommand.Parameters.Add(DescriptionParameter);

        AddCommand.ExecuteNonQuery();

        Success = true;

        meretas.Close();

        return Success;

    }

    public bool AddSurvery(int SurveyID, string Description)
    {
        bool Success = false;

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand AddCommand = new SqlCommand();
        AddCommand.Connection = meretas;
        AddCommand.CommandType = CommandType.StoredProcedure;
        AddCommand.CommandText = "AddSurvey";

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveryID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        SqlParameter DescriptionParameter = new SqlParameter();
        DescriptionParameter.ParameterName = "@Description";
        DescriptionParameter.SqlDbType = SqlDbType.VarChar;
        DescriptionParameter.Value = Description;
        DescriptionParameter.Direction = ParameterDirection.Input;

        AddCommand.Parameters.Add(SurveyIDParameter);
        AddCommand.Parameters.Add(DescriptionParameter);

        AddCommand.ExecuteNonQuery();

        Success = true;

        meretas.Close();

        return Success;
    }

    public bool AddVisitorSurvey(int SurveyID, int VisitorID)
    {
        bool Success = false;

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand AddCommand = new SqlCommand();
        AddCommand.Connection = meretas;
        AddCommand.CommandType = CommandType.StoredProcedure;
        AddCommand.CommandText = "AddVisitorSurvey";

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveryID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        SqlParameter VisitorIDParameter = new SqlParameter();
        VisitorIDParameter.ParameterName = "@VisitorID";
        VisitorIDParameter.SqlDbType = SqlDbType.Int;
        VisitorIDParameter.Value = VisitorID;
        VisitorIDParameter.Direction = ParameterDirection.Input;

        AddCommand.Parameters.Add(SurveyIDParameter);
        AddCommand.Parameters.Add(VisitorIDParameter);

        AddCommand.ExecuteNonQuery();

        Success = true;

        meretas.Close();

        return Success;
        
    }

    //not sure if the dates will work, google said use DateTime, so I put that!
    public bool ProcessSurvey(int VisitorID, int SurveyID, int QuestionID, int ResponseID, DateTime DateSubmitted, DateTime TimeSubmitted, int ResponseInstanceID)
    {
        bool Success = false;

        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();

        meretas.ConnectionString = WebSettings.ConnectionString;
        meretas.Open();

        SqlCommand ProcessCommand = new SqlCommand();
        ProcessCommand.Connection = meretas;
        ProcessCommand.CommandType = CommandType.StoredProcedure;
        ProcessCommand.CommandText = "ProcessSurvey";

        SqlParameter VisitorIDParameter = new SqlParameter();
        VisitorIDParameter.ParameterName = "@VisitorID";
        VisitorIDParameter.SqlDbType = SqlDbType.Int;
        VisitorIDParameter.Value = VisitorID;
        VisitorIDParameter.Direction = ParameterDirection.Input;

        SqlParameter SurveyIDParameter = new SqlParameter();
        SurveyIDParameter.ParameterName = "@SurveryID";
        SurveyIDParameter.SqlDbType = SqlDbType.Int;
        SurveyIDParameter.Value = SurveyID;
        SurveyIDParameter.Direction = ParameterDirection.Input;

        SqlParameter QuestionIDParameter = new SqlParameter();
        QuestionIDParameter.ParameterName = "@QuestionID";
        QuestionIDParameter.SqlDbType = SqlDbType.Int;
        QuestionIDParameter.Value = QuestionID;
        QuestionIDParameter.Direction = ParameterDirection.Input;

        SqlParameter ResponseIDParameter = new SqlParameter();
        ResponseIDParameter.ParameterName = "@ResponseID";
        ResponseIDParameter.SqlDbType = SqlDbType.Int;
        ResponseIDParameter.Value = ResponseID;
        ResponseIDParameter.Direction = ParameterDirection.Input;

        SqlParameter DateSubmittedParameter = new SqlParameter();
        DateSubmittedParameter.ParameterName = "@DateSubmitted";
        DateSubmittedParameter.SqlDbType = SqlDbType.DateTime;
        DateSubmittedParameter.Value = DateSubmitted;
        DateSubmittedParameter.Direction = ParameterDirection.Input;

        SqlParameter TimeSubmittedParameter = new SqlParameter();
        TimeSubmittedParameter.ParameterName = "@TimeSubmitted";
        TimeSubmittedParameter.SqlDbType = SqlDbType.DateTime;
        TimeSubmittedParameter.Value = TimeSubmitted;
        TimeSubmittedParameter.Direction = ParameterDirection.Input;

        SqlParameter ResponseInstanceIDParameter = new SqlParameter();
        ResponseInstanceIDParameter.ParameterName = "@ResponseInstanceID";
        ResponseInstanceIDParameter.SqlDbType = SqlDbType.Int;
        ResponseInstanceIDParameter.Value = ResponseInstanceID;
        ResponseInstanceIDParameter.Direction = ParameterDirection.Input;

        ProcessCommand.Parameters.Add(VisitorIDParameter);
        ProcessCommand.Parameters.Add(SurveyIDParameter);
        ProcessCommand.Parameters.Add(ResponseIDParameter);
        ProcessCommand.Parameters.Add(DateSubmittedParameter);
        ProcessCommand.Parameters.Add(TimeSubmittedParameter);
        ProcessCommand.Parameters.Add(ResponseInstanceIDParameter);

        ProcessCommand.ExecuteNonQuery();

        Success = true;

        meretas.Close();

        return Success;
    }
}