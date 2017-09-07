using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager : System.Web.UI.Page
{
    //variables
    string eRole;
    string eFirstname;
    string eSurname;
    string eEmail;
    string ePostcode;
    string eAdd1;
    string eAdd2;
    string eAdd3;
    string eTelephoneNo;
    string eMobile;
    string ePassword;
    string eBankAccountNo;
    string eSortCode;
    float eSalary;
    DAL access = new DAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        //manager page where a manager can login and add employees (staff) and manage rooms as well as generate reports
        if (Session["StaffSession"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        else
        {

        }

    }

    protected void btnHomepage_Click(object sender, EventArgs e) //equivalent of logging out
    {
        Session["StaffSession"] = null;
        Response.Redirect("Homepage.aspx");
    }

    protected void btnSubmitEmployee_Click(object sender, EventArgs e)
    {  string managerEmail = Session["managerEmail"].ToString();
        if (txtRole.Value == "" ||
             txtFirstname.Value == "" ||
             txtSurname.Value == "" ||
             txtTelephoneNo.Value == "" ||
             txtMobileNo.Value == "" ||
             txtPostcode.Value == "" || //if any of the labels are empty
             txtAdd1.Value == "" ||
             txtAdd2.Value == "" ||
             txtAdd3.Value == "" ||
             txtPassword.Value == "" ||
             txtAccountNo.Value == "" ||
             txtSortCode.Value == "" ||
             txtSalary.Value == "" ||
             txtEmail.Value == "")
        {
            lblTestJson.InnerText = "None of the fields can be blank.";
        }
       
        else if(managerEmail == "manager@droverslodge.com") //only if the manager is logged in can employees be added
        {
            eRole = txtRole.Value;
            eFirstname = txtFirstname.Value;
            eSurname = txtSurname.Value;
            eEmail = txtEmail.Value;
            ePostcode = txtPostcode.Value;
            eAdd1 = txtAdd1.Value;
            eAdd2 = txtAdd2.Value;
            eAdd3 = txtAdd3.Value;
            eTelephoneNo = txtTelephoneNo.Value;
            eMobile = txtMobileNo.Value;
            ePassword = txtPassword.Value;
            eBankAccountNo = txtAccountNo.Value;
            eSortCode = txtSortCode.Value;
            eSalary = float.Parse(txtSalary.Value);
            string customerid = ""; //redundant, using person constructor, field N/A
            string staffid = "";
            DateTime startDate = DateTime.Now;
            DateTime eJoinDate = DateTime.Now; //redundant, using person constructor, field N/A

            Staff s = new Staff(customerid, staffid, eRole, eSalary, eSortCode, eBankAccountNo, startDate, eFirstname, eSurname, eTelephoneNo, eMobile, ePostcode, eEmail, eAdd1, eAdd2, eAdd3, ePassword, eJoinDate);
            //saving staff to the database
            access.writeStaffToDb(staffid, eRole, eFirstname, eSurname, eEmail, ePostcode, eAdd1, eAdd2, eAdd3, eTelephoneNo, eMobile, ePassword, eBankAccountNo, eSortCode, eSalary, eJoinDate);
            lblTestJson.InnerText = "Staff member added.";
        }
      else //if the staff member is not the manager
        {
            lblTestJson.InnerText = "Only a Manager can add new staff.";
        }
        
    }

    protected void btnLogoutManager_Click(object sender, EventArgs e)
    {
        Session["StaffSession"] = null;
        Session["managerEmail"] = null;
        Response.Redirect("Homepage.aspx");
    }

    protected void btnCheckRooms_Click(object sender, EventArgs e)
    {
        txtareaDisplayRooms.InnerText = "FREE ROOMS: \n \n";
        access.createAvailableRooms();
        Dictionary<string, Room> roomFromDB = access.getAvailableRooms();
        foreach (KeyValuePair<string, Room> r in roomFromDB) //loops through all of the rooms to check for available rooms
        {
            string roomNo = r.Value.getRoomNo();
            string roomType = r.Value.getRoomType();
            string description = r.Value.getRoomDescription();
            float roomPrice = r.Value.getRoomPrice();
            string roomStatus = r.Value.getRoomStatus();
            //displays available rooms
            txtareaDisplayRooms.InnerText = txtareaDisplayRooms.InnerText + "Room No: " + roomNo + " room type: " + roomType + " Price: " + roomPrice + " Status: " + roomStatus + "\n";
        }
        if (roomFromDB.Count == 0) //if there are no free rooms
        {
            txtareaDisplayRooms.InnerText = "There are no free rooms. \n";
            txtareaDisplayRooms.InnerText += "The next available single room is on {date} \n";
            txtareaDisplayRooms.InnerText += "The next available double room is on {date} \n";
            txtareaDisplayRooms.InnerText += "The next available family room is on {date}";
            //did not have time to finish this part properly
        }
    }
 
    public void updateAvailableRoomNumbers() //?
    {
        Dictionary<string, Room> roomFromDB = access.getHotelRooms();
            foreach (KeyValuePair<string, Room> r in roomFromDB) 
            {
           
        }
    }

    protected void btnStaffBooking_Click(object sender, EventArgs e) //redirects staff member to staff booking page
    {
        Response.Redirect("StaffBooking.aspx");
    }
    protected void btnShowArrivals_Click(object sender, EventArgs e) //shows all of the bookings that are expected today
    {
        access.checkTodaysArrivals();
        Dictionary<string, RoomBooking> todaysArrivalsFromDB = new Dictionary<string, RoomBooking>();
        todaysArrivalsFromDB = access.getTodaysArrivals();

        foreach(KeyValuePair<string, RoomBooking> arrivals in todaysArrivalsFromDB)//looping through all of the arrivals (if any)
        {
            int roomID = arrivals.Value.getRoomID();
            string bookingID = arrivals.Value.getBookingID();
            string roomType = arrivals.Value.getRoomType();
            //displaying all of the arrivals
            txtareaDisplayTodaysArrivals.InnerText = "BookingID: " + bookingID + " | Room Type: " + roomType + " | Room Number: " + roomID;
        }
        
        if (todaysArrivalsFromDB.Count == 0) //if there are no arrivals scheduled
        {
            txtareaDisplayTodaysArrivals.InnerText = "There are no arrivals scheduled for today.";
        }
    }

    public void getNextAvailableSingleRoom(string roomTypeToCheck) //need to call in a button, but should work
    {
        access.getNextAvailableRoomDate(roomTypeToCheck);//checks when the next available room is
    }

    protected void btnGenerateDeparturesFile_Click(object sender, EventArgs e)
    {
        DAL d = new DAL();
        d.exportDeparturesToExcel();//default write location will likely need to be changed 
        //exports the departures for today to Microsoft Excel readable format
    }
    protected void btnGenerateArrivalsFile_Click(object sender, EventArgs e)
    {
        DAL d = new DAL();
        d.exportArrivalToExcel();//default write location will likely need to be changed 
        //exports the arrivals for today to Microsoft Excel readable format
    }

    protected void btnCechCustomerIn_Click(object sender, EventArgs e)
    {
        string bookingID = txtCustID.Value;//changed to bookingID
        DAL d = new DAL();
        d.checkCustomerIn(bookingID); //check customer in by bookingID

    }

    protected void btnAddCustomersCardDetails_Click(object sender, EventArgs e)
    {
        string theirEmail = txtEmailForCard.Value;
        if (theirEmail == "") //making sure the txtbox has text in it before redirecting to add card for that customer
        {
            lblBookRefError.InnerText = "You must enter the customers email prior to clicking 'Add Card'. ";
        }
        else
        {//redirects to add card and card is added with email specified before
            Session["checkInAddCardEmail"] = theirEmail;
            Response.Redirect("AddCard.aspx");
        }
       
        
    }
    protected void btnCechCustomerOut_Click(object sender, EventArgs e)//checks customer out
    {
        string bookingID = txtCustID.Value;//get bookingID
        DAL d = new DAL();
        d.checkCustomerOut(bookingID);
        
    }

    protected void btnManagerCancelBooking_Click(object sender, EventArgs e)
    {//unlike customers who can only cancel their own booking,
     //staff can cancel any booking
        string bookRef = txtCancelBooking.Value;
        DAL delete = new DAL();
        delete.createBookings();//loads all of the bookings into dictionary
        Dictionary<string, RoomBooking> custBookingsFromDB;
        custBookingsFromDB = delete.getRoomBookings();//getting the bookings and loading to local dictionary
        bool isGenuineBookingRef = false; //initializing bool

        foreach (KeyValuePair<String, RoomBooking> roombooking in custBookingsFromDB) //looping through all bookings
        {
            if (roombooking.Value.getBookingID() == bookRef)//checks to see if the booking with bookingID entered exists
            {
               isGenuineBookingRef = true;//if the booking exists, it is a genuine booking reference
            }
        }

        if (isGenuineBookingRef)//only if the booking exists can we cancel it
        {
            delete.cancelBooking(bookRef);//cancelling the booking (deleting)
            lblBookRefError.InnerText = "Booking cancelled.";//confirmation message
           
        }
        else
        { //if the user did not enter a valid bookingID
            lblBookRefError.InnerText = "You must enter a valid booking reference to cancel a booking.";
        }
    }

}