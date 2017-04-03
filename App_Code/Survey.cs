using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Survey
/// </summary>
public class Survey
{
    private string descriptionValue;
    private List<Question> QuestionList = new List<Question>();

    public string Description
    {
        get { return descriptionValue; }
        set { descriptionValue = value; }
    }

    public List<Question> Questions
    {
        get { return QuestionList; }
    }

}