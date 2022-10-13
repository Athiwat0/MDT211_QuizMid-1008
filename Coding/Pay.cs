public class Pay{
    static int InputChoosePayment = 0;
    public void ChoosePayment (){
        Console.WriteLine("Choose a Payment");
        Console.WriteLine("====================================================");
        Console.WriteLine("1. Bank payment");
        Console.WriteLine("2. Credit card payment");
        Console.WriteLine("3. Cancel reservation");
        Console.WriteLine("====================================================");
    }

    public static void PrintInputChoosePayment() {
    InputChoosePaymentFromKeyboard();
     

       if (InputChoosePayment == 1 ){
        Console.Clear();
        Console.Write("Input bank account name : ");
        string bankname = Console.ReadLine();
        Console.Write("Input bank account number : ");
        int banknumber = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("ReserveSeats");
        Console.WriteLine("====================================================");
        Console.WriteLine("Seats A : A1 A2 A3 A4 A5 A6 A7 A8 A9 A10");
        Console.WriteLine("Seats B : B1 B2 B3 B4 B5 B6 B7 B8 B9 B10");
        Console.WriteLine("====================================================");
        Console.WriteLine("Your information");
        Console.WriteLine("Bank account name :{0}",bankname);
        Console.WriteLine("Bank account number :{0}",banknumber); 

       }
        else if(InputChoosePayment == 2){
            Console.Clear();
            Console.Write("Input credit card name : ");
            string creditname = Console.ReadLine();
            Console.Write("Input card number : ");
            int cardnumber = int.Parse(Console.ReadLine()); 
            Console.Write("Input expiration date : ");
            string expirationdate = Console.ReadLine();
            Console.Write("Input CVV number : ");
            string cvvnumber = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("ReserveSeats");
            Console.WriteLine("====================================================");
            Console.WriteLine("Seats A : A1 A2 A3 A4 A5 A6 A7 A8 A9 A10");
            Console.WriteLine("Seats B : B1 B2 B3 B4 B5 B6 B7 B8 B9 B10");
            Console.WriteLine("====================================================");
            Console.WriteLine("Your information");
            Console.WriteLine("Credit card name :{0}",creditname);
            Console.WriteLine("Card number :{0}",cardnumber);
            Console.WriteLine("expiration date :{0}",expirationdate); 
            Console.WriteLine("CVV number :{0}",cvvnumber); 


        }
         else if(InputChoosePayment == 3){
            Console.Write("please try again (Enter > back to the menu)");

            return;
        }
    }
    static void InputChoosePaymentFromKeyboard() 
    {
        Console.Write("Please input Choose a Payment : ");
         InputChoosePayment = int.Parse(Console.ReadLine());
    }

}