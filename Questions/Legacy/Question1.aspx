﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question1.aspx.cs" Inherits="Questions_Question1" %>

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
        
        /* Reference for innerHTML
   
        function load_newTestCase()
            {

                document.getElementById("main").innerHTML =
                        '<object type="text/html" data="newTestCasePage.jsp"\n\
                    style="width:100%; height:100%;"></object>';

            }
    }); */

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
            
             <!--Question div-->
             <div class="col-sm-2">

             </div>
             <div class="col-sm-8" id="RightQuestion">
                 <br />
                 <hr class="style-eight" />
                 
                 <div class="col-sm-12" id="FormWrapper">
                     <h2>What type of card are you looking for?</h2>

                 <form id="QuestionForm">
                     <br />
                   <div class="radio">
                     <input type="radio" id="Personal" name="q1" value="1"  />
                     <label for="Personal"> Personal</label>
                     <br /><br /><br />
                     <input id="Business" type="radio"  name="q1" value="2" />
                     <label for="Business"> Business</label>
                   </div>

                     <div class="col-sm-12" id="control">
                         <a href="Question2.aspx" role="button" class="btn btn-lg" id="nextButton">Next</a>
                     
                     </div>
                     
                 </form>
                     </div>
             </div>
             <div class="col-sm-2">

             </div>
         </div>    
     </div>
</body>
</html>
