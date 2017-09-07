<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBooking.aspx.cs" Inherits="ViewAccount"  EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 7px;
        }
        .auto-style4 {
            width: 128px;
        }
        .auto-style5 {
            width: 116px;
        }
        .auto-style7 {
            height: 20px;
        }
        .auto-style10 {
            width: 70px;
            height: 20px;
        }
        .auto-style12 {
            width: 20px;
        }
        .auto-style13 {
            width: 20px;
            height: 20px;
        }
        .auto-style14 {
            width: 142px;
        }
        .auto-style15 {
            height: 20px;
            width: 142px;
        }
        .auto-style16 {
            width: 70px;
        }
        .auto-style18 {
            width: 194px;
        }
        .auto-style19 {
            height: 20px;
            width: 194px;
        }
        .auto-style20 {
            width: 40px;
        }
        </style>
    <link rel="stylesheet" href="/css/bootstrap.min.css">
    <link rel ="stylesheet" href="/css/bootstrap-theme.min.css">

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <script src="https://www.paypalobjects.com/api/checkout.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/4.4.0/bootbox.min.js"></script>
    <script>
        function showConfirmBox() {
            //   bootbox.alert({ message: "This is the small alert!",size: 'small'});
            alert("Room Booked");
        }
    </script>
</head>
<body>

        <!-- Bootstrap JS Files -->

    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/jquery-3.2.1.min.js"></script>
    <script src="https://js.stripe.com/v3/"></script>

    <!--End of scripts -->
    <form id="form1" runat="server">
    <div class="container">
     

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

            <ul class="nav navbar-nav navbar-left">
                <li>
                    <p class="navbar navbar-btn">
                       <a href="#"> <button type="button" id="btnHomepage" runat="server" class="btn btn-link navbar-btn btn-block" onserverclick="btnGoHomepage_Click">Homepage</button></a>
                    </p>
                </li>
                <li>
                </li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
                                <li>
                                        <p class="navbar navbar-btn">
                                                 <!-- button goes here maybe wrap with a tag-->
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


    <table class="auto-style1">
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label1" runat="server" Text="Your Customer ID:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblShowCustomerID" runat="server"></asp:Label>
            </td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <label id="hiddenlblRoomChosen" runat="server" class="auto-style20"></label>
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
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style14">
                <asp:Label ID="lblCardDeclined" runat="server"></asp:Label>
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label2" runat="server" Text="Booking Reference:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblShowBookingID" runat="server"></asp:Label>
            </td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
         </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label4" runat="server" Text="Arrival Date:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblShowArrivalDate" runat="server"></asp:Label>
            </td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label5" runat="server" Text="Departure Date:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblShowDepartureDate" runat="server"></asp:Label>
            </td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
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
        </tr>
        <tr>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label8" runat="server" Text="Room Type:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblShowRoomType" runat="server"></asp:Label>
            </td>
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
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
        </tr>
        <tr>
            <td class="auto-style13">
 
                &nbsp;</td>
            <td class="auto-style19">
 
                <asp:Label ID="Label10" runat="server" Text="Board:"></asp:Label>
 
            </td>
            <td class="auto-style7">
 
                <asp:Label ID="lblShowBoard" runat="server"></asp:Label>
 
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td class="auto-style10"></td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
        </tr>
         
                
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">
                <asp:Label ID="Label12" runat="server" Text="Meals Purchased:"></asp:Label>
                &nbsp;&nbsp;
                </button>
            <td>
               
                <asp:Label ID="lblShowMeals" runat="server"></asp:Label>
               
            </td>
            
            <td class="auto-style14">
                &nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
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
        <br />
        </div>
        <div class="container">
        <div class="col-6 col-md-4">
        <div class="panel panel-default">
                    <div class="panel-heading">
                        
                        <h3 class="panel-title">Payment Details </h3>
                        <div class="checkbox pull-right">
                            <label>
                            <input type="checkbox" /> Remember
                            </label>
                        </div>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <label for="cardNumber">
                            CARD NUMBER</label>
                            <div class="input-group">
                                <input id="cardNumber" runat="server" autofocus="" class="form-control" placeholder="Valid Card Number" type="text" /> <span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-7 col-md-7">
                                <div class="form-group">
                                    <label for="expityMonth">
                                    EXPIRY DATE</label>
                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                          <select class="form-control" runat="server" id="expiryDateMonth" style="width: auto" >
                                              <option value="01">01</option>
                                              <option value="02">02</option>
                                              <option value="03">03</option>
                                              <option value="04">04</option>
                                              <option value="05">05</option>
                                              <option value="06">06</option>
                                              <option value="07">07</option>
                                              <option value="08">08</option>
                                              <option value="09">09</option>
                                              <option value="10">10</option>
                                              <option value="11">11</option>
                                              <option value="12">12</option>
                                          </select>
                                         
                                    </div>
                                       
                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                         <select class="form-control" runat="server" id="expiryDateYear" style="width: auto" >
                                              <option value="17">17</option>
                                              <option value="18">18</option>
                                              <option value="19">19</option>
                                              <option value="20">20</option>
                                              <option value="21">21</option>
                                              <option value="22">22</option>
                                              <option value="23">23</option>
                                              <option value="24">24</option>
                                              <option value="25">25</option>
                                              <option value="26">26</option>
                                          </select>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xs-5 col-md-5 pull-right">
                                <div class="form-group">
                                    <label for="cvCode">
                                    CV CODE</label>
                                    <input id="cvCode" runat="server" class="form-control" placeholder="CV" type="password" />
                                </div>
                            </div>
                        </div>
                    </div>

                         <!--PAYPAL PAYMENT CODE-->
          
                    
            <!--END OF PAYPAL PAYMENT CODE -->

            <!-- STRIPE PAYMENT -->

          <!--  <form action="confirmStripePayment" method="POST" id="stripeForm">
                <script
                     src="https://checkout.stripe.com/checkout.js" class="stripe-button"
                     data-key="pk_test_6pRNASCoBOKtIshFeQd4XMUh"
                     data-amount="5500"
                     data-currency="gbp"
                     data-name="Drovers Lodge"
                     data-description="Book your room"
                     data-image="https://stripe.com/img/documentation/checkout/marketplace.png"
                     data-locale="auto"
                     data-post-code="true">


                   
             </script>
                
                
            </form>-->
            <small class="text-muted">If your card is saved with Drovers Lodge, just click pay without entering details.</small>
            <br />
            <button ID="ChargeCard" runat="server" class="btn btn-success" onserverclick="btnPayStripe_Click" style="display:inline-block; text-align:center">Pay (Stripe)</button>
          


            <!-- END OF STRIPE PAYMENT -->
          
            
               
                <br/>
            <button type="button" id="btnPay"  onserverclick="btnPay_Click" name="btnPay" runat="server" class="btn btn-success" style="display:inline-block; text-align:center">Pay (Drovers Lodge)</button>

            <label id="lblStripeError" runat="server"></label>
              </div>
               <!-- <a class="btn btn-success btn-lg btn-block" runat="server" onserverclick="btnPay_Click" role="button">Pay</a>-->
            </div>

           
            <br />
            <br />
            <br />
<!-- CARD PAYMNET CODE -->

     
  
            </div>
            </div>
         </div>
    </form>
</body>
</html>
