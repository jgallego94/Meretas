using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCard
/// </summary>
public class CreditCard
{
    private int creditCardIDValue;
    private string cardNameValue;
    private byte[] cardImageValue;
    private string cardLinkValue;
    private string cardTypeValue;
    private string cardEmploymentStatusValue;
    private string cardFeaturesValue;
    private string cardBalanceLengthValue;
    private string cardDischargedValue;
    private string cardDateAddedValue;
    private string cardTimeAddedValue;
    private bool cardIsRemovedValue;
    private string cardDateRemovedValue;
    private string cardTimeRemovedValue;

    public int CreditCardID
    {
        get { return creditCardIDValue; }
        set { creditCardIDValue = value; }
    }
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
    public string CardLink
    {
        get { return cardLinkValue; }
        set { cardLinkValue = value; }
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
    public string DateAdded
    {
        get { return cardDateAddedValue; }
        set { cardDateAddedValue = value; }
    }
    public string TimeAdded
    {
        get { return cardTimeAddedValue; }
        set { cardTimeAddedValue = value; }
    }
    public bool IsRemoved
    {
        get { return cardIsRemovedValue; }
        set { cardIsRemovedValue = value; }
    }
    public string DateRemoved
    {
        get { return cardDateRemovedValue; }
        set { cardTimeRemovedValue = value; }
    }
    public string TimeRemoved
    {
        get { return cardTimeRemovedValue; }
        set { cardTimeRemovedValue = value; }
    }
}
