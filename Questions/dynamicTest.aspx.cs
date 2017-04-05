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
            
          
                for (int i = 0; i < activeSurvey.Questions.Count(); i++)
                {
                    string testQuestionText = activeSurvey.Questions[i].QuestionText;

                    carouselBuilder.Append("<div class=\"item active\">");
                    carouselBuilder.Append("<div class=\"col-sm-2\">");
                    carouselBuilder.Append("</div>");
                    carouselBuilder.Append("<div class=\"col-sm-8\" id=\"Question\">");
                    carouselBuilder.Append("<br><hr class=\"style-eight\">");
                    carouselBuilder.Append("<h2>");
                    carouselBuilder.Append(testQuestionText);
                    carouselBuilder.Append("<h2>");

                    carouselBuilder.Append("</div>");
                    carouselBuilder.Append("</div>");


                    string carouselString = carouselBuilder.ToString();
                    dynamicSurvey.InnerHtml = carouselString;            
                }
            

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