﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class MeretasCodeHandler
{
   public bool AddQuestion(int QuestionID, int SurveyID, string Description)
   {
       bool Confirmation = false;
       Surveys SurveyManager = new Surveys();

       Confirmation = SurveyManager.AddQuestion(QuestionID, SurveyID, Description);

       return Confirmation;
   }

   public Survey GetSurvey()
   {
       Surveys SurveyManager = new Surveys();
       //Assuming you need a surveyId to return a survey
       return SurveyManager.GetSurvey(SurveyID);
   }


   public bool AddResponse(int ResponseID, int QuestionID, int SurveyID, string Description)
   {
       bool Confirmation = false;
       Surveys SurveyManager = new Surveys();

       Confirmation = SurveyManager.AddResponse(ResponseID, QuestionID, SurveyId, Description)
       
       return Confirmation;
   }

   public bool AddSurvey(int SurveyID, string Description)
   {
       bool Confirmation = false;
       Surveys SurveyManager = new Surveys();

       Confirmation = SurveyManager.AddSurvey(SurveyId, Description)

       return Confirmation;
   }

   public bool AddVisitorSurvey(int SurveyID, int VisitorID)
   {
       bool Confirmation = false;
       Surveys SurveyManager = new Surveys();

       Confirmation = SurveyManager.AddVisitorSurvey(SurveyID, VisitorID)

       return Confirmation;
   }

   public bool ProcessSurvey(int VisitorID, int SurveyID, int QuestionID, int ResponseID, DateTime DateSubmitted, DateTime TimeSubmitted, int ResponseInstanceID)
   {
       bool Confirmation;
       Surveys SurveyManager = new Surveys();

       Confirmation = SurveyManager.ProcessSurvey(VisitorID, SurveyID, QuestionID, ResponseID, DateSubmitted, TimeSubmitted, ResponseInstanceID)

       return Confirmation;
   }
}