using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Response
/// </summary>
public class Choice
{
    private int ChoiceIDValue;
    private string DescriptionValue;

    public int ChoiceID
    {
        get { return ChoiceIDValue; }
        set { ChoiceIDValue = value; }
    }

    public string Description
    {
        get { return DescriptionValue; }
        set { DescriptionValue = value; }
    }
}