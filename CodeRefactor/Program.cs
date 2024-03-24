
// Application inital Config Information

Console.Write("Type the hotel name: ");
string hotelName = Console.ReadLine();
Console.Write($"Type the numbers of rooms [{hotelName}] have: ");
int hotelNumberOfRooms = int.Parse(Console.ReadLine());
int idGuest = 0;


Room[] allRooms = new Room[hotelNumberOfRooms];
for (int i = 0; i < hotelNumberOfRooms; i++){
    allRooms[i] = new Room();
}

List<Room> availableRooms = new List<Room>(allRooms);
List<Guest> guestList = new List<Guest>();

int userChoice = 1;
int menuUserChoice = 0; // var that will be used inside the options menu. 

// Application Start...

Console.Write("\nInitialing...\n");
System.Threading.Thread.Sleep(500);
Console.Clear();


while (userChoice != 0)
{
    Console.WriteLine("Options: \n");

    Console.WriteLine("(1) - Guests");
    Console.WriteLine("(2) - Rooms");
    Console.WriteLine("(3) - Books");
    Console.WriteLine("(0) - Exit");

    Console.Write("\nType your option: ");
    userChoice = int.Parse(Console.ReadLine());

    

    switch (userChoice) {

        case 1:

            Console.Clear();

            Console.WriteLine("Options > Guests: \n");

            Console.WriteLine("(1) - Add new Guest");
            Console.WriteLine("(2) - Show all Guests");
            Console.WriteLine("(3) - Delete guest");

            Console.Write("\nWhat do you want to do?: ");
            menuUserChoice = int.Parse(Console.ReadLine());

            switch (menuUserChoice) 
            {  
                case 1:


                    break;
                case 2:

                    break;
            }

            break;
    
    
    }



}
