using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Survey activeSurvey = new Survey();

            //survey ID is hardcoded to 1 for now
            activeSurvey = MCH.GetSurvey(Convert.ToInt32(Application["SurveyID"]));
            
           
            string testQuestionText = activeSurvey.Questions[0].QuestionText;
        }
         
    }
}