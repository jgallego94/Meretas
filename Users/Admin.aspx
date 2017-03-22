<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Users_Admin" %>

<%if (Request.Cookies["UserName"] == null)
    {
        Response.Redirect("../Default.aspx");
    }
    else
    {
        WelcomeLabel.Text = Server.HtmlEncode(Request.Cookies["UserName"].Value);
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
                        <li><a href="../Default.aspx" id="login">Logout</a></li>
                        <li><a href="#">About</a></li>
                        <li><a href="#">Compare</a></li>           
                    </ul>
                </div>
            </div>
        </nav>
             <h1 style="color:white;">Welcome <asp:Label ID="WelcomeLabel" runat="server"></asp:Label></h1>


         </div>    
     </div>
</body>
</html>
