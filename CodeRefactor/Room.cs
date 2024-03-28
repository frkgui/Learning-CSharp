using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Room
    {

    private static int lastId = 0;
    private int idRoom;
    private Boolean isBooked = false; // Room var "isBooked" already start set as "false".
    private int? idGuestWhoBooked;

    public Room()
    {
        idRoom = ++lastId;

    }
    public int IdRoom
    {
        get { return idRoom; }
    }
    public string stringIsBooked()
    {
        if (this.isBooked == false){ return "Free"; }
        return "Ocupied";
    }
    public bool IsBooked { 
        get{ return isBooked; }
        set{ isBooked = value; }
    }

    public void bookRoom(int idGuest) {
        this.IsBooked = true;
        this.idGuestWhoBooked = idGuest;
    }
    public void checkoutRoom()
    {
        this.IsBooked = false;
        this.idGuestWhoBooked = null;
    }




}
