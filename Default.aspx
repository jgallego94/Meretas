<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Meretes 2</title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>  
     <link href="https://fonts.googleapis.com/css?family=Cinzel|Open+Sans+Condensed:300" rel="stylesheet">
     <link rel="stylesheet" type="text/css" href="Style/SimpleStyle.css">
 
</head>
<body>

    <script type="text/javascript">
        
        $(function () {
            $("#login").click(function () {
                $("#CenterPane").toggleClass("CenterPaneChange");
                $("#LoginPane").toggleClass("LoginPaneChange");
                $("#Meretas").toggleClass("MeretasAnim");
            });
        });

    </script>

    <div class="row-content">
        
       <div class="col-sm-12" id="background">
           <!--Navigation bar-->
            <nav class="navbar navbar-default" style="height:6.5em; background: rgba(0,0,0,0); border: rgba(0,0,0,0); color:white;">
            <div class="container-fluid">
                <div class="navbar-header" id="Meretas">
                    <!--Meretas Title top right-->
                    <a class="navbar-brand" href="Default.aspx"><h3 style="color:white;"><span style="color:#ff944d; font-size: 50px;">M</span>ERETAS</h3></a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav navbar-right" >
                        <li><a href="#" id="login">Login</a></li>
                        <li><a href="#">About</a></li>
                        <li><a href="#">Compare</a></li>
                        <!--<input type="button" value="Totally Legit Login" id="login" /> -->
                    </ul>
                </div>
            </div>
        </nav>
         
            <br>
            <br>
            
            <div class="col-sm-12" id="MainContent">
                  
            <div class="Container" id="CenterContent">
                
                <div class="col-sm-12" id="CenterPane">
                <!--Page Heading-->

               <div class="Jumbotron page-heading" id="Shout">
                <h1>Find your <span style="color:#ff944d;">perfect</span> credit card</h1>
                <br>
                <br><br>
                <p>
                    <!--Page information-->
                </p>
                <br><br><br>
                    <a href="Questions/Question1.aspx" role="button" class="btn btn-lg" id="startButton">Get Started</a>

                </div>

               </div>
               
                   <div class="col-sm-4" id="LoginPane">
                       <form id="LoginForm" runat="server">
                           <div class="form-group">

                       <asp:Table ID="LoginTabel" runat="server">
                           <asp:TableRow>
                               <asp:TableCell>
                                    <span style="color:#ff944d;" class="glyphicon glyphicon-user"> </span>
                               </asp:TableCell>
                               <asp:TableCell>
                                   <asp:TextBox CssClass="form-control" ID="Email" runat="server"></asp:TextBox>
                               </asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell>
                                   <br />
                               </asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell>
                                   <span style="color:#ff944d;" class="glyphicon glyphicon-lock"> </span>
                               </asp:TableCell>
                               <asp:TableCell>
                                   <span></span><asp:TextBox CssClass="form-control" ID="password" TextMode="Password" runat="server"></asp:TextBox><br />
                               </asp:TableCell>
                           </asp:TableRow>
                           <asp:TableRow>
                               <asp:TableCell>
                                   <span> </span>
                               </asp:TableCell>
                               <asp:TableCell>
                                   <asp:Button CssClass="btn btn-sm" id="loginButton" OnClick="Login_Click" Text="Login" runat="server" />
                               </asp:TableCell>
                              
                           </asp:TableRow>
                       </asp:Table>
                       </div>
                      </form>
                  

                   </div>
              

               </div>

            </div>

           
               
            </div>

            
            

        <div class="col-sm-12"id="footer">
            
        </div>
       </div> 
       
</body>
</html>
