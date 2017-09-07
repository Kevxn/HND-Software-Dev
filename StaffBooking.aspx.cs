using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffBooking : System.Web.UI.Page
{
    Dictionary<string, RoomBooking> availableRoomsFromDB = new Dictionary<string, RoomBooking>();
    bool isEmpty = true;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["StaffSession"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
      
    }

    protected void btnManagerHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Manager.aspx");
    }

    protected void btnMakeBookingForCustomer_Click(object sender, EventArgs e)
    {
        string a = chooseRoomType.Value;
        string b = chooseRoomNo.Value;

        /* additional serverside validation because */
        if (a == "1" && b == "2" || a == "1" && b == "4" || a == "1" && b == "6" || a == "1" && b == "7")
        {
            lblStaffBookingError.Visible = true;
        }
        else if (a == "2" && b == "1" || a == "2" && b == "3" || a == "2" && b == "5" || a == "2" && b == "7")
        {
            lblStaffBookingError.Visible = true;
        }
        else if (a == "3" && b != "7")
        {
            lblStaffBookingError.Visible = true;
        }
        else
        {
            lblStaffBookingError.Visible = false;
            string roomType = a;

            //comverting roomtype into database friendly values
            if (roomType == "1")
            {
                roomType = "s";
            }
            else if (roomType == "2")
            {
                roomType = "d";
            }
            else if (roomType == "3")
            {
                roomType = "f";
            }



            string roomNo = b;
            string arrivaldatee = txtArrival.Value;
            string departuredatee = txtDeparture.Value;


            //  DateTime arrivalDate = Convert.ToDateTime(txtArrival.Value);
            // DateTime departureDate = Convert.ToDateTime(txtDeparture.Value);

            string newArrivalDate = DateTime.ParseExact(arrivaldatee, "yyyy-MM-dd",
                CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            string newDepartureDate = DateTime.ParseExact(departuredatee, "yyyy-MM-dd",
                CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            int adults = Convert.ToInt32(inptNumberOfAdults.Value);
            int kids = Convert.ToInt32(inptNumberOfChildren.Value);
            string fullboard;
            string halfboard;
            string bandb;
            string noboard;
            string breakfast;
            string lunch;
            string eveningmeal;
            string nomeal;
            //checking board type and meals

            if (chckBoardType_0.Checked) { fullboard = "Full Board"; } else { fullboard = "No"; }
            if (chckBoardType_1.Checked) { halfboard = "Half Board"; } else { halfboard = "No"; }
            if (chckBoardType_2.Checked) { bandb = "Bed and Breakfast"; } else { bandb = "No"; }
            if (chckBoardType_3.Checked) { noboard = "No Board"; } else { noboard = "Yes"; }
            if (chckMeals_0.Checked) { breakfast = "Breakfast"; } else { breakfast = "No"; }
            if (chckMeals_1.Checked) { lunch = "Lunch"; } else { lunch = "No"; }
            if (chckMeals_2.Checked) { eveningmeal = "Evening Meal"; } else { eveningmeal = "No"; }
            if (chckMeals_3.Checked) { nomeal = "No Meal"; } else { nomeal = "Yes"; }
            RoomBooking r = new RoomBooking();
            string bookingID = r.generateBookingID(roomType);


            DAL saveBooking = new DAL();

            saveBooking.checkIfRoomAvailable(Convert.ToInt32(roomNo), newArrivalDate, newDepartureDate);
            saveBooking.bookingAvailabilityChecker();
            Dictionary<string, RoomBooking> availableRoomsFromDB = saveBooking.getCheckBookings();//working, query saved to dictionay with bookingID key
            DateTime parseArrival = DateTime.ParseExact(newArrivalDate, "MM/dd/yyyy", CultureInfo.InvariantCulture); //for comparing below format has to be dd/MM/yyyy
            DateTime parseDeparture = DateTime.ParseExact(newDepartureDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            // DateTime test = Convert.ToDateTime(newArrivalDate);
            if ((parseDeparture - parseArrival).TotalDays <= 56)//all of this validation is the same as on the Booking.aspx page
            {
               
                if (parseArrival < DateTime.Today)//if arriving in the past
                {
                    lblStaffBookingError.Visible = true;
                    lblStaffBookingError.InnerText = "You must arrive at a date in the future.";
                }
                else
                {

                    if (parseArrival > parseDeparture) //if arrival is after departure
                    {
                        lblStaffBookingError.Visible = true;
                        lblStaffBookingError.InnerText = "Arrival date must be before the departure date.";
                    }
                    else
                    {



                        foreach (KeyValuePair<string, RoomBooking> bookings in availableRoomsFromDB) //checks to see if the booking can be made
                        {
                            if (bookings.Value.getRoomID() == Convert.ToInt32(roomNo) && parseArrival <= bookings.Value.getDepartureDate() && parseDeparture >= bookings.Value.getArrivalDate() || parseDeparture < bookings.Value.getDepartureDate())
                            {//if room is already booked at those dates
                                isEmpty = false;
                            }

                        }

                        if (isEmpty)
                        {
                            saveBooking.updateRoomBooking("Unavailable", Convert.ToInt32(roomNo));
                            //saving booking to database
                            //I insert booked by staff as there is no customerID when booking via the phone
                            saveBooking.saveBookingToDb(bookingID, parseArrival, parseDeparture, adults, kids, fullboard, halfboard, bandb, noboard, breakfast, lunch, eveningmeal, nomeal, roomType, "BOOKED BY STAFF", Convert.ToInt32(roomNo));
                            lblStaffBookingError.InnerText = "Room Booked for customer.";
                        }
                        else
                        {
                            //room is already booked
                            lblStaffBookingError.Visible = true;
                            lblStaffBookingError.InnerText = "Error: Room booked at time slot.";
                        }
                    }
                }
            }

            else //display error
            {
                lblStaffBookingError.Visible = true;
                lblStaffBookingError.InnerText = "The maximum stay length is 8 weeks.";
            }
            } 
        }
}