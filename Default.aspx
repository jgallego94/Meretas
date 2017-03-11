<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Meretes 2</title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     <link rel="stylesheet" type="text/css" href="Style/SimpleStyle.css">
     <link href="https://fonts.googleapis.com/css?family=Cinzel|Open+Sans+Condensed:300" rel="stylesheet">
 
</head>
<body>
    <div class="row-content">
        
       <div class="col-sm-12" id="background">
           <!--Navigation bar-->
            <nav class="navbar navbar-default" style="height:6.5em; background: rgba(0,0,0,0); border: rgba(0,0,0,0);">
            <div class="container-fluid">
                <div class="navbar-header">
                    <!--Meretas Title top right-->
                    <a class="navbar-brand" href="Default.aspx"><h3 style="color:white;"><span style="color:#ff944d; font-size: 50px;">M</span>ERETAS</h3></a>
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
            <br>
            <br>
            
            <div class="col-sm-12" id="MainContent">
                  
            <div class="Container">
                
             
                <!--Page Heading-->
               <div class="Jumbotron page-heading" id="Shout">
                <h1>Find your <span style="color:#ff944d;">perfect</span> credit card</h1>
                <br>
                <div class="col-sm-12" id="CenterPane">
                <br><br>
                <p>
                    <!--Page information-->
                </p>
                <br><br><br>
                    <a href="Questions/Question1.aspx" role="button" class="btn btn-lg" id="startButton">Get Started</a>
                <!--  <form runat="server">
                    <asp:Button runat="server" Text="Get Started" OnClick="Button1_Click" ID="startButton"/></form> -->
                </div>
               </div>
            </div>
            </div>
            

        <div class="col-sm-12"id="footer">
            
        </div>
       </div> 
       
     
     </div>
</body>
</html>
