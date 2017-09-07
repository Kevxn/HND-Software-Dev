using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// DAL is used to read from and write to the database
/// </summary>
public class DAL
{
    private Dictionary<string, Customer> hotelCustomers;
    private Dictionary<string, RoomBooking> roomBookings;
    private Dictionary<string, string> hotelAccounts;
    private Dictionary<string, Card> customerCards;
    private Dictionary<string, Staff> hotelStaff;
    private Dictionary<string, Room> hotelRooms;
    private Dictionary<string, Room> availableRooms;
    private Dictionary<string, RoomBooking> checkBookings;
    private Dictionary<string, RoomBooking> todaysArrivals;
    private Dictionary<string, EmailConfirmation> confirmations;
    private Dictionary<string, RoomBooking> showingCustomerBookings;


    private string connString;
    private OleDbConnection conn;
    private OleDbCommand cmd;

    public Dictionary<string, string> getHotelAccounts() { return hotelAccounts; }
    public Dictionary<string, Customer> getHotelCustomers() { return hotelCustomers; }
    public Dictionary<string, RoomBooking> getRoomBookings() { return roomBookings; }
    public Dictionary<string, Card> getCustomerCards() { return customerCards; }
    public Dictionary<string, Staff> getHotelStaff() { return hotelStaff; }
    public Dictionary<string, Room> getHotelRooms() { return hotelRooms; }
    public Dictionary<string, Room> getAvailableRooms() { return availableRooms; }
    public Dictionary<string, RoomBooking> getCheckBookings() { return checkBookings; }
    public Dictionary<string, RoomBooking> getTodaysArrivals() { return todaysArrivals; }
    public Dictionary<string, EmailConfirmation> getConfirmations() { return confirmations; }
    public Dictionary<string, RoomBooking> getShowingCustomerBookings() { return showingCustomerBookings; }
    public string getCustomerID() {return customerid; }
    public string getBookID() {return bookingID;}

    //Customer ATTRIBUTES

    string customerid;
    string firstname;
    string surname;
    string telephoneNo;
    string mobileNo;
    string postcode;
    string email;
    string addressLine1;
    string addressLine2;
    string addressLine3;
    DateTime joinDate = DateTime.Now;
    string password;

    //END OF Customer ATTRIBUTES
    //Booking ATTRIBUTES
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
    //END OF Booking ATTRIBUTES
    // Card ATTRIBUTES

    string paymentID;
    string cardNo;
    string expiryDate;
    string securityCode;
    string cardType;
    double balance;

    //END OF CARD ATTRIBUTES
    //Staff ATTRIBUTES
    string staffID;
    string eRole;
    string eFirstname;
    string eSurname;
    string eEmail;
    string ePostcode;
    string eAddressLine1;
    string eAddressLine2;
    string eAddressLine3;
    string eTelephoneNo;
    string eMobileNo;
    string ePassword;
    string eBankAccNo;
    string eBankSortCode;
    float eSalary;
    DateTime eStartDate;

    //END OF Staff ATTRIBUTES
    //ATTRIBUTES FOR Room 

    string roomNo;
    string rRoomType;
    string description;
    float roomPrice;
    string roomStatus;


    //END OF ATTRIBUTES FOR Room
    //ATTRIBUTES FOR ROOMAVAIL...
    int cRoomID;
    string cArrivalDate;
    string cDepartureDate;

    public int getCRoomID() { return cRoomID; }
    public string getCArrivalDate() { return cArrivalDate; }
    public string getCDepartureDate() { return cDepartureDate; }
    public void setCRoomID(int cRoomID) { this.cRoomID = cRoomID; }
    public void setCArrivalDate(string cArrivalDate) { this.cArrivalDate = cArrivalDate; }
    public void setCDepartureDate(string cDepartureDate) { this.cDepartureDate = cDepartureDate; }
    //END OF ROOMAVAIL QUERY ATTRIBUTES
    DateTime retriveNextDate;//for checking next available date
    public DateTime getNextAvailDate() { return retriveNextDate; }
    public void setNextAvailDate(DateTime retriveNextDate) { this.retriveNextDate = retriveNextDate; }

    public DAL()
    {
        connString = ConfigurationManager.ConnectionStrings["KevinGrayDB"].ConnectionString;
        conn = new OleDbConnection(connString);
        hotelAccounts = new Dictionary<string, string>();
        hotelCustomers = new Dictionary<string, Customer>();
        roomBookings = new Dictionary<string, RoomBooking>();
        customerCards = new Dictionary<string, Card>();
        hotelStaff = new Dictionary<string, Staff>();
        hotelRooms = new Dictionary<string, Room>();
        availableRooms = new Dictionary<string, Room>();
        checkBookings = new Dictionary<string, RoomBooking>();
        todaysArrivals = new Dictionary<string, RoomBooking>();
        confirmations = new Dictionary<string, EmailConfirmation>();
        showingCustomerBookings = new Dictionary<string, RoomBooking>();

    }

    public DataTable retrieveCustomerData()
    {
        string query = "SELECT * FROM Customer";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;
        
        DataTable results = new DataTable(); 

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;
            
        }

        catch(Exception ex)
        {
            return results;
            
        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }
    
    }

    public void createCustomers()
    {
        DataTable customerTable = retrieveCustomerData();
        hotelCustomers.Clear();
        for (int i=0;i <= customerTable.Rows.Count - 1; i++)
        {
             customerid = Convert.ToString(customerTable.Rows[i][0]);
             firstname = Convert.ToString(customerTable.Rows[i][1]);
             surname = Convert.ToString(customerTable.Rows[i][2]);
             telephoneNo = Convert.ToString(customerTable.Rows[i][3]);
             mobileNo = Convert.ToString(customerTable.Rows[i][4]);
             postcode = Convert.ToString(customerTable.Rows[i][5]);
             email = Convert.ToString(customerTable.Rows[i][6]);
             addressLine1 = Convert.ToString(customerTable.Rows[i][7]);
             addressLine2 = Convert.ToString(customerTable.Rows[i][8]);
             addressLine3 = Convert.ToString(customerTable.Rows[i][9]);
             joinDate = Convert.ToDateTime(customerTable.Rows[i][10]);
             password = Convert.ToString(customerTable.Rows[i][11]);
             string generatedCode = Convert.ToString(customerTable.Rows[i][12]);


            //testing below Customer currentCustomer = new Customer(customerid, joinDate, password, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3);
            Customer currentCustomer = new Customer(customerid, joinDate, password, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3);
            currentCustomer.addAccount(currentCustomer);
            hotelCustomers.Add(email, currentCustomer);
         //   hotelAccounts.Add(email, password);
           
            

           
        }

    }

    public void saveCustomerToDb(string customerid, DateTime joinDate, string password, string firstname, string surname, string telephoneNo,
        string mobileNo, string postcode, string email, string addressLine1, string addressLine2, string addressLine3)
    {
        try
        {
         string query = "INSERT INTO Customer VALUES ('" +
                customerid + "','" + firstname + "','" + surname + 
                "','" + telephoneNo + "','" + mobileNo + "','" + postcode + "','" + email + "','" +
                addressLine1 + "','" + addressLine2 + "','" + addressLine3 + "','" + joinDate + "','" + password +"','" + "" + "')";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
                   
        }

        catch(Exception e)
        {
            string message = e.Message;
        }
    }


    public void insertEmailAndConfirmationCode(string emaila, string code)
    {
        try
        {
            string query = "INSERT INTO TempConfirmEmail VALUES ('" + emaila + "', '"+ code +"');";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception e)
        {
            string s = e.Message;
        }
    }

    public DataTable retriveConfirmationDetails()
    {
        string query = "SELECT * FROM TempConfirmEmail";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;

        DataTable results = new DataTable();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;

        }

        catch (Exception ex)
        {
            return results;

        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }

    }

    public void createTempConfirmEmailTable()
    {
        DataTable confirmEmail = retriveConfirmationDetails();
        confirmations.Clear();//resetting

        for (int i = 0; i <= confirmEmail.Rows.Count - 1; i++)
        {
           string cConfirmEmail = Convert.ToString(confirmEmail.Rows[i][0]);
           string cCode = Convert.ToString(confirmEmail.Rows[i][1]);

            EmailConfirmation emailsAndCodes = new EmailConfirmation(cConfirmEmail, cCode);//change
            confirmations.Add(cConfirmEmail, emailsAndCodes);
        }

    }


    public DataTable retrieveBookingData()
    {
        string query = "SELECT * FROM Booking";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;

        DataTable results = new DataTable();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;

        }

        catch (Exception ex)
        {
            return results;

        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }

    }

    public void createBookings()
    {
        DataTable bookingTable = retrieveBookingData();

        for (int i = 0; i <= bookingTable.Rows.Count - 1; i++)
        {
            bookingID = Convert.ToString(bookingTable.Rows[i][0]);
            arrivalDate = Convert.ToDateTime(bookingTable.Rows[i][1]);
            departureDate = Convert.ToDateTime(bookingTable.Rows[i][2]);
            numberOfAdults = Convert.ToInt32(bookingTable.Rows[i][3]);
            numberOfChildren = Convert.ToInt32(bookingTable.Rows[i][4]);

            fullBoard = Convert.ToString(bookingTable.Rows[i][5]); //this wont work as database fields have changed
            halfBoard = Convert.ToString(bookingTable.Rows[i][6]);
            bAndB = Convert.ToString(bookingTable.Rows[i][7]);
            noBoard = Convert.ToString(bookingTable.Rows[i][8]);
            breakfast = Convert.ToString(bookingTable.Rows[i][9]);
            lunch = Convert.ToString(bookingTable.Rows[i][10]);
            eveningMeal = Convert.ToString(bookingTable.Rows[i][11]);
            noMeal = Convert.ToString(bookingTable.Rows[i][12]);

            roomType = Convert.ToString(bookingTable.Rows[i][13]);

            

            //testing below Customer currentCustomer = new Customer(customerid, joinDate, password, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3);
            RoomBooking currentBooking = new RoomBooking(bookingID, arrivalDate, departureDate, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType);
           //currentBooking.addAccount(currentBooking);
            roomBookings.Add(bookingID, currentBooking); //change this
            //hotelAccounts.Add(email, password);
            


}

    }


    public void saveBookingToDb(string bookingID, DateTime arrivalDate, DateTime departureDate, int numberOfAdults, int numberOfChildren, string fullBoard,
     string halfBoard, string bAndB, string noBoard, string breakfast, string lunch, string eveningMeal, string noMeal, string roomType, string custID, int roomNo)
    {
        
        try
        {
           

            string query = "INSERT INTO Booking VALUES ('" +
            bookingID + "','" + arrivalDate + "','" + departureDate +
            "','" + numberOfAdults + "','" + numberOfChildren + "','" + fullBoard + "','" + halfBoard + "','" +
            bAndB + "','" + noBoard + "','" + breakfast + "','" + lunch + "','" + eveningMeal + "','" + noMeal + "','" + roomType + "','" + custID + "','" + roomNo + "','" + "No"+ "','" + "No" + "')";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }

        catch (Exception e)
        {
            string message = e.Message;
        }
    }

    public void checkCustomerIn(string bookingIDToCheckIn)
    {
        string checkInCustomer = "Yes";

        try
        {
            string query = "UPDATE Booking SET checkedIn = '"+checkInCustomer+"' WHERE bookingID = '"+ bookingIDToCheckIn +"';";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception e)
        {
            string msg = e.Message;
        }
    }

    public void checkCustomerOut(string bookingIDToCheckOut)
    {
        string checkOutCustomer = "Yes";

        try
        {
            string query = "UPDATE Booking SET checkedOut = '" + checkOutCustomer + "' WHERE bookingID = '" + bookingIDToCheckOut + "';";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception e)
        {
            string msg = e.Message;
        }
    }

    public DataTable retrieveCardData()
    {
        string query = "SELECT * FROM Card";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;

        DataTable results = new DataTable();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;

        }

        catch (Exception ex)
        {
            return results;

        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }

    }

    public void createCards()
    {
        DataTable cardTable = retrieveCardData();

        for (int i = 0; i <= cardTable.Rows.Count - 1; i++)
        {
            paymentID = Convert.ToString(cardTable.Rows[i][0]);
            cardNo = Convert.ToString(cardTable.Rows[i][1]);
            expiryDate = Convert.ToString(cardTable.Rows[i][2]);
            securityCode = Convert.ToString(cardTable.Rows[i][3]);
            cardType = Convert.ToString(cardTable.Rows[i][4]);
            balance = Convert.ToDouble(cardTable.Rows[i][5]);
            email = Convert.ToString(cardTable.Rows[i][6]);

            Card newCard = new Card(paymentID, cardNo, balance, cardType, expiryDate, securityCode, email);
            customerCards.Add(email, newCard); 
                                                         

        }

    }

    public string generatePaymentID()
    {
        string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder b = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 9; i++)
        {
            ch = input[r.Next(0, input.Length)];
            b.Append(ch);
        }

        return "P" + b.ToString();
    }

    public void saveCardToDb(string paymentID, string cardNo, string expiryDate, string securityCode, string cardType, double balance, string email)
    {
        try
        {
            string query = "INSERT INTO Card VALUES ('" + generatePaymentID() + "','" + cardNo + "','" + expiryDate + "','" + securityCode + "','" + cardType + "','" + balance + "','" + email + "')";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        catch (Exception e)
        {
            string message = e.Message;
        }
    }


    public void updateCardBalance(double balance, string uEmail)
    {
        try
        {
            string updateQuery = "UPDATE Card SET balance = @balance WHERE Card.email = @uEmail" ;

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(updateQuery, conn);
            cmd.Parameters.Add("@balance", balance);
            cmd.Parameters.Add("@email", uEmail);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        catch (Exception e)
        {
            string message = e.Message;
        }
        
    }

    public void writeStaffToDb(string staffID, string role, string firstname, string surname, string email, string postcode, string addressLine1, string addressLine2, string addressLine3, string telephoneNo, string mobileNo, string password, string bankAccNo, string bankSortCode, float salary, DateTime startDate)
    {
        try
        {
            string query = "INSERT INTO Staff VALUES  ('" + generateStaffID() + "','" + role + "','" + firstname + "','" + surname + "','" + email + "','" + postcode + "','" + addressLine1 + "','" + addressLine2 + "','" + addressLine3 + "','" + telephoneNo + "','" + mobileNo + "','" + password + "','" + bankAccNo + "','" + bankSortCode + "','" + salary + "','" + startDate + "')";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch(Exception e)
        {
            string error = e.Message;
        }
    }

    public DataTable retrieveStaffData()
    {
        string query = "SELECT * FROM Staff";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;

        DataTable results = new DataTable();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;

        }

        catch (Exception ex)
        {
            return results;

        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }

    }

    public void createStaff()
    {
        DataTable staffTable = retrieveStaffData();

        for (int i = 0; i <= staffTable.Rows.Count - 1; i++)
        {
            staffID = Convert.ToString(staffTable.Rows[i][0]);
            eRole = Convert.ToString(staffTable.Rows[i][1]);
            eFirstname = Convert.ToString(staffTable.Rows[i][2]);
            eSurname = Convert.ToString(staffTable.Rows[i][3]);
            eEmail = Convert.ToString(staffTable.Rows[i][4]);
            ePostcode = Convert.ToString(staffTable.Rows[i][5]);
            eAddressLine1 = Convert.ToString(staffTable.Rows[i][6]);
            eAddressLine2 = Convert.ToString(staffTable.Rows[i][7]);
            eAddressLine3 = Convert.ToString(staffTable.Rows[i][8]);
            eTelephoneNo = Convert.ToString(staffTable.Rows[i][9]);
            eMobileNo = Convert.ToString(staffTable.Rows[i][10]);
            ePassword = Convert.ToString(staffTable.Rows[i][11]);
            eBankAccNo = Convert.ToString(staffTable.Rows[i][12]);
            eBankSortCode = Convert.ToString(staffTable.Rows[i][13]);
            eSalary = Convert.ToSingle(staffTable.Rows[i][14]);
            eStartDate = Convert.ToDateTime(staffTable.Rows[i][15]);
            

            Staff staff = new Staff(staffID, eRole,  eFirstname,  eSurname,  eEmail,  ePostcode,  eAddressLine1,  eAddressLine2,  eAddressLine3,  eTelephoneNo,  eMobileNo,  ePassword,  eBankAccNo,  eBankSortCode,  eSalary, eStartDate);
            hotelStaff.Add(eEmail, staff);
          

            //not ye tested
        }

    }

    public string generateStaffID()
    {
        string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder b = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 9; i++)
        {
            ch = input[r.Next(0, input.Length)];
            b.Append(ch);
        }

        return "S" + b.ToString();
    }

    public DataTable retrieveRoomData()
    {
        string query = "SELECT * FROM Room";
        cmd = new OleDbCommand(query, conn);

        OleDbDataReader reader;

        DataTable results = new DataTable();

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                results.Load(reader);

            }

            return results;

        }

        catch (Exception ex)
        {
            return results;

        }

        finally
        {
            conn.Close();
            cmd.Dispose();
        }

    }

    public void createRooms()
    {
        DataTable roomTable = retrieveRoomData();

        for (int i = 0; i <= roomTable.Rows.Count - 1; i++)
        {
            roomNo = Convert.ToString(roomTable.Rows[i][0]);
            rRoomType = Convert.ToString(roomTable.Rows[i][1]);
            description = Convert.ToString(roomTable.Rows[i][2]);
            roomPrice = Convert.ToSingle(roomTable.Rows[i][3]);
            roomStatus = Convert.ToString(roomTable.Rows[i][4]);
     
            Room newRoom = new Room(roomNo, rRoomType, description, roomPrice, roomStatus);
            hotelRooms.Add(roomNo, newRoom);

        }

    }

    public void updateRoomBooking(string status, int roomID) //only changes room to unavailable atm
    {
        try
        {
            roomStatus = "Unavailable";
            string query = "UPDATE Room SET status = @roomStatus WHERE Room.roomID = @roomID";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.Add("@roomStatus", status);
            cmd.Parameters.Add("@roomID", roomID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception e)
        {
            string err = e.Message;
        }
        
    }

 

    public DataTable retriveAvailableRooms()   /*RETURNS ONLY THE ROOMS THAT HAVE STATUS = AVAILABLE */
    {

        {
            string query = "SELECT * FROM Room WHERE status = 'Available'";
            cmd = new OleDbCommand(query, conn);

            OleDbDataReader reader;

            DataTable results = new DataTable();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    results.Load(reader);

                }

                return results;

            }

            catch (Exception ex)
            {
                return results;

            }

            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }
    }

    public void createAvailableRooms()
    {
        DataTable roomTable = retriveAvailableRooms();

        for (int i = 0; i <= roomTable.Rows.Count - 1; i++)
        {
            roomNo = Convert.ToString(roomTable.Rows[i][0]);
            rRoomType = Convert.ToString(roomTable.Rows[i][1]);
            description = Convert.ToString(roomTable.Rows[i][2]);
            roomPrice = Convert.ToSingle(roomTable.Rows[i][3]);
            roomStatus = Convert.ToString(roomTable.Rows[i][4]);

            Room availableRoom = new Room(roomNo, rRoomType, description, roomPrice, roomStatus);
            availableRooms.Add(roomNo, availableRoom);

        }

    }
    
    public DataTable checkIfRoomAvailable(int ccRoomID, string ccArrivalDate, string ccDepartureDate)
    {
        setCRoomID(ccRoomID);
        setCArrivalDate(ccArrivalDate); //trying to use these values in retreive method below
        setCDepartureDate(ccDepartureDate);
        {
           string query = "SELECT * FROM Booking WHERE roomID = " + ccRoomID + " AND arrivalDate <= #" + ccDepartureDate + "# AND departureDate >= #"+ccArrivalDate+"#;";
            
            cmd = new OleDbCommand(query, conn);
           // cmd.Parameters.Add("@roomID", cRoomID);
           // cmd.Parameters.Add("@arrivalDate", cArrivalDate);
           // cmd.Parameters.Add("@departureDate", cDepartureDate);
            OleDbDataReader reader;

            DataTable results = new DataTable();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    results.Load(reader);

                }

                return results;

            }

            catch (Exception ex)
            {
                return results;

            }

            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }

    }

    public void bookingAvailabilityChecker()
    {
        DataTable checkBooking = checkIfRoomAvailable(getCRoomID(), getCArrivalDate(), getCDepartureDate());

        for (int i = 0; i <= checkBooking.Rows.Count - 1; i++)
        {
            bookingID = Convert.ToString(checkBooking.Rows[i][0]);
            arrivalDate = Convert.ToDateTime(checkBooking.Rows[i][1]);
            departureDate = Convert.ToDateTime(checkBooking.Rows[i][2]);
            numberOfAdults = Convert.ToInt32(checkBooking.Rows[i][3]);
            numberOfChildren = Convert.ToInt32(checkBooking.Rows[i][4]);
            fullBoard = Convert.ToString(checkBooking.Rows[i][5]); //all convert.toboolean these might conflict with other booking variables
            halfBoard = Convert.ToString(checkBooking.Rows[i][6]);
            bAndB = Convert.ToString(checkBooking.Rows[i][7]);
            noBoard = Convert.ToString(checkBooking.Rows[i][8]);
            breakfast = Convert.ToString(checkBooking.Rows[i][9]);
            lunch = Convert.ToString(checkBooking.Rows[i][10]);
            eveningMeal = Convert.ToString(checkBooking.Rows[i][11]);
            noMeal = Convert.ToString(checkBooking.Rows[i][12]);
            roomType = Convert.ToString(checkBooking.Rows[i][13]);
            string checkerCustomerID = Convert.ToString(checkBooking.Rows[i][14]);
            int checkerRoomID = Convert.ToInt32(checkBooking.Rows[i][15]);
            string checkedIn = "";
            string checkedOut = "";




            //testing below Customer currentCustomer = new Customer(customerid, joinDate, password, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3);
            RoomBooking bookingsByQuery = new RoomBooking(bookingID, arrivalDate, departureDate, numberOfAdults, numberOfChildren, fullBoard, halfBoard, bAndB, noBoard, breakfast, lunch, eveningMeal, noMeal, roomType, checkerCustomerID, checkerRoomID, checkedIn, checkedOut);
            checkBookings.Add(bookingID, bookingsByQuery); 



        }

    }

    public DataTable retrieveTodaysBookings()
    {
       
     //trying to use these values in retreive method below
        
        {
            string query = "SELECT * FROM Booking WHERE arrivalDate = Date();";

            cmd = new OleDbCommand(query, conn);
            // cmd.Parameters.Add("@roomID", cRoomID);
            // cmd.Parameters.Add("@arrivalDate", cArrivalDate);
            // cmd.Parameters.Add("@departureDate", cDepartureDate);
            OleDbDataReader reader;

            DataTable results = new DataTable();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    results.Load(reader);

                }

                return results;

            }

            catch (Exception ex)
            {
                return results;

            }

            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }

    }

    public void checkTodaysArrivals()
    {
        DataTable todaysArrivalsTable = retrieveTodaysBookings();

        for (int i = 0; i <= todaysArrivalsTable.Rows.Count - 1; i++)
        {
            string tbookingID = Convert.ToString(todaysArrivalsTable.Rows[i][0]);
            DateTime tarrivalDate = Convert.ToDateTime(todaysArrivalsTable.Rows[i][1]);
            DateTime tdepartureDate = Convert.ToDateTime(todaysArrivalsTable.Rows[i][2]);
            int tnumberOfAdults = Convert.ToInt32(todaysArrivalsTable.Rows[i][3]);
            int tnumberOfChildren = Convert.ToInt32(todaysArrivalsTable.Rows[i][4]);
            string tfullBoard = Convert.ToString(todaysArrivalsTable.Rows[i][5]); 
            string thalfBoard = Convert.ToString(todaysArrivalsTable.Rows[i][6]);
            string tbAndB = Convert.ToString(todaysArrivalsTable.Rows[i][7]);
            string tnoBoard = Convert.ToString(todaysArrivalsTable.Rows[i][8]);
            string tbreakfast = Convert.ToString(todaysArrivalsTable.Rows[i][9]);
            string tlunch = Convert.ToString(todaysArrivalsTable.Rows[i][10]);
            string teveningMeal = Convert.ToString(todaysArrivalsTable.Rows[i][11]);
            string tnoMeal = Convert.ToString(todaysArrivalsTable.Rows[i][12]);
            string troomType = Convert.ToString(todaysArrivalsTable.Rows[i][13]);
            string tcheckerCustomerID = Convert.ToString(todaysArrivalsTable.Rows[i][14]);
            int tcheckerRoomID = Convert.ToInt32(todaysArrivalsTable.Rows[i][15]);
            string checkedIn = Convert.ToString(todaysArrivalsTable.Rows[i][16]);
            string checkedOut = Convert.ToString(todaysArrivalsTable.Rows[i][17]);



            //testing below Customer currentCustomer = new Customer(customerid, joinDate, password, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3);
            RoomBooking todaysArrivalss = new RoomBooking(tbookingID, tarrivalDate, tdepartureDate, tnumberOfAdults, tnumberOfChildren, tfullBoard, thalfBoard, tbAndB, tnoBoard, tbreakfast, tlunch, teveningMeal, tnoMeal, troomType, tcheckerCustomerID, tcheckerRoomID, checkedIn, checkedOut);
            todaysArrivals.Add(tbookingID, todaysArrivalss);



        }

    }

    public DataTable retriveRoomAvailabilityDate(string roomType)
    {

        //trying to use these values in retreive method below

        {
            string query = "SELECT MAX(departureDate) FROM Booking WHERE roomType = '" + roomType + "';";

            cmd = new OleDbCommand(query, conn);
          
            OleDbDataReader reader;

            DataTable results = new DataTable();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    results.Load(reader);

                }

                return results;

            }

            catch (Exception ex)
            {
                return results;

            }

            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }

    }

    public void getNextAvailableRoomDate(string inptRoomType)
    {
        DataTable nextAvailDate = retriveRoomAvailabilityDate(inptRoomType);

        for (int i = 0; i <= nextAvailDate.Rows.Count - 1; i++)
        {
            DateTime tdepartureDate = Convert.ToDateTime(nextAvailDate.Rows[i][0]);
            setNextAvailDate(tdepartureDate);

        }

    }
    public void exportDeparturesToExcel()
    {
        string strDelimiter = ","; //seperating column values with commas (for csv file)
        string cs = ConfigurationManager.ConnectionStrings["KevinGrayDB"].ConnectionString;
        StringBuilder sb = new StringBuilder();
        using (OleDbConnection con = new OleDbConnection(cs))
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT bookingID, departureDate, customerID, roomID FROM Booking WHERE departureDate = Date();", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ds.Tables[0].TableName = "TodaysDepartures";
            sb.Append("BookingID" + strDelimiter);
            sb.Append("Departure Date" + strDelimiter);
            sb.Append("CustomerID" + strDelimiter);
            sb.Append("Room Number");
            sb.Append("\n");
            foreach (DataRow bookingDR in ds.Tables["TodaysDepartures"].Rows)
            {
                string bookingID = Convert.ToString(bookingDR["bookingID"]);
                sb.Append(bookingID.ToString() + strDelimiter);
                sb.Append(bookingDR["departureDate"].ToString() + strDelimiter);
                sb.Append(bookingDR["customerID"].ToString() + strDelimiter);
                sb.Append(bookingDR["roomID"].ToString());
                sb.Append("\n\r");

            }
        }
        StreamWriter file = new StreamWriter(@"C:\Users\Kevin\Desktop\Running from MyCity\Kevin Gray\Kevin Gray\Development stage\Implementation\DroversLodge\Reports\Departures.csv");//change this file for use on other computers
        file.WriteLine(sb.ToString());
        file.Close();
    }

    public void exportArrivalToExcel()
    {
        string strDelimiter = ","; //seperating column values with commas (for csv file)
        string cs = ConfigurationManager.ConnectionStrings["KevinGrayDB"].ConnectionString;
        StringBuilder sb = new StringBuilder();
        using (OleDbConnection con = new OleDbConnection(cs))
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT bookingID, arrivalDate, customerID, roomID FROM Booking WHERE arrivalDate = Date();", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ds.Tables[0].TableName = "TodaysArrival";
            sb.Append("BookingID" + strDelimiter);
            sb.Append("Arrival Date" + strDelimiter);
            sb.Append("CustomerID" + strDelimiter);
            sb.Append("Room Number");
            sb.Append("\n");
            foreach (DataRow bookingDR in ds.Tables["TodaysArrival"].Rows)
            {
                string bookingID = Convert.ToString(bookingDR["bookingID"]);
                sb.Append(bookingID.ToString() + strDelimiter);
                sb.Append(bookingDR["arrivalDate"].ToString() + strDelimiter);
                sb.Append(bookingDR["customerID"].ToString() + strDelimiter);
                sb.Append(bookingDR["roomID"].ToString());
                sb.Append("\n\r");

            }
        }
        StreamWriter file = new StreamWriter(@"C:\Users\Kevin\Desktop\Running from MyCity\Kevin Gray\Kevin Gray\Development stage\Implementation\DroversLodge\Reports\Arrivals.csv"); //chnage when at home
        file.WriteLine(sb.ToString());
        file.Close();
    }

    public DataTable generateCustomerReceipt(string receiptBookingID)
    {
        OleDbConnection conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["KevinGrayDB"].ConnectionString);
        conn.Open();
        string query = "SELECT * FROM Booking WHERE bookingID = '" + receiptBookingID + "';";
       // string query = "SELECT * FROM Booking WHERE bookingID = '" + receiptBookingID + "';";
        OleDbCommand cmd = new OleDbCommand(query, conn);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());
        return dt;
    }

    public DataTable getBookingsForCustomer(string cID)//gets all of the booking for the current customer, used in ViewAccount.aspx.cs 
    {

        //trying to use these values in retreive method below

        {
           
            string query = "SELECT bookingID, arrivalDate, departureDate, roomType, roomID FROM Booking WHERE customerID = '" + cID + "';";

            cmd = new OleDbCommand(query, conn);

            OleDbDataReader reader;

            DataTable results = new DataTable();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    results.Load(reader);

                }

                return results;

            }

            catch (Exception ex)
            {
                return results;

            }

            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }

    }


    public void showAllCustomerBookings(string cID)
    {
        DataTable customerBookings = getBookingsForCustomer(cID);

        for (int i = 0; i <= customerBookings.Rows.Count - 1; i++)
        {
            string showBookingID = Convert.ToString(customerBookings.Rows[i][0]);
            DateTime showArrivalDate = Convert.ToDateTime(customerBookings.Rows[i][1]);
            DateTime showDepartureDate = Convert.ToDateTime(customerBookings.Rows[i][2]);
            string showRoomType = Convert.ToString(customerBookings.Rows[i][3]);
            int showRoomID = Convert.ToInt32(customerBookings.Rows[i][4]);

            RoomBooking availableRoom = new RoomBooking(showBookingID, showArrivalDate, showDepartureDate, showRoomType, showRoomID);
            showingCustomerBookings.Add(showBookingID, availableRoom);

        }

    }

    public void cancelBooking(string bID)
    {

        try
        {
            string query = "DELETE * FROM Booking WHERE bookingID = '" + bID + "';";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception e)
        {
            string err = e.Message;
        }

    }

    public void deleteTempEmail(string delEmail)
    { try
        {


            string query = "DELETE * FROM TempConfirmEmail WHERE email = '" + delEmail + "';";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception e)
        {

        }
  }

}