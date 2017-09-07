<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCard.aspx.cs" Inherits="AddCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <link rel="stylesheet" href="/css/bootstrap.min.css" />
         <link rel ="stylesheet" href="/css/bootstrap-theme.min.css " />
         <script src="/js/bootstrap.min.js"></script><script src="/js/jquery-3.2.1.min.js"></script>
     <!-- End of Bootrap css files -->
    <!-- Bootstrap JS Files -->
</head>
<body>

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
                       <a><button type="submit" runat="server" id="lnkbtnHomepage" class="btn btn-link navbar-btn btn-block" onserverclick="lnkbtnHomepage_Click">Manager Home</button></a>
                    </p>
                </li>
                <li>
                </li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
                                <li>
                                        <p class="navbar navbar-btn">
                                               <!-- button goes here -->  
                                        </p>          
                                     </li>         
            </ul>
        </div><!--/.navbar-collapse -->
    </div>
</header>
     <div class="container" style="margin:auto">
    <style>body{padding-top:75px;}</style>
    <form id="form1" runat="server">
        

     
       
            
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
                                <input id="cardNumber" runat="server" autofocus="" class="form-control" placeholder="Valid Card Number" onkeypress='return event.charCode >= 48 && event.charCode <= 57' type="text" /> <span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-7 col-md-7">
                                <div class="form-group">
                                    <label for="expityMonth">
                                    EXPIRY DATE</label>
                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                          <select class="form-control" runat="server" id="expiryDateMonth" style="width: auto" >
                                              <option value="0">01</option>
                                              <option value="1">02</option>
                                              <option value="2">03</option>
                                              <option value="0">04</option>
                                              <option value="1">05</option>
                                              <option value="2">06</option>
                                              <option value="0">07</option>
                                              <option value="1">08</option>
                                              <option value="2">09</option>
                                              <option value="0">10</option>
                                              <option value="1">11</option>
                                              <option value="2">12</option>
                                          </select>
                                         
                                    </div>
                                       
                                    <div class="col-xs-6 col-lg-6 pl-ziro">
                                         <select class="form-control" runat="server" id="expiryDateYear" style="width: auto" >
                                              <option value="0">17</option>
                                              <option value="1">18</option>
                                              <option value="2">19</option>
                                              <option value="0">20</option>
                                              <option value="1">21</option>
                                              <option value="2">22</option>
                                              <option value="0">23</option>
                                              <option value="1">24</option>
                                              <option value="2">25</option>
                                              <option value="0">26</option>
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
                </div>
            <a class="btn btn-success btn-lg btn-block" id="btnAddCard" runat="server" onserverclick="btnAddCard_Click" role="button">Save Card</a>
             
                <br/>
                
            </div>
            <br />
            <br />
            <br />
            
           <label id="lblCardError" runat="server"></label>
   
    </form>
    </div>
</body>
</html>
