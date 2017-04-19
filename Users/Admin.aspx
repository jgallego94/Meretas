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
             <div class="col-sm-5">
                 <div class="col-sm-12" id="addCreditCard"  style="border: solid 1px; border-color: white; margin: 10px;">
                 <h2 style="color:#ff944d; text-shadow: 0 0 2px #fff;">Add Credit Card</h2>
                 
                     <div class="form-group" style="color:white;">
                       <span style="color:#ff944d; padding-right:5px;" class="glyphicon glyphicon-credit-card"> </span> <asp:TextBox CssClass="form-control" ID="cardName" runat="server" placeholder="Credit Card Name"></asp:TextBox>
                         
                     </div>
                     <div class="form-group" style="color:white;">
                          <span style="color:#ff944d; padding-right:5px;" class="glyphicon glyphicon-paperclip"></span><asp:TextBox CssClass="form-control" ID="relLink" runat="server" placeholder="Redirect Link"></asp:TextBox>
                     </div>
                     <div class="form-group" style="color:white;">
                           <span style="color:#ff944d; padding-right:5px;" class="glyphicon glyphicon-list-alt"></span><asp:TextBox CssClass="form-control" ID="addCardID" runat="server" placeholder="Credit Card ID"></asp:TextBox>
                     </div>
                 <br />
                     <asp:Button id="addButton" CssClass="btn" Text="Add" OnClick="addButton_Click" runat="server" style="margin-bottom:10px;"/> 
               <br />
                 </div>
                 
                 <div class="col-sm-12" id="deleteCreditCard"  style="border: solid 1px; border-color: white; margin:10px;">
                     <h2 style="color:#ff944d; text-shadow: 0 0 2px #fff;">Delete Credit Card</h2>
                     <div class="form-group" style="color:white;">
                          <span style="color:#ff944d; padding-right:5px;" class="glyphicon glyphicon-list-alt"></span><asp:TextBox CssClass="form-control" ID="delCardID" runat="server" placeholder="Credit Card ID"></asp:TextBox>
                     </div>
                      <asp:Button CssClass="btn" id="delButton"  Text="Delete" OnClick="delButton_Click" runat="server" style="margin-bottom:10px;"/> 
                 </div>
             </div>

             </div>


         </div>    
     </div>
        </form>
</body>
</html>
