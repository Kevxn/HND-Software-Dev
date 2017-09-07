using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stripe;
using System.Threading.Tasks;
using System.Globalization;
using System.Web.Services;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Configuration;
using Braintree;

public partial class ViewAccount : System.Web.UI.Page
{
    //variables
    float roomAmount;
    string bookingID;
    string bookingIDForPDF;
    Card c = new Card();
    DAL d = new DAL();
    bool isEmpty = true;
    private string API_KEY; //for Stripe
    public String TrData;
    public Boolean TransactionSuccessful;
    public String ErrorMessage;
    double roomPrice = 0;

    protected void Page_Load(object sender, EventArgs e)
    { //check if customer session 
        
        string roomChosen = (string)Session["roomType"];
        hiddenlblRoomChosen.InnerText = roomChosen;

        Customer c = (Customer)Session["CustomerSession"];
      
        string dgfd = lblShowBookingID.Text;//test


        DAL access = new DAL();
        access.createBookings();//loading all bookings from database
        Dictionary<string, RoomBooking> bookings = access.getRoomBookings();


        string bookID = access.getBookID(); //doesnt exist rb = null, have to find way to read bookingID

        lblShowArrivalDate.Text = "";
        //  rb = bookings[bookID]; 

        RoomBooking rb = (RoomBooking)Session["SendBookingObjToPayment"];

        if (Session["CustomerSession"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        else 
        { //displaying "receipt" or booking confirmation just before payment is made
            lblShowCustomerID.Text = c.getCustomerID();   
            lblShowBookingID.Text = c.getCustomerID() + rb.getBookingID();
            bookingIDForPDF = c.getCustomerID() + rb.getBookingID();
            lblShowArrivalDate.Text = Session["arrivalDate"].ToString().Substring(0, 10); //was to string
            lblShowDepartureDate.Text = Session["departureDate"].ToString().Substring(0, 10);// old code --> rb.getDepartureDate().ToString().Substring(0,10);

            if (Session["roomType"].ToString() == "f")
            {
                lblShowRoomType.Text = "Family Room";
                roomAmount = 90; //setting the price based on the room chosen
            }
            else if (Session["roomType"].ToString() == "d")
            {
                lblShowRoomType.Text = "Double Room";
                roomAmount = 75;//setting the price based on the room chosen
            }
            else if (Session["roomType"].ToString() == "s") //was rb.getRoomType() == "s"
            {
                lblShowRoomType.Text = "Single Room";
                roomAmount = 55;//setting the price based on the room chosen

            }

            if (Session["bAndB"].ToString() == "No") 
            {

            }
            else { lblShowBoard.Text = rb.getBandB(); }
            if (Session["fullBoard"].ToString() == "No")
            {

            }
            else { lblShowBoard.Text = rb.getFullBoard(); }
            if (Session["halfBoard"].ToString() == "No")
            {

            }
            else { lblShowBoard.Text = rb.getHalfBoard(); }
            // old lblShowBoard.Text = rb.getBandB().ToString() + rb.getFullBoard().ToString() + rb.getHalfBoard().ToString();
            //customers are allowed to book multiple meals

            lblShowMeals.Text = Session["breakfast"].ToString() + Session["lunch"].ToString() + Session["eveningMeal"].ToString();
        }
       

    }


    protected void btnGoToHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx"); //redirect
    }

    protected void btnPay_Click(object sender, EventArgs e) //when the user clicks pay, this pay button is if they have saved their card (i.e. clicked add card in their account page)
    {
        string roomChosen = (string)Session["roomType"];
        Dictionary<string, Room> roomsFromDB = new Dictionary<string, Room>();
        Dictionary<string, Card> cardsFromDB = new Dictionary<string, Card>();
       // double roomPrice = 0;// works here
        if (roomChosen == "f")
        {
            DAL d = new DAL();
            Room r = new Room();

            //r.addRoomsByID();
            d.createRooms(); //tested - working
            roomsFromDB = d.getHotelRooms();
            d.createCards();
            cardsFromDB = d.getCustomerCards();
            string usersEmail = Session["emailaddress"].ToString();
            Card thisCard = cardsFromDB[usersEmail];
            d.updateRoomBooking("Unavailable", 7);
            Card ca = (Card)Session["card"];//should get card data by loading from dictionary
            roomPrice = 90;
            if (processTransaction(thisCard)) //returns true if bal>price
            {
                d.updateCardBalance(thisCard.getBalance() - roomPrice, usersEmail);
                paymentCompleteMakeBooking(thisCard);
                Page.ClientScript.RegisterStartupScript(
                 this.GetType(),
                 "popup",
                 "showConfirmBox();",
                 true);
            }
            else //payment not made
            {
                lblCardDeclined.Text = "Your card has been declined.";
            }
        }
        else if (roomChosen == "d")
        {
            DAL d = new DAL();
            Room r = new Room();

            
            d.createRooms(); 
            roomsFromDB = d.getHotelRooms();
            d.createCards();
            cardsFromDB = d.getCustomerCards();
            string usersEmail = Session["emailaddress"].ToString(); //verifying the customer can pay and taking payment
            Card thisCard = cardsFromDB[usersEmail];
            //Card ca = (Card)Session["card"];
            roomPrice = 75;
            if (processTransaction(thisCard))
            {
                d.updateCardBalance(thisCard.getBalance() - roomPrice, usersEmail);
                paymentCompleteMakeBooking(thisCard);
                Page.ClientScript.RegisterStartupScript(
               this.GetType(),
               "popup",
               "showConfirmBox();",
               true);
            }
            else
            {
                lblCardDeclined.Text = "Your card has been declined.";
            }
            
        }
        else if (roomChosen == "s")
        {
            DAL d = new DAL(); //block untested
            Room r = new Room();

            //r.addRoomsByID();
            d.createRooms();
            roomsFromDB = d.getHotelRooms();
            d.createCards();
            cardsFromDB = d.getCustomerCards();
            string usersEmail = Session["emailaddress"].ToString();
            Card thisCard = cardsFromDB[usersEmail];//verifying the customer can pay and taking payment
            //Card ca = (Card)Session["card"];
            roomPrice = 55;
            if (processTransaction(thisCard))
            {
                d.updateCardBalance(thisCard.getBalance() - roomPrice, usersEmail);
                paymentCompleteMakeBooking(thisCard);
                Page.ClientScript.RegisterStartupScript(
               this.GetType(),
               "popup",
               "showConfirmBox();",
               true);
            }
            else
            {
                lblCardDeclined.Text = "Your card has been declined.";
            }
        }

    }

   public void makeStripeCharge() //using the Stripe API with a sandbox card (details below)
    {
        string Stripe_API_KEY = ConfigurationManager.AppSettings["StripeApiKey"]; //gets my API key from the web.config file
        StripeConfiguration.SetApiKey(ConfigurationManager.AppSettings["StripeApiKey"]);

        var myCharge = new StripeChargeCreateOptions(); //creating charge object 
        myCharge.Amount = Convert.ToInt32(roomAmount)*100;
        myCharge.Currency = "gbp";
        myCharge.Description = "Drovers Lodge | Room Booking";

        
            myCharge.SourceCard = new SourceCard() //gets the credit card information entered by the user 
            {
                // Number = "4242424242424242",
                Number = cardNumber.Value,
                ExpirationYear = expiryDateYear.Value,
                ExpirationMonth = expiryDateMonth.Value,

            };
        
        myCharge.Capture = true; //this is for retrieving the status of the transaction

        var chargeService = new StripeChargeService(Stripe_API_KEY); //setting the charge up

        try
        { /*
            VALID CARD INFO = Number = 4242 4242 4242 4242 (Visa)
            ExpDate = 07/21
            CVC = Not necessary
            */
            StripeCharge stripeCharge = chargeService.Create(myCharge); 
            string chargeID = stripeCharge.Id;
            Card tempCard = new Card();
            paymentCompleteMakeBooking(tempCard); //booking the room if no error is returned
            lblStripeError.InnerText = "Transaction Successful, check your email for a receipt.";
        }
       
           catch (Exception e) //if any invalid details are entered or something is wrong, it is caught and displayed here.
        {
            string error = e.Message;
            lblStripeError.InnerText = error;
        }
       

    }

    protected void btnPayStripe_Click(object sender, EventArgs e)
    {
        makeStripeCharge(); //uses the stripe api to charge a sandbox credit card. method above
    }


    public bool processTransaction(Card card) //checks if the user can pay for the room
    {
        if (card.getBalance() > roomAmount)
        {
            Session["card"] = c;
            return true; //if sufficient funds
        }
        else
        {
            return false;//if insufficient funds
        }
    }

    public void paymentCompleteMakeBooking(Card card) //inserting the booking into the database
    {
        if (processTransaction(card)) // only inserts into database if the payment has been taken successfully.
        {
            RoomBooking rb = (RoomBooking)Session["SendBookingObjToPayment"];

            //using session variables because this data is sent to the ViewBooking page to confirm and pay
            DateTime arrivalDate = (DateTime)Session["arrivalDate"];
            string arrivalDatee = (string)Session["arrivalDatee"].ToString();//test

            DateTime departureDate = (DateTime)Session["departureDate"];
            string departureDatee = (string)Session["departureDatee"].ToString();//test
            int numberOfAdults = (int)Session["numberOfAdults"];
            int numberOfChildren = (int)Session["numberOfChildren"];
            string fullBoard = (string)Session["fullBoard"];
            string halfBoard = (string)Session["halfBoard"];
            string bAndB = (string)Session["bAndB"];
            string noBoard = (string)Session["noBoard"];
            string breakfast = (string)Session["breakfast"];
            string lunch = (string)Session["lunch"];
            string eveningMeal = (string)Session["eveningMeal"];
            string noMeal = (string)Session["noMeal"];
            string roomType = (string)Session["roomType"];
            int roomNumber = (int)Session["roomNo"];
            Customer currentCustomer = (Customer)Session["CustomerSession"];


            RoomBooking booking = new RoomBooking(bookingID, arrivalDate, departureDate, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType);

            booking.setArrivalDate(Convert.ToDateTime(arrivalDate));
            booking.setDepartureDate(Convert.ToDateTime(departureDate));
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
            

            string newArrivalDate = DateTime.ParseExact(arrivalDatee, "yyyy-MM-dd",
                CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            string newDepartureDate = DateTime.ParseExact(departureDatee, "yyyy-MM-dd",
                CultureInfo.InvariantCulture).ToString("MM/dd/yyyy"); //changing the dates into correct format



            int roomNo = 0;
            DAL saveBooking = new DAL();
            //probably need to prompt user for roomNo
            saveBooking.checkIfRoomAvailable(Convert.ToInt32(roomNo), newArrivalDate, newDepartureDate);
            saveBooking.bookingAvailabilityChecker();
            Dictionary<string, RoomBooking> availableRoomsFromDB = saveBooking.getCheckBookings();


            DateTime parseArrival = DateTime.ParseExact(newArrivalDate, "MM/dd/yyyy", CultureInfo.InvariantCulture); 
            DateTime parseDeparture = DateTime.ParseExact(newDepartureDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            //the code below checks in case there is already a booking that it will overlap with
            foreach (KeyValuePair<string, RoomBooking> bookings in availableRoomsFromDB) 
            {
                if (bookings.Value.getRoomID() == Convert.ToInt32(roomNo) && parseArrival <= bookings.Value.getDepartureDate() && parseDeparture >= bookings.Value.getArrivalDate() || parseDeparture < bookings.Value.getDepartureDate())
                {//if room is already booked at those dates
                    isEmpty = false;
                }

            }

            if (isEmpty) //if the room is empty at the chosen date
            {
                int roomNoo = (int)Session["roomNo"];
                saveBooking.updateRoomBooking("Unavailable", Convert.ToInt32(roomNo));
              
                DAL access = new DAL();
                access.createCustomers();
                Dictionary<string, Customer> customers = access.getHotelCustomers();
                string email = (string)Session["emailaddress"];
                Customer c = (Customer)Session["CustomerSession"];
              
                c = customers[email];
                string bookingIDFromLabel = lblShowBookingID.Text;
                access.saveBookingToDb(bookingIDFromLabel, parseArrival, parseDeparture, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType, c.getCustomerID(), roomNoo);
                access.generateCustomerReceipt(bookingIDForPDF);
                btnGeneratePDFF(); //generates the email receipt
                sendReceiptEmail();//sends the email receipt
            }
            else //room is occupied
            {
                //unneeded code as validation is done on previous page
            }




            /* DAL access = new DAL();
             access.createCustomers();
             Dictionary<string, Customer> customers = access.getHotelCustomers(); ******** CODE MOVED TO ABOVE
             string email = (string)Session["emailaddress"];
             Customer c = (Customer)Session["CustomerSession"];
             int roomNo = 10; //not sure how to assign roomNumber yet
             c = customers[email];
             string bookingIDFromLabel = lblShowBookingID.Text;
             access.saveBookingToDb(bookingIDFromLabel, parseArrival, parseDeparture, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType, c.getCustomerID(), roomNo);*/


        }
        else //i.e. if balance == 0
        {
            lblShowBookingID.Text = "Your card has been declined.";
        }
    
    }

    public void sendReceiptEmail() //sends a receipt to the user once their room has been booked and paid for
    {
        DAL d = new DAL();
        MailMessage message = new MailMessage();
        string myEmail = "<removed>@gmail.com";
        string myPassword = "<removed>";
        string toEmail = "<removed>@live.com";
        Attachment data = new Attachment(@"<rmoved>\Implementation\DroversLodge\Reports\DLReceipt.pdf", MediaTypeNames.Application.Octet);
        
        message.From = new MailAddress(myEmail);
        message.To.Add(toEmail);
        message.CC.Add("<removed>@gmail.com");
        message.Subject = "Thanks for staying with Drovers Lodge!";
        Customer tempCust = (Customer)Session["CustomerSession"];
        
        message.Body = tempCust.getFirstname() + ", we hope you are looking forward to your stay and we can't wait to see you! We've attached your receipt to the email, regards, Drovers Lodge. \n \n If for any reason you wish to cancel your booking, please do so from your Account page or phone us.";
        //USB message.Attachments.Add(new Attachment(@"G:\Graded Unit\DroversLodge\Reports\DLReceipt.pdf"));
        message.Attachments.Add(data);
    

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

    public void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader) //using the iTextSharp library
    {
        FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
        Document document = new Document();
        document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
        PdfWriter writer = PdfWriter.GetInstance(document, fs);

        document.Open();

        //Report Header
        BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        Font fntHead = new Font(bfntHead, 8, 1, Color.GRAY);
        Paragraph prgHeading = new Paragraph();
        prgHeading.Alignment = Element.ALIGN_CENTER;
        prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
        document.Add(prgHeading);

        //Author
        Paragraph prgAuthor = new Paragraph();
        BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
        prgAuthor.Alignment = Element.ALIGN_RIGHT;
        prgAuthor.Add(new Chunk("Author : ", fntAuthor));
        prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
        document.Add(prgAuthor);

        //Add a line seperation
        Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 50.00F, Color.BLACK, Element.ALIGN_LEFT, 1)));
        document.Add(p);

        //Add line break
        document.Add(new Chunk("\n", fntHead));

        //Write the table
        PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
        //Table header
        BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        Font fntColumnHeader = new Font(btnColumnHeader, 6, 1, Color.BLACK);
        for (int i = 0; i < dtblTable.Columns.Count; i++)
        {
            PdfPCell cell = new PdfPCell();
            cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
            table.AddCell(cell);
        }
        //table Data
        Font fntDatafont = new Font(btnColumnHeader, 6, 1, Color.BLACK);
        for (int i = 0; i < dtblTable.Rows.Count; i++)
        {
            for (int j = 0; j < dtblTable.Columns.Count; j++)
            {
                PdfPCell datacell = new PdfPCell();
                datacell.AddElement(new Chunk(dtblTable.Rows[i][j].ToString(), fntDatafont));//swapped i and j
                table.AddCell(datacell);
                //table.AddCell(dtblTable.Rows[i][j].ToString());
            }
        }

        document.Add(table);
        document.Close();
        writer.Close();
        fs.Close();
    }

    public void btnGeneratePDFF()
    {
        try
        {
            DAL dal = new DAL();
            DataTable dtbl = dal.generateCustomerReceipt(bookingIDForPDF);
             ExportDataTableToPdf(dtbl, @"\DLReceipt.pdf", "Bookings");
            //ExportDataTableToPdf(dtbl, @"D:\Graded Unit\DroversLodge\Reports\DLReceipt.pdf", "Bookings");
             System.Diagnostics.Process.Start(@"DLReceipt.pdf");
           // System.Diagnostics.Process.Start(@"D:\Graded Unit\DroversLodge\Reports\DLReceipt.pdf");
        
            //filepaths need changed between computers
        }
        catch (Exception ex)
        {
            string g = ex.Message;
        }
    }


    protected void btnGoHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");//redirect
    }
}
