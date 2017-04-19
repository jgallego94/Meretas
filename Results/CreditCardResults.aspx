<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreditCardResults.aspx.cs" Inherits="Results_CreditCardResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Meretes 2</title>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../Style/SimpleStyle.css"/>
    <link href="https://fonts.googleapis.com/css?family=Cinzel|Open+Sans+Condensed:300" rel="stylesheet"/>
</head>
<body>
    <div class="row-content">
         <div class="col-sm-12" id="QuestionBackground">
             <!--Navigation bar-->
             <nav class="navbar navbar-default" style="height:6.5em; background: rgba(0,0,0,0); border: rgba(0,0,0,0);">
                 <div class="container-fluid">
                     <div class="navbar-header">
                         <!--Meretas Title top right-->
                         <a class="navbar-brand" href="../Default.aspx"><h3 style="color:white;"><span style="color:#ff944d; font-size: 50px;">M</span>ERETAS</h3></a>
                     </div>
                     <div class="collapse navbar-collapse">
                         <ul class="nav navbar-nav navbar-right">
                             <li><a href="#">Home</a></li>
                             <li><a href="#">About</a></li>
                             <li><a href="#">Compare</a></li>
                         </ul>
                     </div>
                 </div>
             </nav>
            >
             <!--Question div-->
             <div class="col-sm-2">

             </div>
             <div class="col-sm-8" id="ResultPane">
                 <br />
                 <hr class="style-eight" />
                 <div class="col-sm-6" id="cardOne" style="border-right: solid 1px; border-color:#ff944d; font-size:15px; height: 45vh;">
                        <h3><span runat="server" id="cardName1"></span></h3>
                     <!--<img style="margin:20px;" src="https://www.tdcanadatrust.com/images/ccr2/ccr2-classic-travel-banner-card.jpg" /> -->
                     <asp:Image ID="cardImage1" style="margin:20px;" ImageUrl="https://www.tdcanadatrust.com/images/ccr2/ccr2-classic-travel-banner-card.jpg" runat="server" />
                      <asp:Table runat="server" CssClass="table table-striped table-condensed" ID="cardtable1">
                        
                         <asp:TableRow>
                             <asp:TableCell ColumnSpan="2">
                                 <asp:HyperLink ID="cardLink1" runat="server">Apply Now</asp:HyperLink>
                             </asp:TableCell>
                         </asp:TableRow>
                         <asp:TableRow>
                             <asp:TableCell>
                                 <h4>Card Type: </h4>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <span runat="server" id="cardType1"></span>
                             </asp:TableCell>
                         </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell>
                                  <h4>Features: </h4>
                              </asp:TableCell>
                              <asp:TableCell>
                                  <span runat="server" id="cardFeatures1"></span>
                              </asp:TableCell>
                          </asp:TableRow>
                     </asp:Table>
                     
                 </div>

                 <div class="col-sm-6" id="cardTwo" style=" font-size:15px; height: 45vh;">
                     <h3><span runat="server" id="cardName2"></span></h3>

                    <!-- <img id="cardImage1" style="margin:20px; height: 19vh; width: 33vh;" src="https://www.rbcroyalbank.com/services/cards/_assets-custom/images/avion/card-avion.png" /> -->
                     <asp:Image ID="cardImage2"  style="margin:20px; height: 19vh; width: 33vh;" ImageUrl="https://www.rbcroyalbank.com/services/cards/_assets-custom/images/avion/card-avion.png" runat="server" />
                      <asp:Table runat="server" CssClass="table table-striped table-condensed" ID="cardTable2">
                        
                         <asp:TableRow>
                             <asp:TableCell ColumnSpan="2">
                                 <asp:HyperLink ID="cardLink2" runat="server">Apply Now</asp:HyperLink>
                             </asp:TableCell>
                         </asp:TableRow>
                         <asp:TableRow>
                             <asp:TableCell>
                                 <h4>Card Type: </h4>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <span runat="server" id="cardType2"></span>
                             </asp:TableCell>
                         </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell>
                                  <h4>Features: </h4>
                              </asp:TableCell>
                              <asp:TableCell>
                                  <span runat="server" id="cardFeatures2"></span>
                              </asp:TableCell>
                          </asp:TableRow>
                     </asp:Table>
                
             </div>
             <div class="col-sm-2">

             </div>
         </div>    
     </div>
</body>
</html>
