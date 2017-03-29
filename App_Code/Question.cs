using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Question
/// </summary>
public class Question
{
    private string QuestionTextValue;
    private List<string> ResponseList = new List<string>();

    public string QuestionText
    {
        get { return QuestionTextValue; }
        set { QuestionTextValue = value; }
    }


    
}