using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Question
{
    private int QuestionIDValue;
    private string QuestionTextValue;
    private List<Choice> ChoiceList = new List<Choice>();

    public int QuestionID
    {
        get { return QuestionIDValue; }
        set { QuestionIDValue = value; }
    }
    public string QuestionText
    {
        get { return QuestionTextValue; }
        set { QuestionTextValue = value; }
    }

    public List<Choice> Choices
    {
        get { return ChoiceList; }
    }



    
}