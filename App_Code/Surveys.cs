﻿using System;
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
        LoadCommand.CommandText = "LoadQuestions";

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
        IDParameter.Value = QuestionID;
        IDParameter.SqlDbType = SqlDbType.Int;
        IDParameter.Direction = ParameterDirection.Input;

        LoadCommand.Parameters.Add(IDParameter);

        SqlDataReader ChoiceDataReader = LoadCommand.ExecuteReader();

        if(ChoiceDataReader.HasRows)
        {
            while(ChoiceDataReader.Read())
            {
                Choice newChoice = new Choice();
                newChoice.ChoiceID = Convert.ToInt32(ChoiceDataReader["ChoiceID"]);
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

    public bool AddSurvey(int SurveyID, string Description)
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
    
    public int SubmitSurvey(int surveyID, int memberID, string dateSubmitted, TimeSpan timeSubmitted)
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;

        int surveyResponseID = 0;

        using (meretas)
        {
            try
            {
                meretas.Open();

                SqlCommand SubmitCommand = new SqlCommand();
                SubmitCommand.Connection = meretas;
                SubmitCommand.CommandType = CommandType.StoredProcedure;
                SubmitCommand.CommandText = "SubmitSurvey";

                SqlParameter Parameter = new SqlParameter();
                Parameter.ParameterName = "@SurveyID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = surveyID;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@MemberID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = memberID;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@DateSubmitted";
                Parameter.SqlDbType = SqlDbType.Date;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = dateSubmitted;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@TimeSubmitted";
                Parameter.SqlDbType = SqlDbType.Time;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = timeSubmitted;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@SurveyResponseID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Output;

                SubmitCommand.Parameters.Add(Parameter);

                using (SqlDataReader reader = SubmitCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            surveyResponseID = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("SubmitSurvey error: " + e.Message);
            }
            finally
            {
                meretas.Close();
            }
        }
        return surveyResponseID;
    }

    public bool RecordUserResponse(int surveyResponseID, int surveyID, int questionID, int choiceID)
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;

        bool success = false;

        using (meretas)
        {
            try
            {
                meretas.Open();

                SqlCommand SubmitCommand = new SqlCommand();
                SubmitCommand.Connection = meretas;
                SubmitCommand.CommandType = CommandType.StoredProcedure;
                SubmitCommand.CommandText = "RecordUserResponse";

                SqlParameter Parameter = new SqlParameter();
                Parameter.ParameterName = "@SurveyResponseID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = surveyResponseID;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@SurveyID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = surveyID;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@QuestionID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = questionID;

                SubmitCommand.Parameters.Add(Parameter);

                Parameter = new SqlParameter();
                Parameter.ParameterName = "@ChoiceID";
                Parameter.SqlDbType = SqlDbType.Int;
                Parameter.Direction = ParameterDirection.Input;
                Parameter.Value = choiceID;

                SubmitCommand.Parameters.Add(Parameter);

                using (SqlDataReader reader = SubmitCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if (reader.HasRows)
                            success = true;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("RecordUserResponse error: " + e.Message);
            }
            finally
            {
                meretas.Close();
            }
        }

        return success;
    }

    public Choice GetUserResponse(int surveyID, int questionID, int choiceID, int SRI)
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;

        Choice choice;
        choice = new Choice();

        using (meretas)
        {
            try
            {
                meretas.Open();

                SqlCommand GetCommand = new SqlCommand();
                GetCommand.Connection = meretas;
                GetCommand.CommandType = CommandType.StoredProcedure;
                GetCommand.CommandText = "GetUserResponse";

                SqlParameter AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@SurveyID";
                AddParameter.SqlDbType = SqlDbType.Int;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = surveyID;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@QuestionID";
                AddParameter.SqlDbType = SqlDbType.Int;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = questionID;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@ChoiceID";
                AddParameter.SqlDbType = SqlDbType.Int;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = choiceID;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@SurveyResponseID";
                AddParameter.SqlDbType = SqlDbType.Int;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = SRI;

                GetCommand.Parameters.Add(AddParameter);

                using (SqlDataReader reader = GetCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            choice.ChoiceID = Convert.ToInt32(reader["ChoiceID"].ToString());
                            choice.Description = reader["ChoiceText"].ToString();                         
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("GetUserResponse error: " + e.Message);
            }
            finally
            {
                meretas.Close();
            }
        }

        return choice;
    }
}