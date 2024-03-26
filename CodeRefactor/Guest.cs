using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Guest
{
    private static int lastId = 0;
    private int idGuest;
    private string guestName;
    private string guestCPF;
    private string guestPhone;

    public Guest()
    {
        idGuest = ++lastId;
    }

    public int IdGuest
    {
        get { return idGuest; }
    }
    public string GuestName
    {
        get { return guestName; }
        set { guestName = value; }
    }
    public string GuestCPF
    {
        get { return guestCPF; }
        set { guestCPF = value; }
    }
    public string GuestPhone
    {
        get { return guestPhone; }
        set { guestPhone = value; }
    }
}

