using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Response
/// </summary>
public class Choice
{
    private int QuestionIDValue;
    private string DescriptionValue;

    public int QuestionID
    {
        get { return QuestionIDValue; }
        set { QuestionIDValue = value; }
    }

    public string Description
    {
        get { return DescriptionValue; }
        set { DescriptionValue = value; }
    }
}