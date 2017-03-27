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
            >
             <!--Question div-->
             <div class="col-sm-2">

             </div>
             <div class="col-sm-8" id="ResultPane">
                 <br />
                 <hr class="style-eight" />
                 
                 <table class="table">
                     <thead>
                         <th>
                             Card 1
                         </th>
                         <th>
                             Card 2
                         </th>
                     </thead>
                     <tr>
                         <td>TD Cash Back MasterCard Credit Card</td>
                        
                         <td>TD Emerald Visa Card</td>
                     </tr>
                     <tr>
                         <td>
                             <img src="https://www.tdcanadatrust.com/images/ccr2/ccr2-cash-back-card.jpg" />
                         </td>
                     
                         <td>
                             <img src="https://www.tdcanadatrust.com/images/ccr2/ccr2-emerald-card.jpg" />
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <a href="https://www.tdcanadatrust.com/products-services/banking/credit-cards/view-all-cards/cashback-master-card.jsp">Apply Now</a>
                         </td>
                     
                         <td>
                             <a href="https://www.tdcanadatrust.com/products-services/banking/credit-cards/view-all-cards/emerald-card.jsp">Apply Now</a>
                         </td>

                     </tr>
                     <tr>
                         <td>
                             Cash Back
                         </td>
                      
                         <td>
                             Keeping Balance
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Interest = 19.99%
                         </td>
                         <td>
                             Interest = 12.75%
                         </td>
                     </tr>
                 </table>
             </div>
             <div class="col-sm-2">

             </div>
         </div>    
     </div>
</body>
</html>
