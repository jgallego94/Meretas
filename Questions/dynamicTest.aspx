<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dynamicTest.aspx.cs" Inherits="Questions_dynamicTest" %>

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
             <br /><br />
             <form id="QuestionForm" runat="server">
                 <div id="formCarousel" style="border-radius:25px;" class="carousel slide" data-ride="carousel" data-interval="false" data-wrap="false">
                     <div class="carousel-inner">
                         <div runat="server" class="col-sm-12" id="dynamicSurvey">

                         <%--<div class="item active">
                             <div class="col-sm-2">

                             </div>
                             <div class="col-sm-8" id="Question">
                                 <br />
                                 <hr class="style-eight" />

                                  <h2><asp:Label ID="QuestionText" runat="server" CssClass="QuestionText"></asp:Label></h2>     
                                                        
                                 <a href="#formCarousel" role="button" class="btn btn-lg" id="nextButton" data-slide="next">Next</a>

                             </div>
                             <div class="col-sm-2">

                             </div>
                         </div>--%>
                         </div>
                         <%--<div class="item">
                             <div class="col-sm-2">

                             </div>
                             <div class="col-sm-8" id="Question">
                                 <br />
                                 <hr class="style-eight" />
                                 <h2>What is your current employment status?</h2>

                                 <div class="radio">
                                     <br />
                                     <input id="FullTime" type="radio" name="q2" value="1" />
                                     <label for="FullTime">Full Time</label><br />
                                     <br />
                                     <input id="SelfEmployed" type="radio" name="q2" value="2" />
                                     <label for="SelfEmployed">Self Employed</label><br />
                                     <br />
                                     <input id="Student" type="radio" name="q2" value="3" />
                                     <label for="Student">Student</label><br />

                                       
                                </div>
                                 <a href="#formCarousel" role="button" class="btn btn-lg" id="nextButton" data-slide="next">Next</a>
                             </div>
                             <div class="col-sm-2">

                             </div>
                         </div>--%>

                         


                        
                     </div>

                 </div>
              </form>

             </div>         
     </div>
</body>
</html>