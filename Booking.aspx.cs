using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stripe;
using Newtonsoft.Json;
using System.Globalization;

public partial class Booking : System.Web.UI.Page
{
    //variables
     string bookingID;
    DateTime arrivalDate;
    DateTime departureDate;
    int numberOfAdults;
    int numberOfChildren;
    string fullBoard;
    string halfBoard;
    string bAndB;
    string noBoard;
    string breakfast;
    string lunch;
    string eveningMeal;
    string noMeal;
    string roomType;
    float roomPrice;
    bool isEmpty = true;
    bool canBook = false;
    string availDate;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["CustomerSession"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
       else 
        {
            
            if (Session["buttonChosen"].ToString() == "s")
            {
                hiddenLblRoomChosen.InnerText = "s"; // saves the value from the session variable
               
            }
            else if(Session["buttonChosen"].ToString() == "d")
            {
                hiddenLblRoomChosen.InnerText = "d";
            }
            else
            {
                hiddenLblRoomChosen.InnerText = "f";
            }
        }
    }

    protected void btnHomepage_Click(object Source, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void btnMakeBooking_Click(object sender, EventArgs e)
    {

        if (Int32.Parse(inptNumberOfAdults.Value) == 2 && Int32.Parse(inptNumberOfChildren.Value) > 0 && Session["buttonChosen"].ToString() == "f")
        { //if family room

            createBooking();//creating booking object with chosen values from booking form
            DateTime desiredArrival = Convert.ToDateTime(txtArrival.Value);
            DateTime desiredDeparture = Convert.ToDateTime(txtDeparture.Value);

            if (((desiredDeparture - desiredArrival).TotalDays <= 56))//business rule - max stay is 8 weeks
            {


                if (desiredArrival < DateTime.Today) //cannot arrive in the past
                {
                    lblRoomBooked.InnerText = "You must arrive at a date in the future.";
                }
                else
                {
                    if (desiredArrival > desiredDeparture)//check if customer trying to arrive before they depart
                    {
                        lblRoomBooked.InnerText = "Arrival date must be before Departure date.";
                    }
                    else
                    {
                        if (canBook)//true if booking is available
                        {
                            Response.Redirect("ViewBooking.aspx");
                        }
                        else //say when it will be available
                        {
                            lblRoomBooked.InnerText = "This room type is unavailable. It will be available on " + availDate;
                        }
                    }
                }
            }
            else
            {
                lblRoomBooked.InnerText = "The max stay is 8 weeks.";
            }


        }
        else if (Session["buttonChosen"].ToString() == "d" && Int32.Parse(inptNumberOfAdults.Value) == 2 || Int32.Parse(inptNumberOfAdults.Value) == 1 && Int32.Parse(inptNumberOfChildren.Value) == 1)
        {
            createBooking();//creating booking object with chosen values
            DateTime desiredArrival = Convert.ToDateTime(txtArrival.Value);
            DateTime desiredDeparture = Convert.ToDateTime(txtDeparture.Value);

            if (((desiredDeparture - desiredArrival).TotalDays <= 56))//max stay 8 weeks
            {

                if (desiredArrival < DateTime.Today)//if arrival is before today
                {
                    lblRoomBooked.InnerText = "You must arrive at a date in the future.";
                }
                else
                {
                    if (desiredArrival > desiredDeparture)//depart must be after arrival
                    {
                        lblRoomBooked.InnerText = "Arrival date must be before Departure date.";
                    }
                    else
                    {
                        if (canBook)//true if booking available
                        {
                            Response.Redirect("ViewBooking.aspx");
                        }
                        else //say when it will be available
                        {
                            lblRoomBooked.InnerText = "This room type is unavailable. It will be available on " + availDate;
                        }
                    }
                }
            }
            else
            {
                lblRoomBooked.InnerText = "The max stay is 8 weeks.";
            }

        }
        else if (Session["buttonChosen"].ToString() == "s" && Int32.Parse(inptNumberOfAdults.Value) == 1)
        {
            createBooking();
            DateTime desiredArrival = Convert.ToDateTime(txtArrival.Value);
            DateTime desiredDeparture = Convert.ToDateTime(txtDeparture.Value);
            TimeSpan checkDaysBetween = desiredDeparture - desiredArrival;

            if (((desiredDeparture - desiredArrival).TotalDays <= 56))//same as above
            {


                if (desiredArrival < DateTime.Today)
                {
                    lblRoomBooked.InnerText = "You must arrive at a date in the future.";
                }
                else
                {
                    if (desiredArrival > desiredDeparture)
                    {
                        lblRoomBooked.InnerText = "Arrival date must be before Departure date.";
                    }
                    else
                    {
                        if (canBook)
                        {
                            Response.Redirect("ViewBooking.aspx");
                        }
                        else
                        {
                            lblRoomBooked.InnerText = "This room is unavailable. It will be available on " + availDate + ". You can try another room number.";

                        }
                    }
                }

            }
            else
            {
                lblRoomBooked.InnerText = "The max stay is 8 weeks.";
            }
        }
       
        
    }// end button

    public void createBooking()//confirmed booking on next page when payment is received
    {


        int roomNo = Convert.ToInt32(selectRoomNo.Value);
        string roomType = Session["buttonChosen"].ToString();
        Session["roomType"] = roomType;
        if (roomType == "d" && roomNo % 2 >= 1) //looks messy but checks in case the JavaScript doesnt pick up an incorrect input for the adult and children menus
        {
            Response.Redirect("Booking.aspx");
        }
        if (roomType == "s" && roomNo == 2 || roomType == "s" && roomNo == 4 || roomType == "s" && roomNo == 6 || roomType == "s" && roomNo == 7)
        {
            Response.Redirect("Booking.aspx");
        }
        if (roomType == "f" && roomNo != 7)
        {
            Response.Redirect("Booking.aspx");
        }
        //setting all the field values ready for payment
        DateTime arrivalDate = Convert.ToDateTime(txtArrival.Value);
        Session["arrivalDate"] = arrivalDate;
        string ssss = txtArrival.Value;
        Session["arrivalDatee"] = ssss;
        DateTime departureDate = Convert.ToDateTime(txtDeparture.Value);
        string dddd = txtDeparture.Value;
        Session["departureDate"] = departureDate;
        Session["departureDatee"] = dddd;
        int numberOfAdults = Int32.Parse(inptNumberOfAdults.Value);
        Session["numberOfAdults"] = numberOfAdults;
        int numberOfChildren = Int32.Parse(inptNumberOfChildren.Value);
        Session["numberOfChildren"] = numberOfChildren;
        //unsure why i done this 
        //should have put all the values into an object ???
        if (chckBoardType_0.Checked) { Session["fullBoard"] = "Full Board";fullBoard = "Full Board"; } else { Session["fullBoard"] = "No"; fullBoard = "No"; }
        if (chckBoardType_1.Checked) {Session["halfBoard"] = "Half Board" ; halfBoard = "Half Board"; } else { Session["halfBoard"] = "No";halfBoard = "No"; }
        if (chckBoardType_2.Checked) { Session["bAndB"] = "Bed and Breakfast";bAndB = "Bed & Breakfast"; } else { Session["bAndB"] = "No";bAndB = "No"; }
        if (chckBoardType_3.Checked) { Session["noBoard"] = "No Board";noBoard = "Self Catering"; } else { Session["noBoard"] = "Yes"; noBoard = "No"; }
        if (chckMeals_0.Checked) { Session["breakfast"] = "Breakfast";breakfast = "Yes"; } else { Session["breakfast"] = "No"; breakfast = "No"; }
        if (chckMeals_1.Checked) { Session["lunch"] = "Lunch"; lunch = "Yes"; } else { Session["lunch"] = "No"; lunch = "No"; }
        if (chckMeals_2.Checked) { Session["eveningMeal"] = "Evening Meal";eveningMeal = "Yes"; } else { Session["eveningMeal"] = "No";eveningMeal = "No"; }
        if (chckMeals_3.Checked) { Session["noMeal"] = "No Meal"; noMeal = "Yes"; } else { Session["noMeal"] = "Yes";noMeal = "No"; }
        
        //changing the date into same format as database
        string newArrivalDate = DateTime.ParseExact(ssss, "yyyy-MM-dd", 
       CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
        string newDepartureDate = DateTime.ParseExact(dddd, "yyyy-MM-dd",
            CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

       // int roomNo = Convert.ToInt32(selectRoomNo.Value);
        Session["roomNo"] = roomNo;
        DAL saveBooking = new DAL();
        
        saveBooking.checkIfRoomAvailable(Convert.ToInt32(roomNo), newArrivalDate, newDepartureDate);
        saveBooking.bookingAvailabilityChecker();
        Dictionary<string, RoomBooking> availableRoomsFromDB = saveBooking.getCheckBookings();


        DateTime parseArrival = DateTime.ParseExact(newArrivalDate, "MM/dd/yyyy", CultureInfo.InvariantCulture); //for comparing below format has to be dd/MM/yyyy
        DateTime parseDeparture = DateTime.ParseExact(newDepartureDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

        foreach (KeyValuePair<string, RoomBooking> bookings in availableRoomsFromDB) //checks to see if booking is available
        {
            if (bookings.Value.getRoomID() == Convert.ToInt32(roomNo) && parseArrival <= bookings.Value.getDepartureDate() && parseDeparture >= bookings.Value.getArrivalDate() || parseDeparture < bookings.Value.getDepartureDate())
            {//if room is already booked at those dates
                isEmpty = false;//for use below
            }

        }
        if (isEmpty)//if room is not empty then error is displayed
        { //else send the information over for payment

            RoomBooking booking = new RoomBooking(bookingID, arrivalDate, departureDate, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType);
            booking.setArrivalDate(arrivalDate);
            booking.setDepartureDate(departureDate);
            booking.setNumberOfAdults(numberOfAdults);
            booking.setNumberOfChildren(numberOfChildren);
            booking.setFullBoard(fullBoard);
            booking.setHalfBoard(halfBoard);
            booking.setBandB(bAndB);
            booking.setNoBoard(noBoard);
            booking.setBreakfast(breakfast);
            booking.setLunch(lunch);
            booking.setEveningMeal(eveningMeal);
            booking.setNoMeal(noMeal);
            booking.setBookingID(roomType);

            Session["SendBookingObjToPayment"] = booking;

            //put this code (below) after the payment has been confirmed
            //booking made using constructor but not written to database until payment has been made.

            DAL access = new DAL();
            access.createCustomers();
            Dictionary<string, Customer> customers = access.getHotelCustomers();
            string email = (string)Session["emailaddress"];
            Customer c = (Customer)Session["CustomerSession"];
            c = customers[email];
            Session["CustomerSession"] = c;
            canBook = true;
       

        }
        else
        {
            //room is uavailable
            DAL getRoomDate = new DAL();
            getRoomDate.getNextAvailableRoomDate(roomType);//reads dates from db
            DateTime nextAvailDate = getRoomDate.getNextAvailDate();//returns a datetime
             availDate = getNextAvailDate(nextAvailDate).ToString();
            
             
            //make label say next avail room date
        }

    }

    public DateTime getNextAvailDate(DateTime d) //adds one to the max departure date
    {
        return d.AddDays(1);
    }

  
}