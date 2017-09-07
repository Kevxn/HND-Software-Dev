<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manager.aspx.cs" Inherits="Manager" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manager Home</title>
     <link rel="stylesheet" href="/css/bootstrap.min.css"/>
     <link rel ="stylesheet" href="/css/bootstrap-theme.min.css"/>
</head>
<body>

    <form class="form-horizontal" id="bookingForm" runat="server">

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
                       <a> <button type="button" id="btnHomepage" runat="server" class="btn btn-link navbar-btn btn-block" onserverclick="btnHomepage_Click">Homepage</button></a>
                    </p>
                </li>
                <li>
                    <p class="navbar navbar-btn">
                   <a><button type="submit" id="btnLogout" runat="server" class="btn btn-link navbar-btn btn-block" onserverclick="btnLogoutManager_Click">Logout</button></a>
                 </p> 
                </li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
              <li>
                 <p class="navbar navbar-btn">
                   <a><!--button--></a>
                 </p>          
               </li>     
                  <li>
                 <p class="navbar navbar-btn">
                   <a><button type="submit" id="btnStaffBooking" runat="server" class="btn btn-link navbar-btn btn-block" onserverclick="btnStaffBooking_Click">Book Room</button></a>
                 </p>          
               </li>     
            </ul>

        </div><!--/.navbar-collapse -->
    </div>
</header>



     <div class="container">
         <div class="row">
             <div class="col-xs-8">
                

                 <fieldset>

<!-- Form Name -->
<legend class="text-center">Add New Employee</legend>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="txtRole">Role</label>  
  <div class="col-md-4">
  <input id="txtRole" runat="server" name="txtRole" type="text" placeholder="Single character i.e. 'R'" class="form-control input-md" required="" />
    
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="txtDeparture">Firstname</label>  
  <div class="col-md-4">
  <input id="txtFirstname" runat="server" name="txtFirstname" type="text" placeholder="Firstname" class="form-control input-md" required=""/>
    
  </div>
</div>
    <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtDeparture">Surname</label>  
  <div class="col-md-4">
  <input id="txtSurname" runat="server" name="txtSurname" type="text" placeholder="Surname" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtEmail">Employee's Email Address</label>  
  <div class="col-md-4">
  <input id="txtEmail" runat="server" name="txtEmail" type="email" placeholder="Employee email" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtDeparture">Postcode</label>  
  <div class="col-md-4">
  <input id="txtPostcode" runat="server" name="txtPostcode" type="text" placeholder="Postcode" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtAdd1">Address Line 1</label>  
  <div class="col-md-4">
  <input id="txtAdd1" runat="server" name="txtAdd1" type="text" placeholder="Line 1" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtAdd2">Address Line 2</label>  
  <div class="col-md-4">
  <input id="txtAdd2" runat="server" name="txtAdd2" type="text" placeholder="Line 2" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtAdd3">Address Line 3</label>  
  <div class="col-md-4">
  <input id="txtAdd3" runat="server" name="txtAdd3" type="text" placeholder="Line 3" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtTelephoneNo">Telephone No</label>  
  <div class="col-md-4">
  <input id="txtTelephoneNo" runat="server" name="txtTelephoneNo" type="text" placeholder="i.e. 01..." class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtMobileNo">Mobile Number</label>  
  <div class="col-md-4">
  <input id="txtMobileNo" runat="server" name="txtMobileNo" type="text" placeholder="i.e. 07..." class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtPassword">Password</label>  
  <div class="col-md-4">
  <input id="txtPassword" runat="server" name="txtPassword" type="text" placeholder="Employee Account Password" class="form-control input-md" required=""/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtAccountNo">Bank Account Number</label>  
  <div class="col-md-4">
  <input id="txtAccountNo" runat="server" name="txtAccountNo" type="text" placeholder="Bank Account Number" class="form-control input-md" required="" onkeypress='return event.charCode >= 48 && event.charCode <= 57'/>
    
  </div>
</div>
       <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtSortCode">Sort Code</label>  
  <div class="col-md-4">
  <input id="txtSortCode" runat="server" name="txtSortCode" type="text" placeholder="Sort Code" class="form-control input-md" required="" onkeypress='return event.charCode >= 48 && event.charCode <= 57'/>
    
  </div>
</div>

           <!-- Text input-->
    <div class="form-group">
  <label class="col-md-4 control-label" for="txtSalary">Annual Salary</label>  
  <div class="col-md-4">
  <input id="txtSalary" runat="server" name="txtSalary" type="text" placeholder="£..." class="form-control input-md" required="" onkeypress='return event.charCode >= 48 && event.charCode <= 57'/>
    
  </div>
</div>





<!-- Button -->
<div class="form-group">
  <label class="col-md-4 control-label" for="btnMakeBooking"></label>
  <div class="col-md-4">
    <!--button goes here --><button type="submit" id="btnAddEmployee" runat="server" onserverclick="btnSubmitEmployee_Click" class="btn btn-success"> Add Employee</button>
  </div>
</div>
    <label id="lblTestJson" runat="server"></label>
    <label id="hiddenLblRoomChosen" runat="server" style="color: white">
    
    </label><script>document.getElementById("hiddenLblRoomChosen").style.visibility("hidden");</script><label id="hiddenLblNumberOfPeople" runat="server"></label></fieldset>



             </div>
             <div class="col-xs-4">
                 <label for="txtareaDisplayRooms">Rooms</label>
             <textarea rows="4" cols="75" id="txtareaDisplayRooms" runat="server"></textarea>
                 <button type="submit" id="btnCheckRooms" runat="server" class="btn btn-success" onserverclick="btnCheckRooms_Click" style="position:absolute">Check Rooms</button>
                 
                 
                    <label for="txtareaDisplayTodaysArrivals" style="padding-top:50px">Today's Arrivals</label>
                <textarea rows="4" cols="75" id="txtareaDisplayTodaysArrivals" runat="server"></textarea>
                 <button type="submit" id="btnShowArrivals" runat="server" class="btn btn-success" onserverclick="btnShowArrivals_Click" style="position:absolute">Show Today's Arrivals</button>
                 <div style="padding-top:40px"><button type="submit" id="btnGenerateArrivalsFile" runat="server" class="btn btn-success" onserverclick="btnGenerateArrivalsFile_Click" style="position:absolute">Export Today's Arrivals</button></div>
                  

            <div style="padding-top:40px"> <button type="submit" id="btnGenerateDeparturesFile" runat="server" class="btn btn-success" onserverclick="btnGenerateDeparturesFile_Click" style="position:absolute">Export Today's Departures</button></div>
                 
                 
                 <div style="margin-top: 30px"></div>
                 <div style="padding-top:40px">
                      
                <div style="margin-top:40px"><label>Booking Reference:</label><input type="text" runat="server" id="txtCustID"></div></div>
                 <button type="submit" id="btnCechCustomerIn" runat="server" class="btn btn-success" onserverclick="btnCechCustomerIn_Click" style="position:absolute; display:inline-block">Check-in Customer</button>
                 <div style="padding-top:40px"><button type="submit" id="btnCechCustomerOut" runat="server" class="btn btn-success" onserverclick="btnCechCustomerOut_Click" style="position:absolute; display:inline-block">Check-out Customer</button></div>
                 <div style="padding-top:40px"><label for="txtEmailForCard">Customer's email to add Card:</label></div>
                 <input type="text" runat="server" id="txtEmailForCard">
                    <button type="submit" id="btnAddCardByEmail" runat="server" class="btn btn-success" onserverclick="btnAddCustomersCardDetails_Click" style="position:absolute">Add Customer's Card</button>
                
                <div style="padding-top: 40px"><label for="txtCancelBooking">Booking Reference:</label></div>
                       <input type="text" runat="server" id="txtCancelBooking" />
             <button type="submit" id="btnManagerCancelBooking" runat="server" onserverclick="btnManagerCancelBooking_Click" class="btn btn-success" style="position:absolute; display:inline-block">Cancel a Booking</button>
                 <label id="lblBookRefError" runat="server"></label>

             </div>
               
            </div>
    
        
         </div>

        
     </div>


   <style>
  body {
    padding-top: 75px;
  }
       .auto-style1 {
           width: 244px;
           height: 65px;
       }
   </style>

 <label for="testLabel" id="testLabel" runat="server"></label>
 
        

</form>


 </div>
</body>
</html>
