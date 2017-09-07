<%--  --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>

        <!-- Bootstrap css files -->
    <link rel="stylesheet" href="/css/bootstrap.min.css">
    <link rel ="stylesheet" href="/css/bootstrap-theme.min.css" />
        <link rel="stylesheet" href="/css/bootstrapValidator.min.css" />

        <!-- End of Bootrap css files -->

    <link rel="stylesheet" type="text/css" href="DroversLodgeStyles.css" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 199px;
        }
        .auto-style4 {
            height: 23px;
            width: 199px;
        }
        .auto-style5 {
            width: 309px;
        }
        .auto-style6 {
            height: 23px;
            width: 309px;
        }
        .auto-style7 {
            width: 158px;
        }
        .auto-style8 {
            height: 23px;
            width: 158px;
        }
        .auto-style9 {
            width: 265px;
        }
        .auto-style10 {
            height: 23px;
            width: 265px;
        }
        .auto-style12 {
            height: 20px;
        }
        .auto-style13 {
            width: 199px;
            height: 20px;
        }
        .auto-style14 {
            width: 309px;
            height: 20px;
        }
        .auto-style15 {
            width: 158px;
            height: 20px;
        }
        .auto-style16 {
            width: 265px;
            height: 20px;
        }
        .auto-style17 {
            height: 7px;
        }
        .auto-style18 {
            width: 199px;
            height: 7px;
        }
        .auto-style19 {
            width: 158px;
            height: 7px;
        }
        .auto-style20 {
            width: 265px;
            height: 7px;
        }
    </style>
    <!-- initial recaptcha api was here -->
    <script>
        document.getElementById("btnSignUp").disabled = true;
    </script>

</head>
<body>

    

    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/jquery-3.2.1.min.js"></script>
    <script src="/js/bootstrapValidator.min.js" type="text/javascript"></script>
    <form id="form1" runat="server" method="POST" action="#">
        
        <header class="navbar navbar-inverse navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="#"><h4>Drovers Lodge</h4></a>
        </div>
        <div class="navbar-collapse collapse">

            <ul class="nav navbar-nav navbar-right">
                <li>
                    <p class="navbar navbar-btn">
                       <a href="#"><button type="submit" runat="server" id="lnkbtnMyAccount" class="btn btn-link navbar-btn btn-block" onserverclick="LinkButton2_Click">My Account</button></a>
                    </p>
                </li>
              
                <li>
                      <p class="navbar navbar-btn">
                    <a href="#"><button type="submit" runat="server" id="LinkButton1" class="btn btn-link navbar-btn btn-block" onserverclick="LinkButton1_Click">Return to Homepage</button></a>
                </p>
                </li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
                                <li>
                                        <p class="navbar navbar-btn">
                                                <!-- <a href="#"> <button type="submit" runat="server" class="btn btn-link navbar-btn btn-block" id="LinkButton2" onserverclick="LinkButton1_Click">Log out</button></a> -->
                                        </p>          
                                     </li>         
            </ul>
        </div><!--/.navbar-collapse -->
    </div>
</header>

<div class="btn-group">
  <button type="button" class="btn btn-danger">Action</button>
  <button type="button" class="btn btn-danger dropdown-toggle" data-toggle="dropdown">
    <span class="caret"></span>
    <span class="sr-only">Toggle Dropdown</span>
  </button>
  <ul class="dropdown-menu" role="menu">
    <li><a href="#">Action</a></li>
    <li><a href="#">Another action</a></li>
    <li><a href="#">Something else here</a></li>
    <li class="divider"></li>
    <li><a href="#">Separated link</a></li>
  </ul>
</div>


  
        <div id="wrapper">
          
   
              <div class="container">
    
  
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style6"></td>
                <td class="auto-style8"></td>
                <td class="auto-style10"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                  <!--lnkbtn1 return to homepage was here-->   
                </td>
                <td class="auto-style5">
                    <!--lnkbtnMyAcc was here --> 
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4"></td>
                
                <td class="auto-style6"></td>
                <td class="auto-style8"></td>
                <td class="auto-style10"></td>
                <td class="auto-style2">
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Sign in" Font-Names="Yu Gothic UI Semibold" Font-Underline="True"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label3" runat="server" Text="Sign up" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" Font-Underline="True"></asp:Label>
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style17"></td>
                <td class="auto-style18">
                    <asp:Label ID="Label4" runat="server" Text="Email:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style17">
                    <div class="form-group has-success"></div>

         
                    <input type="email" id="txtLoginEmail" runat="server" autofocus="true" name="email" onchange="checkEmail" placeholder="email" style="width: 248px;" class="form-control form-control-success"></input>
                 
                    <span class="glyphicon glyphicon-ok form-control-feedback"></span>
                    </div>
                </td> 
                <td class="auto-style19">
                    <asp:Label ID="Label7" runat="server" Text="Firstname:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style20">
                    <input type="text" name="txtFirstname"  id="txtFirstname" runat="server" class="form-control" required="required"/>
                </td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Password:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtLoginPassword" runat="server" Width="248px" TextMode="Password" CssClass="form-control" placeholder="password"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label8" runat="server" Text="Surname:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtSurname" class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style5">
                    <label id="txtLoginError" runat="server"></label></td>
                <td class="auto-style7">
                    <asp:Label ID="Label9" runat="server" Text="Telephone Number:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtTelephoneNo" class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <button ID="btnLogin" runat="server" Text="Login" class="btn btn-success" onserverclick="btnLogin_Click">Login</button>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label10" runat="server" Text="Mobile Number:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtMobileNo"  class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label11" runat="server" Text="Postcode:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtPostcode" class="form-control"/> 
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label16" runat="server" Text="Email Address:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <div class="form-group" >
                        <input type="text" id="txtEmail" runat="server" name="email" class="form-control" />
                    </div>
                    
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                   
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
               
                
                <td>&nbsp;</td>
                </tr>
                <tr>
                <td>&nbsp;</td>
                 
       
                
              
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text="Address Line 1:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtAddress1"  class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>

                <td class="auto-style7">
                    <asp:Label ID="Label13" runat="server" Text="Address Line 2:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtAddress2"  class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;
                    <!-- old recaptcha stuff was here -->
                    
                </td>
               <!--required field validator was here -->

                <td class="auto-style7">
                    <asp:Label ID="Label14" runat="server" Text="Address Line 3:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtAddress3"  class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label15" runat="server" Text="Password:" Font-Names="Yu Gothic UI Semibold"></asp:Label>
                </td>
                <td class="auto-style9">
                    <input type="text" runat="server" id="txtSignUpPassword"  class="form-control"/>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7"><asp:Label ID="lblConfirmationCode" runat="server" visible="false" Text="Confirmation Code:" Font-Names="Yu Gothic UI Semibold"></asp:Label></td>
                <td class="auto-style9">  <input type="text" runat="server" id="txtConfirmationCode" visible="false" class="form-control"/> </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                 
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                      
                </td>
                <td>
                   
                <td>&nbsp;</td>
                 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>   
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
       
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
                <td class="auto-style15"><button ID="btnSendCode" runat="server" class ="btn btn-success" disabled="false" onserverclick="sendConfirmationMail_Click" Text="Sign Up">Verify Email</button></td>
                
                <td class="auto-style16"><button ID="btnSignUp" runat="server" class ="btn btn-success" disabled="true" onserverclick="btnSignUp_Click" Text="Sign Up">Sign Up</button> </td>
                <td class="auto-style12">  <button ID="Button1" runat="server" class="btn btn-success" onserverclick="Button1_Click" name="Test values">Test values</button> </td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">
                           <!-- insert recaptcha -->
                    <div id="dvCaptcha">
                    </div>
                    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
                    <script src="https://www.google.com/recaptcha/api.js" async defer></script>

                    <div class="g-recaptcha" data-sitekey="<removed>" data-callback="enableBtn"></div>
                    <script>
                        function enableBtn() {
                         //   document.getElementById("btnSendCode").disabled = false;
                            document.getElementById("btnSignUp").disabled = false;
                            
                        }
                        
                    </script>

                    </div>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
     <div>
   
    </div>
    </form>
 <script>
   /*  document.getElementById("txtEmail").onchange = function () { validateEmail(email) };
     function validateEmailAddress()
     {
         var userEmail = document.getElementById("txtEmail").value;

         if (userEmail == "1") {
             document.getElementById("txtEmail").style.borderColor = "green";
            return false
         }
         else  {
             document.getElementById("txtEmail").style.borderColor = "red";
             return false;
         }
     }*/

  //   document.getElementById("txtEmail").onchange = function () { validateEmail() };
     
     //function validateEmail() {

      //   var re = /^(([^<>()[\]{}'^?\\.,!|//#%*-+=&;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
      //   re.test(document.getElementById("txtEmail").value)
      //   return re.test(document.getElementById("txtEmail").value)
      //   alert("email valid");

    }
 </script>

</body>
    
</html>
