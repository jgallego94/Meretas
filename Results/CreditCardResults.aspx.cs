using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Results_CreditCardResults : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<CreditCard> cardList = (List<CreditCard>)Application["cardList"];

        cardName1.InnerText = " " + cardList[0].CardName;
        cardLink1.NavigateUrl = cardList[0].CardLink;
        cardType1.InnerText = " " + cardList[0].CardType;
        cardFeatures1.InnerText = " " + cardList[0].Features;

        cardName2.InnerText = " " + cardList[1].CardName;
        cardLink2.NavigateUrl = cardList[1].CardLink;
        cardType2.InnerText = " " + cardList[1].CardType;
        cardFeatures2.InnerText = " " + cardList[1].Features;
   
    }
}