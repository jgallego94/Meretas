﻿using System;
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


            carouselBuilder.Append("<div class=\"item active\">");
            carouselBuilder.Append("<div class=\"col-sm-2\">");
            carouselBuilder.Append("</div>");
            carouselBuilder.Append("<div class=\"col-sm-8\" id=\"Question\">");
            carouselBuilder.Append("<br><hr class=\"style-eight\">");
            carouselBuilder.Append("<h2>");
            carouselBuilder.Append(activeSurvey.Questions[0].QuestionText);
            carouselBuilder.Append("</h2>");
            carouselBuilder.Append("<div class=\"radio\"><br>");

            for (int j = 0; j < activeSurvey.Questions[0].Choices.Count(); j++)
            {
                carouselBuilder.Append("<input type=\"radio\"  id=" + activeSurvey.Questions[0].Choices[j].Description + " onclick=\"check()\" name=\"q\" value=" + activeSurvey.Questions[0].Choices[j].ChoiceID + "/>");
                carouselBuilder.Append("<label for=" + activeSurvey.Questions[0].Choices[j].Description + " onclick=\"check()\"  name=\"q\"> " + activeSurvey.Questions[0].Choices[j].Description + "</label><br><br><br>");

            }

            carouselBuilder.Append("</div>"); //!Radio

            carouselBuilder.Append("<a href = \"#formCarousel\" role=\"button\" class= \"btn btn-lg\" id=\"nextButton\" data-slide=\"next\" style=\"visibility:hidden;\" >Next</a>");

           
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

                    for (int j = 0; j < activeSurvey.Questions[i].Choices.Count(); j++)
                        {
                             carouselBuilder.Append("<input type=\"radio\" id=" + activeSurvey.Questions[i].Choices[j].Description + " name=\"q\" value=" + activeSurvey.Questions[i].Choices[j].ChoiceID + "/>");
                             carouselBuilder.Append("<label for=" + activeSurvey.Questions[i].Choices[j].Description + "> " + activeSurvey.Questions[i].Choices[j].Description + "</label><br><br><br>");
                            
                        }    

                   

                carouselBuilder.Append("</div>");

                if(activeSurvey.Questions[i].Equals(activeSurvey.Questions.Last()))
                {
                    //<a href="../Results/CreditCardResults.aspx" role="button" class="btn btn-lg" id="nextButton">Get Results</a>
                    carouselBuilder.Append("<a href = \"../Results/CreditCardResults.aspx\" role=\"button\" class=\"btn btn-lg\" id=\"nextButton\">Get Results</a>");
                }
                else
                {
                    carouselBuilder.Append("<a href = \"#formCarousel\" role=\"button\" class= \"btn btn-lg\" id=\"nextButton\" data-slide=\"next\">Next</a>");
                }            
                carouselBuilder.Append("</div>");
            
                }

            string carouselString = carouselBuilder.ToString();
            dynamicSurvey.InnerHtml = carouselString;


            //QuestionText.Text = testQuestionText;
            //<% --< div class="item active">
            //                 <div class="col-sm-2">

            //                 </div>
            //                 <div class="col-sm-8" id="Question">
            //                     <br />
            //                     <hr class="style-eight" />

            //                      <h2><asp:Label ID = "QuestionText" runat="server" CssClass="QuestionText"></asp:Label></h2>     

            //                     <a href = "#formCarousel" role="button" class="btn btn-lg" id="nextButton" data-slide="next">Next</a>

            //                 </div>
            //                 <div class="col-sm-2">

            //                 </div>
            //             </div>--%>


        }
         
    }
}