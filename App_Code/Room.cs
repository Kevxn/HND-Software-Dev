using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Room
/// </summary>
public class Room
{ //odd roomIDs are single rooms, even roomIDs are doublerooms, roomIDs over 6 are family rooms,this class might be obsolete

    //variables
    string roomNo;
    string roomType;
    string description;
    float roomPrice;
    string roomStatus;
    Dictionary<string, string> singleRooms = new Dictionary<string, string>();
    Dictionary<string, string> doubleRooms = new Dictionary<string, string>();
    Dictionary<string, string> familyRooms = new Dictionary<string, string>();



    bool isRoomNoBooked = false;

    public string getRoomNo() { return roomNo; }
    public string getRoomType() { return roomType; }
    public string getRoomDescription() { return description; }
    public float getRoomPrice() { return roomPrice; }
    public string getRoomStatus() { return roomStatus; }
    public Dictionary<string, string> getSingleRooms() { return singleRooms; }
    public Dictionary<string, string> getDoubleRooms() { return doubleRooms; }
    public Dictionary<string, string> getFamilyRooms() { return familyRooms; }

    public void setRoomStatus(string roomStatus)
    {
        this.roomStatus = roomStatus;
    }

    public Room()
    {

    }

    //constructor
    public Room(string roomNo, string roomType, string description, float roomPrice, string roomStatus)
    {
        this.roomNo = roomNo;
        this.roomType = roomType;
        this.description = description;
        this.roomPrice = roomPrice;
        this.roomStatus = roomStatus;
    }



    public void addRoomsByID() //trying to add rooms to dictionary so that i can assign a room number based on the type of room chosen
    {
        Dictionary<string, string> singleRooms = new Dictionary<string, string>();
        Dictionary<string, string> doubleRooms = new Dictionary<string, string>();
        Dictionary<string, string> familyRooms = new Dictionary<string, string>();

     //   if (float.Parse(getRoomNo()) % 2 == 0)//even
      //  {
            singleRooms.Add(roomNo, roomStatus);
     //   }
       // else if(float.Parse(roomNo) % 2 != 0 && float.Parse(roomNo) < 7) //odd and less than 7
       // {
            doubleRooms.Add(roomNo, roomStatus);
      //  }
     //   else
     //   {
            familyRooms.Add(roomNo, roomStatus);
    //    }
        
    }
}