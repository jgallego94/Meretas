using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Text;

public partial class Questions_dynamicTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if(Application["SurveyID"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
        else
        {
            MeretasCodeHandler MCH = new MeretasCodeHandler();
            StringWriter sw = new StringWriter();          
            Survey activeSurvey = new Survey();
            StringBuilder carouselBuilder = new StringBuilder();

            //survey ID is hardcoded to 1 for now
            activeSurvey = MCH.GetSurvey(Convert.ToInt32(Application["SurveyID"]));

            if (IsPostBack)
            {
                string time = "12:12 AM";
                int SRI = MCH.ProcessSurvey(1, Convert.ToInt32(Application["SurveyID"]), "01/01/2017", time);
                List<int> ResponseList = new List<int>();

                //populate user choices list
                for (int i = 0; i< activeSurvey.Questions.Count(); i++)
                {                 
                    ResponseList.Add(Convert.ToInt32(Request.Form[activeSurvey.Questions[i].QuestionID]));         
                }

                //submit list to database
               for (int j = 0; j< ResponseList.Count(); j++)
                {
                    MCH.RecordUserResponse(SRI, 1, activeSurvey.Questions[j].QuestionID, ResponseList[j]);
                }
                
                
                           
            }

            carouselBuilder.Append("<div class=\"item active\">");
            carouselBuilder.Append("<div class=\"col-sm-2\">");
            carouselBuilder.Append("</div>");
            carouselBuilder.Append("<div class=\"col-sm-8\" id=\"Question\">");
            carouselBuilder.Append("<br><hr class=\"style-eight\">");
            carouselBuilder.Append("<h2>");
            carouselBuilder.Append(activeSurvey.Questions[0].QuestionText);
            carouselBuilder.Append("</h2>");
            carouselBuilder.Append("<div class=\"radio\"><br>");
            carouselBuilder.Append("<input type=\"radio\"  id=" + activeSurvey.Questions[0].Choices[0].Description + " name=" + activeSurvey.Questions[0].QuestionID + " value=" + activeSurvey.Questions[0].Choices[0].ChoiceID + " checked = \"checked\" />");
            carouselBuilder.Append("<label for=" + activeSurvey.Questions[0].Choices[0].Description + " name=\"q\" "  + activeSurvey.Questions[0].Choices[0].ChoiceID + ">" + activeSurvey.Questions[0].Choices[0].Description + "</label><br><br><br>");

            for (int j = 1; j < activeSurvey.Questions[0].Choices.Count(); j++)
            {
                carouselBuilder.Append("<input type=\"radio\" id=" + activeSurvey.Questions[0].Choices[j].Description + " name=" + activeSurvey.Questions[0].QuestionID + ">");
                carouselBuilder.Append("<label for=" + activeSurvey.Questions[0].Choices[j].Description + " name=\"q\" " + activeSurvey.Questions[0].Choices[j].Description + "> " + activeSurvey.Questions[0].Choices[j].Description + "</label><br><br><br>");

            }

            carouselBuilder.Append("</div>"); //!Radio

            carouselBuilder.Append("<a href = \"#formCarousel\" role=\"button\" class= \"btn btn-lg\" id=\"nextButton\" data-slide=\"next\">Next</a>");

           
            carouselBuilder.Append("</div>"); 
            carouselBuilder.Append("</div>"); //!Active-item

            for (int i = 1; i < activeSurvey.Questions.Count(); i++)
                {
                    string testQuestionText = activeSurvey.Questions[i].QuestionText;

                    carouselBuilder.Append("<div class=\"item\">");
                    carouselBuilder.Append("<div class=\"col-sm-2\">");
                    carouselBuilder.Append("</div>");
                    carouselBuilder.Append("<div class=\"col-sm-8\" id=\"Question\">");
                    carouselBuilder.Append("<br><hr class=\"style-eight\">");
                    carouselBuilder.Append("<h2>");
                    carouselBuilder.Append(testQuestionText);
                    carouselBuilder.Append("</h2>");
                    carouselBuilder.Append("<div class=\"radio\"><br>");
                    carouselBuilder.Append("<input type=\"radio\"  id=" + activeSurvey.Questions[i].Choices[0].Description + " name=" + activeSurvey.Questions[i].QuestionID + " value=" + activeSurvey.Questions[i].Choices[0].ChoiceID + " checked = \"checked\" />");
                    carouselBuilder.Append("<label for=" + activeSurvey.Questions[i].Choices[0].Description + " name=\"q\" " + activeSurvey.Questions[i].Choices[0].ChoiceID + ">" + activeSurvey.Questions[i].Choices[0].Description + "</label><br><br><br>");

                for (int j = 1; j < activeSurvey.Questions[i].Choices.Count(); j++)
                {
                    carouselBuilder.Append("<input type=\"radio\" id=" + activeSurvey.Questions[i].Choices[j].Description + " name=" + activeSurvey.Questions[i].QuestionID + ">");
                    carouselBuilder.Append("<label for=" + activeSurvey.Questions[i].Choices[j].Description + " name=\"q\" " + activeSurvey.Questions[i].Choices[j].Description + "> " + activeSurvey.Questions[i].Choices[j].Description + "</label><br><br><br>");

                }



                carouselBuilder.Append("</div>");

                if(activeSurvey.Questions[i].Equals(activeSurvey.Questions.Last()))
                {
                    carouselBuilder.Append("<input type=\"submit\" id=\"nextButton\" class=\"btn btn-lg\" value=\"Get Results\">");
                }
                else
                {
                    carouselBuilder.Append("<a href = \"#formCarousel\" role=\"button\" class= \"btn btn-lg\" id=\"nextButton\" data-slide=\"next\">Next</a>");
                  
                }            
                carouselBuilder.Append("</div>");
            
                }

            string carouselString = carouselBuilder.ToString();
            dynamicSurvey.InnerHtml = carouselString;
        }
         
    }

  


}