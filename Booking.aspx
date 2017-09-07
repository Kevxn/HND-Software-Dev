<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Booking</title>
     <link rel="stylesheet" type="text/css" href="DroversLodgeStyles.css" runat="server">

    
     <!-- Bootstrap css files -->

     <link rel="stylesheet" href="/css/bootstrap.min.css"/>
     <link rel ="stylesheet" href="/css/bootstrap-theme.min.css" />

     <!-- End of Bootrap css files -->
    <!-- Bootstrap JS Files --><script src="/js/bootstrap.min.js"></script><script src="/js/jquery-3.2.1.min.js"></script><!--End of scripts -->
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



     <div class="container">
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

         
<fieldset>

<!-- Form Name -->
<legend class="text-center">Make a Booking</legend>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="txtArrival">Desired Arrival Date:</label>  
  <div class="col-md-4">
  <input id="txtArrival" runat="server" name="txtArrival" type="date" placeholder="mm/dd/yyyy" class="form-control input-md" required="" />
    
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="txtDeparture">Desired Departure Date:</label>  
  <div class="col-md-4">
  <input id="txtDeparture" runat="server" name="txtDeparture" type="date" placeholder="mm/dd/yyyy" class="form-control input-md" required=""/>
    
  </div>
</div>

<!-- Multiple Checkboxes (inline) -->
<div class="form-group">
  <label class="col-md-4 control-label" for="chckNoOfAdults">Number of Adults:</label>
  <div class="col-md-4">
    <label class="select" for="chckNoOfAdults-0">
    <div class="select">
        <select class="form-control" runat="server" id="inptNumberOfAdults" onchange="validateSelectBox" >
            <option value="0">0</option>
            <option value="1">1</option>
            <option value="2">2</option>
        </select>
    </div>
    </label>
  </div>
</div>

<!-- Multiple Checkboxes (inline) -->
<div class="form-group">
  <label class="col-md-4 control-label" for="chckNumberOfKids">Number of Kids:</label>
  <div class="col-md-4">
    <label class="select" for="chckNumberOfKids-0">
         <div class="select">
            <select class="form-control" runat="server" id="inptNumberOfChildren" >
                 <option value="0">0</option>
                 <option value="1">1</option>
                 <option value="2">2</option>
    </select>
</div>
    </label>
  </div>
</div>
     
<!-- Multiple Checkboxes -->
<div class="form-group">
  <label class="col-md-4 control-label" for="chckBoardType">Board Type:</label>
  <div class="col-md-4">
  <div class="checkbox">
    <label for="chckBoardType-0">
      <input type="checkbox" runat="server" name="chckBoardType" id="chckBoardType_0" value="1"/>
      Full Board (all meals)
    </label>
	</div>
  <div class="checkbox">
    <label for="chckBoardType-1">
      <input type="checkbox" runat="server" name="chckBoardType" id="chckBoardType_1" value="2"/>
      Half Board (Breakfast and 1 Main Meal)
    </label>
	</div>
  <div class="checkbox">
    <label for="chckBoardType-2">
      <input type="checkbox" runat="server" name="chckBoardType" id="chckBoardType_2" value="3"/>
      Bed &amp; Breakfast
    </label>
	</div>
  <div class="checkbox">
    <label for="chckBoardType-3">
      <input type="checkbox" runat="server" name="chckBoardType" id="chckBoardType_3" value="4"/>
      No board
    </label>
	</div>
  </div>
</div>

<!-- Multiple Checkboxes -->
<div class="form-group">
  <label class="col-md-4 control-label" for="chckMeals">Included meals:</label>
  <div class="col-md-4">
  <div class="checkbox">
    <label for="chckMeals-0">
      <input type="checkbox" runat="server" name="chckMeals" id="chckMeals_0" value="1"/>
      Breakfast
    </label>
	</div>
  <div class="checkbox">
    <label for="chckMeals-1">
      <input type="checkbox" runat="server" name="chckMeals" id="chckMeals_1" value="2"/>
      Lunch
    </label>
	</div>
  <div class="checkbox">
    <label for="chckMeals-2">
      <input type="checkbox" runat="server" name="chckMeals" id="chckMeals_2" value="3"/>
      Evening meal
    </label>
	</div>
  <div class="checkbox">
    <label for="chckMeals-3">
      <input type="checkbox" runat="server" name="chckMeals" id="chckMeals_3" value="4"/>
      Self catering
    </label>
	</div>
  </div>
</div>

<div class="form-group">
  <label class="col-md-4 control-label" for="Room number">Room No:</label>
  <div class="col-md-4">
    <label class="select" for="selectRoomNo">
         <div class="select">
            <select class="form-control" runat="server" onclick="showAppropriateRooms()" id="selectRoomNo" >
                 <option value="1">1</option>
                 <option value="2">2</option>
                 <option value="3">3</option>
                 <option value="4">4</option>
                 <option value="5">5</option>
                 <option value="6">6</option>
                 <option value="7">7</option>
        </select>
      </div>
    </label>
  </div>
</div>
   <script>
       function showAppropriateRooms() {
           var labelvalue = document.getElementById("hiddenLblRoomChosen").textContent;
            if (labelvalue == "d") {
               $('#selectRoomNo option[value=7]').hide();
               $('#selectRoomNo option[value=1]').hide();
               $('#selectRoomNo option[value=2]').show();
               $('#selectRoomNo option[value=3]').hide();
               $('#selectRoomNo option[value=4]').show();
               $('#selectRoomNo option[value=5]').hide();
               $('#selectRoomNo option[value=6]').show();
           }
            if (labelvalue == "s") {
               $('#selectRoomNo option[value=7]').hide();
               $('#selectRoomNo option[value=1]').show();
               $('#selectRoomNo option[value=2]').hide();
               $('#selectRoomNo option[value=3]').show();
               $('#selectRoomNo option[value=4]').hide();
               $('#selectRoomNo option[value=5]').show();
               $('#selectRoomNo option[value=6]').hide();
           }
           if (labelvalue == "f") {
               $('#selectRoomNo option[value=7]').show();
               $('#selectRoomNo option[value=1]').hide();
               $('#selectRoomNo option[value=2]').hide();
               $('#selectRoomNo option[value=3]').hide();
               $('#selectRoomNo option[value=4]').hide();
               $('#selectRoomNo option[value=5]').hide();
               $('#selectRoomNo option[value=6]').hide();
           }
       }
   </script>



<!-- Button -->
<div class="form-group">
  <label class="col-md-4 control-label" for="btnMakeBooking"></label>
  <div class="col-md-4">
    <button id="btnMakeBooking" runat="server" onclick="return checkNoOfPeople();" onserverclick="btnMakeBooking_Click" name="btnMakeBooking" class="btn btn-success" data-toggle="popover" title="Weather" data-content="Current temperature: ">Make Booking</button>
           <script type="text/javascript"> //popup weather
            $(document).ready(function(){
             $('[data-toggle="popover"]').popover({
              placement : 'side',
              trigger : 'hover'
          });
        });
      </script>
      <label id="lblRoomBooked" runat="server"></label>
  </div>
</div>
    <label id="lblTestJson" runat="server"></label>
    <label id="hiddenLblRoomChosen" runat="server" style="color: white">
    
    </label><script>document.getElementById("hiddenLblRoomChosen").style.visibility("hidden");</script><label id="hiddenLblNumberOfPeople" runat="server"></label></fieldset>

 


</form>


 </div>
    <script>
        document.getElementById("inptNumberOfAdults").onchange = function () { validateSelectBox() };

        function validateSelectBox() {
            if (document.getElementById("hiddenLblRoomChosen").textContent == "s") {
                document.getElementById("inptNumberOfChildren").disabled = true;

                           var select = document.getElementById("inptNumberOfAdults");
                                var outputval = select.options[select.selectedIndex].value;
                
                                if (outputval > 1) {
                                    alert("You have chosen too many adults for this room type");
                                    document.getElementById("inptNumberOfChildren").disabled = true;
                                    document.getElementById("btnMakeBooking").disabled = true;
                                }
                                else {
                                   // document.getElementById("inptNumberOfChildren").disabled = false;
                                    document.getElementById("btnMakeBooking").disabled = false;
                                }
                
                                if (outputval == 1) {
                                    document.getElementById("inptNumberOfChildren").disabled = true;
                
                                }
                                if (outputval == 0) {
                                    document.getElementById("inptNumberOfChildren").disabled = true;
                                    document.getElementById("btnMakeBooking").disabled = true;
                                }
                                
             }  
        }
    </script>
    <script>

        document.getElementById("btnMakeBooking").click = function () { checkNoOfPeople() };

        function checkNoOfPeople() {
            if (document.getElementById("hiddenLblRoomChosen").textContent == "d") {
                if (document.getElementById("inptNumberOfAdults").value == 2 &&
                    document.getElementById("inptNumberOfChildren").value > 0
                    || document.getElementById("inptNumberOfAdults").value == 1 &&
                    document.getElementById("inptNumberOfChildren").value > 1) {
                    alert("Double room is limited to 2 persons");
                    alert("You may want to book a family room");

                    return false;
                }
                else if (document.getElementById("inptNumberOfAdults").value == 0
                    && document.getElementById("inptNumberOfChildren").value > 0) {
                    alert("Rooms can only be booked by an adult");
                    return false;
                }
                else if (document.getElementById("inptNumberOfAdults").value >= 1 &&
                        document.getElementById("inptNumberOfChildren").value == 2)
                {
                    alert("With " + noOfAdults + " adults and " + noOfKids + " kids you must book a family room");
                   return false;
                }
                else {
                    familyQualify();
                    return true;
                }
                
            }

        }

  

    </script>
    <script>
        document.getElementById("btnMakeBooking").click = function () { familyQualify() };

        function familyQualify() {
            if (document.getElementById("hiddenLblRoomChosen").textContent == "f") {

                if (document.getElementById("inptNumberOfAdults").value == 2 && document.getElementById("inptNumberOfChildren").value < 1 || document.getElementById("inptNumberOfAdults").value == 0) {
                    alert("You must have children (under 14) to stay in a family room");
                    return false;
                }
                else {
                    return true;
                }
            }
        }

       
    </script>
  
</body>
</html>
