using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Booking
/// </summary>
public class RoomBooking
{
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
    int roomID;//for seeing what room is booked
    string checkedIn;

    //getters
    public string getBookingID() { return bookingID; }
    public DateTime getArrivalDate(){return arrivalDate;}
    public DateTime getDepartureDate(){return departureDate;}
    public int getNumberOfAdults() { return numberOfAdults; }
    public int getNumberOfChildren() { return numberOfChildren; }
    public string getFullBoard(){return fullBoard;}
    public string getHalfBoard(){return halfBoard;}
    public string getBandB(){return bAndB;}
    public string getNoBoard(){return noBoard;}
    public string getBreakfast(){return breakfast;}
    public string getLunch(){return lunch;}
    public string getEveningMeal(){ return eveningMeal;}
    public string getNoMeal(){return noMeal;}
    public string getRoomType() { return roomType; }
    public int getRoomID() { return roomID; }
   
    //setters
    
    public void setArrivalDate(DateTime arrivalDate) { this.arrivalDate = arrivalDate; }
    public void setDepartureDate(DateTime departureDate) { this.departureDate = departureDate; }
    public void setNumberOfAdults(int numberOfAdults) { this.numberOfAdults = numberOfAdults; }
    public void setNumberOfChildren(int numberOfChildren) { this.numberOfChildren = numberOfChildren; }
    public void setFullBoard(string fullBoard) { this.fullBoard = fullBoard; }
    public void setHalfBoard(string halfBoard) { this.halfBoard = halfBoard; }
    public void setBandB(string bAndB) { this.bAndB = bAndB; }
    public void setNoBoard(string noBoard) { this.noBoard = noBoard; }
    public void setBreakfast(string breakfast) { this.breakfast = breakfast; }
    public void setLunch(string lunch) { this.lunch = lunch; }
    public void setEveningMeal(string eveningMeal) { this.eveningMeal = eveningMeal; }
    public void setNoMeal(string noMeal) { this.noMeal = noMeal; }
    public void setBookingID(string bookingID) { this.bookingID = generateBookingID(roomType); }
    public void setRoomType(string roomType) { this.roomType = roomType; }

    public RoomBooking() //empty constructor
    {
        bookingID = getBookingID();
        arrivalDate = DateTime.MinValue;
        departureDate = DateTime.MaxValue;
        numberOfAdults = 0;
        numberOfChildren = 0;
        fullBoard = "";
        halfBoard = "";
        bAndB = "";
        noBoard = "";
        breakfast = "";
        lunch = "";
        eveningMeal = "";
        noMeal = "";
        roomType = "";
        
    }

    public string generateBookingID(string roomType) //generating the bookingID same as other methods
    {
        string input =  "123456789";
        StringBuilder b = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 3; i++)
        {
            ch = input[r.Next(0, input.Length)];
            b.Append(ch);
        }

        return roomType + b.ToString();
    }
    //constructor 1
    public RoomBooking(string bookingID, DateTime arrivalDate, DateTime departureDate, int numberOfAdults, int numberOfChildren, string fullBoard, string halfBoard, string bAndB, string noBoard, string breakfast, string lunch, string eveningMeal, string noMeal, string roomType)
    {
        this.bookingID = bookingID;
        this.arrivalDate = arrivalDate;
        this.departureDate = departureDate;
        this.numberOfAdults = numberOfAdults;
        this.numberOfChildren = numberOfChildren;
        this.fullBoard = fullBoard;
        this.halfBoard = halfBoard;
        this.bAndB = bAndB;
        this.noBoard = noBoard;
        this.breakfast = breakfast;
        this.lunch = lunch;
        this.eveningMeal = eveningMeal;
        this.noMeal = noMeal;
        this.roomType = roomType;
    }

    //contructor 2
    public RoomBooking(string bookingID, DateTime arrivalDate, DateTime departureDate, int numberOfAdults, int numberOfChildren, string fullBoard, string halfBoard, string bAndB, string noBoard, string breakfast, string lunch, string eveningMeal, string noMeal, string roomType, string customerID, int roomID, string checkedIn, string checkedOut)
    {
        this.bookingID = bookingID;
        this.arrivalDate = arrivalDate;
        this.departureDate = departureDate;
        this.numberOfAdults = numberOfAdults;
        this.numberOfChildren = numberOfChildren;
        this.fullBoard = fullBoard;
        this.halfBoard = halfBoard;
        this.bAndB = bAndB;
        this.noBoard = noBoard;
        this.breakfast = breakfast;
        this.lunch = lunch;
        this.eveningMeal = eveningMeal;
        this.noMeal = noMeal;
        this.roomType = roomType;
        this.roomID = roomID;        
    }

    //new constructor for showing customer bookings
    public RoomBooking(string bookingID, DateTime arrivalDate, DateTime departureDate, string roomType, int roomID)
    {
        this.bookingID = bookingID;
        this.arrivalDate = arrivalDate;
        this.departureDate = departureDate;
        this.roomType = roomType;
        this.roomID = roomID;

    }


}