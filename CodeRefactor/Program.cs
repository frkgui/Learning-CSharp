
// Application inital Config Information

using System.Runtime.CompilerServices;

Console.Write("Type the hotel name: ");
string hotelName = Console.ReadLine();
Console.Write($"Type the numbers of rooms [{hotelName}] have: ");
int hotelNumberOfRooms = int.Parse(Console.ReadLine());
int idGuest = 0;

// Initializing every important var.
Room[] allRooms = new Room[hotelNumberOfRooms];
for (int i = 0; i < hotelNumberOfRooms; i++){
    allRooms[i] = new Room();
}

List<Room> availableRooms = new List<Room>(allRooms);
List<Guest> guestList = new List<Guest>();

int userChoice = 0;
int menuUserChoice = 0; // var that will be used inside the options menu. 

// Application Start...
Console.Write("\nInitialing...");
System.Threading.Thread.Sleep(450);


// An especif option will start based on user choice.
do
{
    // Main Menu
    Console.Clear();
    Console.WriteLine($"{hotelName} System: \n");

    Console.WriteLine("(1) - Guests");
    Console.WriteLine("(2) - Rooms");
    Console.WriteLine("(3) - Books");
    Console.WriteLine("(0) - Exit");

    Console.Write("\nType your option: ");
    userChoice = int.Parse(Console.ReadLine());


    
    switch (userChoice)
    {

        case 1: // Guest Menu

            do
            { 
                Console.Clear();

                Console.WriteLine($"{hotelName} > Guests: \n");

                Console.WriteLine("(1) - Add new Guest");
                Console.WriteLine("(2) - Show all Guests");
                Console.WriteLine("(3) - Delete guest");
                Console.WriteLine("(0) - Back");
                Console.Write("\nWhat do you want to do?: ");
                menuUserChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                    
                    switch (menuUserChoice)
                    {
                        case 0:break;

                        // Adding a new guest to the system;
                        case 1:

                            Guest newGuest = new Guest();   

                            Console.Write("Guest Name: ");
                            newGuest.GuestName = Console.ReadLine();
                            Console.Write("Guest CPF: ");
                            newGuest.GuestCPF = Console.ReadLine();
                            Console.Write("Guest Phone: ");
                            newGuest.GuestPhone = Console.ReadLine();

                            int countBeforeAdd = guestList.Count;

                            guestList.Add(newGuest);

                            int countAfterAdd = guestList.Count;

                            if (countAfterAdd > countBeforeAdd)
                            {
                                Console.WriteLine($"\n{newGuest.GuestName} was created and added to the list!");
                            }
                            else
                            {
                                Console.WriteLine("Failed to add the guest to the list.");
                            }
                            System.Threading.Thread.Sleep(850);

                            break;

                        case 2:
                            for (int i = 0; i < guestList.Count; i++)
                            {
                                Guest guest = guestList[i];
                                Console.WriteLine($"Id: {guest.IdGuest}, Name: {guest.GuestName}, CPF: {guest.GuestCPF}, Phone: {guest.GuestPhone}");
                            
                            }

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("\nType the guest id: ");
                            string stringRemoveGuestRequest = Console.ReadLine();
                            int idRemoveGuestRequest = int.Parse(stringRemoveGuestRequest);

                        for (int i = 0; i < guestList.Count; i++)
                        {
                            if (guestList[i].IdGuest == idRemoveGuestRequest)
                            {
                                guestList.RemoveAt(i);
                                Console.WriteLine("\nGuest sucessfully removed!");

                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey();
                            }  
                        }
                        break;
               
                    }

            }while (menuUserChoice != 0) ;

            break;

        case 2: // Room Menu
            do {   
                Console.Clear();

                Console.WriteLine($"{hotelName} > Rooms: \n");

                Console.WriteLine("(1) - Check all rooms status");
                Console.WriteLine("(2) - Show all avaliable rooms");
                Console.WriteLine("(0) - Back");
                Console.Write("\nWhat do you want to do?: ");
                menuUserChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (menuUserChoice)
                {
                    case 0:break;
                    case 1:
                        foreach (Room room in allRooms)
                        {
                            Console.WriteLine($"Room number: {room.IdRoom}, Status: {room.stringIsBooked()}");
                        }
                    
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        foreach (Room room in allRooms)
                        {
                            if (room.IsBooked == false) { Console.WriteLine($"Room number: {room.IdRoom}, Status: {room.stringIsBooked()}"); }
                        }
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();

                        break;

                }
            } while (menuUserChoice != 0);

            break;

        case 3: // Book Menu
            do
            {
                Console.Clear();

                Console.WriteLine($"{hotelName} > Book: \n");

                Console.WriteLine("(1) - Book a room");
                Console.WriteLine("(2) - Checkout a room");
                Console.WriteLine("(0) - Back");
                Console.Write("\nWhat do you want to do?: ");
                menuUserChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (menuUserChoice)
                {
                    case 0: break;
                    case 1:
                        Console.Write("Type the room number: ");
                        int bookRoomId = int.Parse(Console.ReadLine());
                        Console.Write("\nType the id of the guest that will book the room: ");
                        int bookRoomGuest = int.Parse(Console.ReadLine());

                        foreach(Room room in availableRooms)
                        {
                            if(room.IdRoom == bookRoomId)
                            {
                                room.bookRoom(bookRoomGuest);
                                Console.WriteLine($"\nRoom number {bookRoomId} was booked sucessfully!");
                            }
                        }
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Write("Type the room number: ");
                        int bookRoomIdCheckout = int.Parse(Console.ReadLine());
                        Console.Write("Confirm checkout (Y) = Yes, (N) No: ");
                        String confirmCheckout = Console.ReadLine();

                        if(confirmCheckout.Equals("Yes") ||
                           confirmCheckout.Equals("yes"))
                        {
                            foreach (Room room in availableRooms)
                            {
                                if (room.IdRoom == bookRoomIdCheckout)
                                {
                                    room.checkoutRoom();
                                    Console.WriteLine($"\nCheckout completed!");
                                }
                            }
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        }




                        break;

                }





            } while (menuUserChoice != 0);


         break;

    }



}while (userChoice != 0);
