using System;
using System.Collections.Generic;

static void main (String[] args)
{

    // Application inital Config Information

    Console.Write("Type the hotel name: ");
    string hotelName = Console.ReadLine();
    Console.Write($"Type the numbers of room [{hotelName} have]");
    int hotelNumberOfRooms = int.Parse(Console.ReadLine());
    int idGuest = 0;

    Room[] allRooms = new Room[hotelNumberOfRooms];
    for (int i = 0; i < hotelNumberOfRooms; i++)
    {
        allRooms[i] = new Room();
    }

    

}

 