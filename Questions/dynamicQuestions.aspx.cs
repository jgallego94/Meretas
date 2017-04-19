using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections.Specialized;


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
                TimeSpan time = DateTime.Now.TimeOfDay;
                int SRI = MCH.ProcessSurvey(1, Convert.ToInt32(Application["SurveyID"]), "01/01/2017", time);
                Choice activeChoice = new Choice();
                List<Choice> Choicelist = new List<Choice>();
                List<string> UserResponses = new List<string>();
                List<CreditCard> CreditCards = new List<CreditCard>();
                List<string> CardAttributes = new List<string>();

                //populate user choices list
                for (int q = 0; q < activeSurvey.Questions.Count(); q++)
                {
                    int surveyID = Convert.ToInt32(Application["SurveyID"].ToString());
                    int questionID = activeSurvey.Questions[q].QuestionID;

                    UserResponses.Add(Page.Request.Form[activeSurvey.Questions[q].QuestionID].ToString());

                    int choiceID = Convert.ToInt32(UserResponses[q].ToString());

                    MCH.RecordUserResponse(SRI, surveyID, questionID, choiceID);

                    int tempSurveyID = Convert.ToInt32(Application["SurveyID"]);
                    int tempQuestionID = activeSurvey.Questions[q].QuestionID;
                    int tempChoiceID = Convert.ToInt32(Request.Form[tempQuestionID]);
                    //Returns ChoiceID and ChoiceText
                    Choicelist.Add(MCH.GetUserResponse(tempSurveyID, tempQuestionID, tempChoiceID, SRI));
                }

                List<CreditCard> cardList = new List<CreditCard>();

                foreach (Choice uh in Choicelist)
                {
                   cardList = MCH.RecommendCard(Choicelist[0].Description, Choicelist[1].Description, Choicelist[2].Description, Choicelist[3].Description);
                }

                Application["cardList"] = cardList;
                Response.Redirect("../Results/CreditCardResults.aspx");
            
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
                carouselBuilder.Append("<label for=" + activeSurvey.Questions[0].Choices[j].Description + " name=\"q\" " + activeSurvey.Questions[0].Choices[j].ChoiceID + "> " + activeSurvey.Questions[0].Choices[j].Description + "</label><br><br><br>");

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
                    carouselBuilder.Append("<input type=\"radio\" id=" + activeSurvey.Questions[i].Choices[j].Description + " name=" + activeSurvey.Questions[i].QuestionID + " value=" + activeSurvey.Questions[i].Choices[j].ChoiceID + "> ");
                    carouselBuilder.Append("<label for=" + activeSurvey.Questions[i].Choices[j].Description + " name=\"q\" " + activeSurvey.Questions[i].Choices[j].ChoiceID + "> " + activeSurvey.Questions[i].Choices[j].Description + "</label><br><br><br>");

                }



                carouselBuilder.Append("</div>");

                if (activeSurvey.Questions[i].Equals(activeSurvey.Questions.Last()))
                {
                    carouselBuilder.Append("<input type=\"submit\" id=\"nextButton\" class=\"btn btn-lg\" value=\"Get Results\">");
                }
                else
                {
                    carouselBuilder.Append("<a href = \"#formCarousel\" role=\"button\" class= \"btn btn-lg\" id=\"nextButton\" data-slide=\"next\">Next</a>");
                  
                }            
                carouselBuilder.Append("</div>");
                carouselBuilder.Append("</div>");

            }

            string carouselString = carouselBuilder.ToString();
            dynamicSurvey.InnerHtml = carouselString;
        }
         
    }

  


}