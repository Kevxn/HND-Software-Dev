<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drovers Lodge</title>
    <link rel="stylesheet" type="text/css" href="DroversLodgeStyles.css" runat="server"> 

    <!-- Bootstrap css files -->

    <link rel="stylesheet" href="/css/bootstrap.min.css">
    <link rel ="stylesheet" href="/css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.min.css">

        <!-- End of Bootrap css files -->

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 481px;
        }
        .auto-style8 {
            height: 21px;
        }
        .auto-style11 {
            height: 16px;
        }
        .auto-style12 {
            width: 481px;
            height: 16px;
        }
        .auto-style13 {
            width: 107px;
            height: 16px;
        }
        .auto-style16 {
            height: 21px;
            width: 32px;
        }
        .auto-style18 {
            height: 41px;
        }
        .auto-style19 {
            width: 481px;
            height: 41px;
        }
        .auto-style20 {
            width: 107px;
            height: 41px;
        }
        .auto-style22 {
            height: 13px;
        }
        .auto-style23 {
            width: 481px;
            height: 13px;
        }
        .auto-style24 {
            width: 107px;
            height: 13px;
        }
        .auto-style28 {
            width: 107px;
        }
        .auto-style30 {
            height: 21px;
            width: 481px;
        }
        .auto-style32 {
            height: 21px;
            width: 107px;
        }
        </style>
</head> 

<body>

    <!-- Bootstrap JS Files -->

    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/jquery-3.2.1.min.js"></script>

    <!--End of scripts -->
    <form id="form1" runat="server">
    
    
        
         <header class="navbar navbar-inverse navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="#"><h4>Drovers Lodge</h4><span> <!--<img alt="Drovers Lodge" src="Logos\kevslogo.png" height="65px" style="padding-bottom: 18px"/> --></span></a>
        </div>
        <div class="navbar-collapse collapse">

            <ul class="nav navbar-nav navbar-right">
                <li>
                    <p class="navbar navbar-btn">
                       <a href="#"> <button type="submit" runat="server" class="btn btn-link navbar-btn btn-block" id="LinkButton1"  onserverclick="LinkButton1_Click">Log out</button></a>
                    </p>
                </li>
                <li>
                </li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
                                <li>
                                        <p class="navbar navbar-btn">
                                                 <a href="#"> <button type="submit" runat="server" class="btn btn-link navbar-btn btn-block" id="lnkbtnSignIn" onserverclick="lnkbtnSignIn_Click">Login / Sign up</button></a>
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


       




     
         <div class="container">

        

    <div id="wrapper" col-md-12>
      <!--  <div id="header"> -->
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <!--<td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" Font-Size="X-Large" Text="Drovers Lodge"></asp:Label>
               </td><h2>Drovers Lodge</h2>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td>&nbsp;</td>

                                <td class="auto-style8"></td>
           
                    <ul id="header-nav">
                         <li><a>
                               
                             </a>
                         </li>         
              -->
            <!--    <li>
                
                    <a>
                       
                    </a>
                <li>
                </li>
                <ul>
                </ul>
                -->
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Font-Names="Yu Gothic UI Semibold" Font-Size="Medium" Text="Drovers Lodge guest house is located outside the village of Dervaig on the Isle of Mull. We offer a range of rooms from single to family friendly rooms to cater for all.  " Visible="False"></asp:Label>
                </td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>

<!-- buttons used to be here -->

                </div>
                <td class="auto-style16"></td>
                <td class="auto-style30"></td>
                <td class="auto-style32"></td>
                <td class="auto-style30"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style23">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" Text="Single Room:"></asp:Label>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style23">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" Text="Family Room:"></asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                   <asp:ImageButton ID="btnBookSingleRoom" runat="server" Height="255px" Width="477px" ImageUrl="~/DroversLodgeSingleRoom.jpg" class="img-responsive img-rounded" OnClick="btnBookSingleRoom_Click" />
                </td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="btnBookFamilyRoom" runat="server" Height="255px" Width="477px" ImageUrl="~/DroversLodgeFamilyRoom.jpg" class="img-responsive img-rounded" OnClick="btnBookFamilyRoom_Click" />
                </td>
                <td>
                    &nbsp;</td>
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
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style19">
                    <div id="singleRoomImage">
                    <asp:Label ID="lblMustSignIn" runat="server" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" ForeColor="Red" Text="You must be signed in to book a room at Drovers Lodge." Visible="False"></asp:Label>
                        </div>
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style19">
                    <asp:Label ID="lblSignUpFree" runat="server" Font-Bold="True" Font-Names="Yu Gothic UI Semibold" ForeColor="Red" Text="Sign up for a free Drovers Lodge account." Visible="False"></asp:Label>
                </td>
                <td class="auto-style18">
                    &nbsp;</td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style30">
                    <asp:Label ID="Label4" runat="server"  Font-Bold="True" Font-Names="Yu Gothic UI Semibold" Text="Double Room:"></asp:Label>
                </td>
                <td class="auto-style32">
                    &nbsp;</td>
                <td class="auto-style30"></td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8"></td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="btnBookDoubleRoom" runat="server" Height="255px" Width="477px" ImageUrl="~/DroversLodgeDoubleRoom.jpg" class="img-responsive img-rounded" OnClick="btnBookDoubleRoom_Click" />
                </td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">
                   
                   <p>
                        
                        <asp:label ID="lblWeather" runat="server" Font-Bold="True" Font-Size="Medium" Font-Underline="True"></asp:label>
                        
                    </p>
                    <p>
                        <label id="lblWeatherTemp" runat="server" ></label>
                    </p>
                    <p>
                        <label id="lblWeatherDescription" runat="server"></label>
                    </p>
                    <p>
                        <label id="lblWeatherSunsetTime" runat="server"></label>
                    </p>
                     <p>
                        <label id="lblTitle" runat="server" style="font-size: 14px">Weather data from <a href="http://www.openweathermap.org">openweathermap.org</a></label>
                    </p>
                    
                </td>
                <td>
    
                  <!--  <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Names="Yu Gothic UI Semibold" Text="We also offer delicious meals throughout the day including breakfast, lunch and dinner. "></asp:Label>
    -->
                     
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
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
    
                    &nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
        </table>
   
        </div>
        
    </form>
        
    
    <style>
        .mapTitle{
            font-size: 18px;
            text-align:center;
        }
    </style>
    <p class="mapTitle"><b><u> Where are we? </u></b></p>
               <div id="map" style="width:100%;height:500px"></div>

<script>
function myMap() {
  var myCenter = new google.maps.LatLng(56.590794, -6.192286);
  var mapCanvas = document.getElementById("map");
  var mapOptions = {center: myCenter, zoom: 10};
  var map = new google.maps.Map(mapCanvas, mapOptions);
  var marker = new google.maps.Marker({position:myCenter});
  marker.setMap(map);
}
</script>

<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAca1iPv_0Spx7ZzGkiDJMPYWcok52s8yA&callback=myMap"></script>
        

    <!--footer -->
 <div class="content">
</div>
    <footer id="myFooter">
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <h2 class="logo"><a href="#"> LOGO </a></h2>
                </div>
                <div class="col-sm-2">
                    <h5>Get started</h5>
                    <ul>
                        <li><a href="#">Home</a></li>
                        <li><a href="#">Sign up</a></li>
                        <li><a href="#">Downloads</a></li>
                    </ul>
                </div>
                <div class="col-sm-2">
                    <h5>About us</h5>
                    <ul>
                        <li><a href="#">Company Information</a></li>
                        <li><a href="#">Contact us</a></li>
                        <li><a href="#">Reviews</a></li>
                    </ul>
                </div>
                <div class="col-sm-2">
                    <h5>Support</h5>
                    <ul>
                        <li><a href="#">FAQ</a></li>
                        <li><a href="#">Help desk</a></li>
                        <li><a href="#">Forums</a></li>
                    </ul>
                </div>
                <div class="col-sm-3">
                    <div class="social-networks">
                        <a href="#" class="twitter"><i class="fa fa-twitter"></i></a>
                        <a href="#" class="facebook"><i class="fa fa-facebook"></i></a>
                        <a href="#" class="google"><i class="fa fa-google-plus"></i></a>
                    </div>
                    <button type="button" class="btn btn-default">Contact us</button>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <p>© 2016 Copyright Text </p>
        </div>
    </footer>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <!--end of footer -->


</body>
    
</html>
