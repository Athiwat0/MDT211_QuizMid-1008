using System;
public class ReserveSeats{


    public void ShowSeat(){
        Console.Clear();
        Console.WriteLine("ReserveSeats");
        Console.WriteLine("====================================================");
        Console.WriteLine("Seats A : A1 A2 A3 A4 A5 A6 A7 A8 A9 A10");
        Console.WriteLine("Seats B : B1 B2 B3 B4 B5 B6 B7 B8 B9 B10");
        Console.WriteLine("====================================================");
        Console.WriteLine("Seat price");
        Console.WriteLine("Guest price : 5,235.25 Bath");
        Console.WriteLine("Guest Student : 1,200.50 Bath");
        Console.WriteLine("====================================================");
    }

    public static void InputSeatFromKeyboard() 
    {
       
        Console.Write("Please input Seat : ");
        string Seat = Console.ReadLine();
       
        Console.Write("Seat of your choice : {0}", Seat);
        Console.ReadKey();


   
    }
    

   
}