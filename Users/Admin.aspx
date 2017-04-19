<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Users_Admin" %>

<%if (Request.Cookies["MemberID"] == null || Request.Cookies["isAdmin"].Value.Equals("0"))
    {
      Response.Redirect("../Default.aspx");
    }
    else
    {
      WelcomeLabel.Text = Server.HtmlEncode(Request.Cookies["MemberID"].Value);
    }
%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Meretes 2</title>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../Style/SimpleStyle.css"/>
    <link href="https://fonts.googleapis.com/css?family=Cinzel|Open+Sans+Condensed:300" rel="stylesheet"/>
  
    <script type="text/javascript">

    </script>
</head>
<body>
    <form runat="server">

    
   
    <div class="row-content">
         <div class="col-sm-12" id="UserBackground">
             <nav class="navbar navbar-default" style="height:6.5em; background: rgba(0,0,0,0); border: rgba(0,0,0,0); color:white;">
            <div class="container-fluid">
                <div class="navbar-header" id="Meretas">
                    <!--Meretas Title top right-->
                    <a class="navbar-brand" href="../Default.aspx"><h3 style="color:white;"><span style="color:#ff944d; font-size: 50px;">M</span>ERETAS</h3></a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right" >
                        <li><asp:Button ID="Logout" Text="Logout" cssClass="link" runat="server" OnClick="Logout_Click"/></li>
                        <!--<li><a href="../Default.aspx" id="login">Logout</a></li> -->
                        <li><a href="#">About</a></li>
                        <li><a href="#">Compare</a></li>           
                    </ul>
                </div>
            </div>
        </nav>
             <h1 style="color:white;">Welcome admin  <asp:Label ID="WelcomeLabel" runat="server"></asp:Label></h1>
             <br /><br />
             <div class="col-sm-7">
                 <div class="col-sm-12" id="addCreditCard"  style="border: solid 1px; border-color: #ffffff; margin: 10px;">

                 <h2 style="color:#ffffff; text-shadow: 0 0 2px #000;">Add Credit Card</h2>
                 <div class="col-sm-4">
                     <asp:Table runat="server" style="margin: 10px;">
                         <asp:TableRow>
                             
                             <asp:TableCell>
                                  <asp:TextBox CssClass="form-control" ID="cardName" runat="server" placeholder="Credit Card Name"></asp:TextBox><br />
                             </asp:TableCell>
                         </asp:TableRow>
                         <asp:TableRow>
                           
                             <asp:TableCell>
                                 <asp:TextBox CssClass="form-control" ID="relLink" runat="server" placeholder="Redirect Link"></asp:TextBox><br />
                             </asp:TableCell>
                         </asp:TableRow>
                         <asp:TableRow>
                             <asp:TableCell>
                                  <asp:DropDownList CssClass="form-control dropdown" ID="cardType" runat="server">
                                              <asp:ListItem Text="Credit Card Type" Value="0"></asp:ListItem>
                                              <asp:ListItem Text="Personal" Value="Personal"></asp:ListItem>
                                              <asp:ListItem Text="Buisness" Value="Buisness"></asp:ListItem>
                                          </asp:DropDownList>
                                 </asp:TableCell>
                         </asp:TableRow>
                     </asp:Table>
                     </div>
                     <div class="col-sm-8">
                         <asp:Table runat="server"  style="margin: 10px;">
                                 
                             <asp:TableRow>
                                 <asp:TableCell>
                                     <asp:DropDownList CssClass="form-control dropdown" ID="cardEmploy" runat="server">
                                         <asp:ListItem Text="Employment Status" Value="0"></asp:ListItem>
                                         <asp:ListItem Text="Full Time" Value ="Full Time"></asp:ListItem>
                                         <asp:ListItem Text="Self-Employed" Value="Self-Employed"></asp:ListItem>
                                         <asp:ListItem Text="Student" Value="Student"></asp:ListItem>
                                     </asp:DropDownList><br />
                                 </asp:TableCell>
                             </asp:TableRow>
                             <asp:TableRow>
                                 <asp:TableCell>
                                     <asp:DropDownList CssClass="form-control dropdown" ID="cardFeatures" runat="server">
                                         <asp:ListItem Text="Features" Value="0"></asp:ListItem>
                                         <asp:ListItem Text="Travel Rewards" Value="Travel Rewards"></asp:ListItem>
                                         <asp:ListItem Text="Auto/Gas" Value="Auto/Gas"></asp:ListItem>
                                         <asp:ListItem Text="Cash Back" Value="Cash Back"></asp:ListItem>
                                     </asp:DropDownList><br />
                                 </asp:TableCell>
                             </asp:TableRow>
                             <asp:TableRow>
                                 <asp:TableCell>
                                     <asp:DropDownList CssClass="form-control dropdown" ID="cardBalance" runat="server">
                                         <asp:ListItem Text="Balance" Value="0"></asp:ListItem>
                                         <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                                         <asp:ListItem Text="No" Value="No"></asp:ListItem>
                                     </asp:DropDownList>
                                 </asp:TableCell>
                             </asp:TableRow>
                         </asp:Table>
                     </div>
                  
                 <br /><br />
                     <asp:Button id="addButton" CssClass="btn" Text="Add" OnClick="addButton_Click" runat="server" style="margin:10px;"/> 
               <br />
                 </div>
                 
                 <div class="col-sm-12" id="deleteCreditCard"  style="border: solid 1px; border-color: #ffffff; margin:10px;">
                     <h2 style="color:#ffffff; text-shadow: 0 0 2px #000;">Delete Credit Card</h2>

                     <asp:Table runat="server">
                         <asp:TableRow>
                           
                             <asp:TableCell>
                                  <asp:TextBox CssClass="form-control" ID="delCardID" runat="server" placeholder="Credit Card ID"></asp:TextBox><br />
                             </asp:TableCell>
                         </asp:TableRow>
                     </asp:Table>
             
                      <asp:Button CssClass="btn" id="delButton"  Text="Delete" OnClick="delButton_Click" runat="server" style="margin-bottom:10px;"/> 
                 </div>
             </div>

             </div>


         </div>    
     </div>
        </form>
</body>
</html>
