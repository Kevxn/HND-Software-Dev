using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewAccount : System.Web.UI.Page
{
    //need to add code to let user view bookings after theyve logged out and logged back in


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerSession"] != null)
        {



            btnShowBookings.Visible = false;

            //customer id gets wiped here for some reason
            DAL access = new DAL();
            access.createCustomers();
            Dictionary<string, Customer> customers = access.getHotelCustomers();

            string email = (string)Session["emailaddress"];


            Customer c = (Customer)Session["CustomerSession"];


            c = customers[email];


            Session["CustomerSession"] = c;

            if (Session["CustomerSession"] == null)
            {
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                RoomBooking b = (RoomBooking)Session["BookingSession"];
                c = (Customer)Session["CustomerSession"];
                Card card = (Card)Session["card"];

                //displaying customer data
                lblShowFirstname.Text = c.getFirstname() + " " + c.getSurname();
                lblShowEmail.Text = c.getEmail();
                lblShowTelephoneNo.Text = c.getTelephoneNo();
                lblShowMobileNo.Text = c.getMobileNo();
                lblShowPostcode.Text = c.getPostcode();
                lblShowAddress1.Text = c.getAddress1();
                lblShowAddress2.Text = c.getAddress2();
                lblShowAddress3.Text = c.getAddress3();
                lblShowCustomerID.Text = c.getCustomerID(); //customer id is stored until i call new dal object in login method
                lblShowJoinDate.Text = c.getJoinDate().ToShortDateString(); // 2 different joinDates, one in the person and one in the customer

                Session["CustomerSession"] = c;

                if (Session["BookingSession"] != null)
                {
                    btnShowBookings.Visible = true;
                }
            }
        }
        else
        {
            Response.Redirect("Registration.aspx");
        }
    }
    

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx"); //redirections
    }

    protected void btnShowBookings_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking.aspx");
    }

    protected void btnAddCard_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddCard.aspx");

    }

    protected void btnShowCardDetails_Click(object sender, EventArgs e)
    {
        lbldisplaycardno.Visible = true; //showing the labels to display the card info
        lblShowCardNo0.Visible = true;
        lblShowCardNo1.Visible = true;
        lblShowExpiryDate.Visible = true;

        DAL access2 = new DAL();
        access2.createCards();
        Dictionary<string, Card> cards = access2.getCustomerCards(); //getting cards from the database
        
        

        if (Session["manageremail"] == null)
        {
            string email = (string)Session["emailaddress"];
           
            
            if (cards.ContainsKey(email)) //if the card exists
            {
                Card ca = cards[email];
                lblShowCardNo0.Text = "**** **** **** " + ca.getCardNo().Substring(15, ca.getCardNo().Length - 15);//takes out part of the number, leaves last 4 digits
                lblShowExpiryDate.Text = ca.getExpiryDate();
                lblShowBalance.Text = ca.getBalance().ToString();
                Session["card"] = ca;
            }
            else
            {
                lblShowCardNo1.Text = "You have not added a card to your account.";
            }
           

         
        }
        else
        {
           
            string mEmail = (string)Session["checkInAddCardEmail"];
            
            if (cards.ContainsKey(mEmail))//if the card exists
            {
                Card ca = cards[mEmail];
                lblShowCardNo0.Text = "**** **** **** " + ca.getCardNo().Substring(15, ca.getCardNo().Length - 15); //this hides part of the card number
                lblShowExpiryDate.Text = ca.getExpiryDate();
                lblShowBalance.Text = ca.getBalance().ToString();
                Session["card"] = ca;
            }
            else//if the customer has not added a card
            {
                lblShowCardNo1.Text = "You have not added a card to your account.";
            }
           
        }
        
       // Card ca = (Card)Session["card"];
        

    }

    protected void btnShowCustomerBookings_Click(object sender, EventArgs e)
    {
        DAL d = new DAL();
        d.showAllCustomerBookings(getCurrentCustomerID()); //showing all bookings by customerID
        Dictionary<string, RoomBooking> custBookingsFromDB;
        custBookingsFromDB = d.getShowingCustomerBookings();
        bool bookingsExist = false;
        foreach (KeyValuePair<string, RoomBooking> rb in custBookingsFromDB)
        {
            bookingsExist = true;
            string toAppend = "Booking ID: " + rb.Value.getBookingID() + "\n Arriving: " + rb.Value.getArrivalDate().ToShortDateString() + "\n Departing: " + rb.Value.getDepartureDate().ToShortDateString() + "\n Room Type: " + rb.Value.getRoomType() + "\n Room ID: " + rb.Value.getRoomID() + "\n" + "------------------------------------------------ \n";
            txtAreaShowAllBookings.InnerText += toAppend;
            //displaying all of the customers bookings
        }

        if (!bookingsExist)//if there is no bookings to display
        {
            txtAreaShowAllBookings.InnerText = "You have not made any bookings.";
        }
    }
    public string getCurrentCustomerID()
    {
        DAL d = new DAL();
        d.createCustomers();
        Dictionary<string, Customer> customer = new Dictionary<string, Customer>();
        customer = d.getHotelCustomers();
        Customer c = customer[lblShowEmail.Text];
        return c.getCustomerID();
    }

    protected void btnCancelBooking_Click(object sender, EventArgs e)
    {
        string bookRef = txtRemoveBooking.Value;
        DAL delete = new DAL();
        delete.createBookings();
        Dictionary<string, RoomBooking> custBookingsFromDB;
        custBookingsFromDB = delete.getRoomBookings();
        bool isGenuineBookingRef = false;
        Customer c = (Customer)Session["CustomerSession"];
        string custIDForBooking = "";
        foreach (KeyValuePair<String, RoomBooking> roombooking in custBookingsFromDB)
        {
            if (roombooking.Value.getBookingID() == bookRef)
            {
                custIDForBooking = roombooking.Value.getBookingID().Substring(0, 10); //also checks that customer trying to cancel actually booked that room
                isGenuineBookingRef = true;
            }
        }

        if (isGenuineBookingRef && custIDForBooking == c.getCustomerID())//checking to see if the customer is permitted to delete that booking
        { //only deletes booking if that customer booked the room
            //customer cannot delete another customers booking
            delete.cancelBooking(bookRef);
            lblConfirmDeleted.ForeColor = System.Drawing.Color.Black;
            lblConfirmDeleted.Text = "Booking cancelled.";
            sendCancellationEmail();
            txtAreaShowAllBookings.InnerText = "";
        }
        else //invalid booking id OR customer tried to cancel another customers booking
        {
            lblConfirmDeleted.Text = "You must enter a valid booking reference to cancel a booking.";
            lblConfirmDeleted.ForeColor = System.Drawing.Color.Red;
        }
       
    }

    public void sendCancellationEmail() //sending email to confirm that a user has cancelled their booking
    {
        MailMessage message = new MailMessage();
        string myEmail = "RealDroversLodge@gmail.com";
        string myPassword = "LroversDodge";
        string toEmail = "kevingray1998@live.com";
        

        message.From = new MailAddress(myEmail);
        message.To.Add(toEmail);
        message.CC.Add("RealDroversLodge@gmail.com");
        message.Subject = "Thanks for staying with Drovers Lodge!";
        Customer tempCust = (Customer)Session["CustomerSession"];

        message.Body = "From all at Drovers Lodge we are sorry to hear that you have decided to cancel your booking.";
        //USB message.Attachments.Add(new Attachment(@"G:\Graded Unit\DroversLodge\Reports\DLReceipt.pdf"));
      

        message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
        {
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(myEmail, myPassword);

            smtpClient.Send(message);

        }
    }
}