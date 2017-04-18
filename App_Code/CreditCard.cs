using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCard
/// </summary>
public class CreditCard
{
    private string cardNameValue;
    private byte[] cardImageValue;
    private string cardTypeValue;
    private string cardEmploymentStatusValue;
    private string cardFeaturesValue;
    private string cardBalanceLengthValue;
    private string cardDischargedValue;

    public string CardName
    {
        get { return cardNameValue; }
        set { cardNameValue = value; }
    }

    public byte[] CardImage
    {
        get { return cardImageValue; }
        set { cardImageValue = value; }
    }

    public string CardType
    {
        get { return cardTypeValue; }
        set { cardTypeValue = value; }
    }

    public string EmploymentStatus
    {
        get { return cardEmploymentStatusValue; }
        set { cardEmploymentStatusValue = value; }
    }

    public string Features
    {
        get { return cardFeaturesValue; }
        set { cardFeaturesValue = value; }
    }

    public string BalanceLength
    {
        get { return cardBalanceLengthValue; }
        set { cardBalanceLengthValue = value; }
    }

    public string Discharged
    {
        get { return cardDischargedValue; }
        set { cardDischargedValue = value; }
    }
}
