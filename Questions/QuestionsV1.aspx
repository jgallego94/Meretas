<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionsV1.aspx.cs" Inherits="Questions_QuestionsV1" %>
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
            
             <!--Question div-->
             <div class="col-sm-2">

             </div>
             <div class="col-sm-8" id="RightQuestion">
                 <br />
                 <hr class="style-eight" />
                 
                 <div class="col-sm-12" id="FormWrapper">
  

                 <form id="QuestionForm">
                     <div id="formCarousel" class="carousel slide" data-ride="carousel">
                         <ol class="carousel-indicators">
                             <li data-target="#formCarousel" data-slide-to="0" class="active"></li>
                             <li data-target="#formCarousel" data-slide-to="1"></li>
                             <li data-target="#formCoursel" data-slide-to="2"></li>
                             <li data-target="#formCoursel" data-slide-to="3"></li>
                             <li data-target="#formCoursel" data-slide-to="4"></li>
                             <li data-target="#formCoursel" data-slide-to="5"></li>
                             <li data-target="#formCoursel" data-slide-to="6"></li>
                         </ol>

                         <div class="carousel-inner">
                             <div class="item-active">
        
                                 <h2>What type of card are you looking for?</h2>

                                  <br />
                                  <div class="radio">
                                    <input type="radio" id="Personal" name="q1" value="1"  />
                                    <label for="Personal"> Personal</label>
                                     <br /><br /><br />
                                     <input id="Business" type="radio"  name="q1" value="2" />
                                    <label for="Business"> Business</label>
                              </div>
                             </div>
                         </div>
                     </div>
               
                 <!-- 

<html>
<head>
<title>Bootstrap carousel</title>
</head>
<body>
<div id="myCarousel" class="carousel slide" data-ride="carousel">

<ol class="carousel-indicators">
<li data-target="#myCarousel" data-slide-to="0" class="active"></li>
<li data-target="#myCarousel" data-slide-to="1"></li>
<li data-target="#myCarousel" data-slide-to="2"></li>
</ol>

<div class="carousel-inner">

<div class="item active">
<h2>Slide 1</h2>
<div class="carousel-caption">
<h3>First slide label</h3>
<p>Lorem ipsum dolor sit amet consectetur…</p>
</div>
</div>

<div class="item">
<h2>Slide 2</h2>
<div class="carousel-caption">
<h3>Second slide label</h3>
<p>Aliquam sit amet gravida nibh, facilisis gravida…</p>
</div>
</div>

<div class="item">
<h2>Slide 3</h2>
<div class="carousel-caption">
<h3>Third slide label</h3>
<p>Praesent commodo cursus magna vel…</p>
</div>
</div>
</div>

<a class="carousel-control left" href="#myCarousel" data-slide="prev">
<span class="glyphicon glyphicon-chevron-left"></span>
</a>
<a class="carousel-control right" href="#myCarousel" data-slide="next">
<span class="glyphicon glyphicon-chevron-right"></span>
</a>
</div>
</body>
</html>-->
                 </form>
                     </div>
             </div>
             <div class="col-sm-2">

             </div>
         </div>    
     </div>
</body>
</html>
