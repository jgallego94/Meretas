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
  
    <script>
        
        function check()
        {
            var ele = document.getElementsByName("q");
            var flag = 0;

            for(var i = 0; i < ele.length; i++)
            {
                if(ele[i].checked)
                {
                    flag = 1;
                }
            }

            if(flag == 1)
            {
                document.getElementById('nextButton').style.visiblity = 'visible';
            }
        }

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
                     <div class="carousel-inner col-sm-12" runat="server" id="dynamicSurvey">
                                   
                     </div>

                 </div>
              </form>

             </div>         
     </div>
</body>
</html>