using System;
class Program {
    static int Menu = 0;
    static int MenuLogin = 0;
    static void Main(string[] args) {
        PrintMenu();
        PrintInputMenu();
        //Console.Clear();
        BackToMainMenu();
    }
static void PrintMenu() {
        Console.WriteLine("Welcome to Metaverse concert ");
        Console.WriteLine("====================================================");
        Console.WriteLine("1. Register for the event");
        Console.WriteLine("2. Sign in");
        Console.WriteLine("====================================================");
    }
static void PrintInputMenu() {
    InputMenuFromKeyboard();

    if (Menu == 1 ){
        
        Register reg = new Register();
        reg.PrintMenuRegister();
        Register.InputRegister();
        Console.ReadKey();


        BackToMainMenu();
    }
        else if(Menu == 2){

            Console.Clear();
            SignIn.InputEmail();
            SignIn.InputPassWord();
           

            BackToMainMenuLogin();
        }

    static void InputMenuFromKeyboard() 
    {
        Console.Write("Please input Menu : ");
        Menu = int.Parse(Console.ReadLine());
    }
}

static void BackToMainMenu() {
        Console.Clear();
        PrintMenu();
        PrintInputMenu();
    }


static void PrintMenuLogin() {
       
        Console.WriteLine("Welcome to Metaverse concert ");
        Console.WriteLine("Sign in successfully");
        Console.WriteLine("====================================================");
        Console.WriteLine("1. ReserveSeats");
        Console.WriteLine("2. Sign out");
        Console.WriteLine("====================================================");
    }
static void InputMenuLoginFromKeyboard() 
    {
        Console.Write("Please input Menu : ");
         MenuLogin = int.Parse(Console.ReadLine());
    }

static void BackToMainMenuLogin() {
        Console.Clear();
        PrintMenuLogin();
        InputMenuLoginFromKeyboard();

        
    if (MenuLogin == 1 ){
        
        ReserveSeats reserveseats = new ReserveSeats();
        reserveseats.ShowSeat();
        ReserveSeats.InputSeatFromKeyboard();

        Console.Clear();
        Pay pay = new Pay();
        pay.ChoosePayment();
        Pay.PrintInputChoosePayment();
        Console.ReadKey();

    }
    else if(MenuLogin == 2){

            BackToMainMenu();
        } 
            
    }


}