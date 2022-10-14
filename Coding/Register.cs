public class Register{
    static int Menu = 0;

    public void PrintMenuRegister(){
        Console.Clear();
        Console.WriteLine("Menu Register");
        Console.WriteLine("====================================================");
        Console.WriteLine("Are you a guest or a student ?");
        Console.WriteLine("1. Guest");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Back to Menu");
        Console.WriteLine("====================================================");
    }

    public static void InputRegister(){
        InputMenuRegisterFromKeyboard();
        if (Menu == 1 ){
          RegisterGuest();
        }

        else if(Menu == 2){
            RegisterStudent();
            
        }
        else if(Menu == 3){
            Console.WriteLine("Enter to Back Menu");
            return;
            
        }


    }

    static void RegisterGuest() 
    {
        Console.Clear();
        Console.WriteLine("Register for the event (Guest)");

       // Console.Write("Input name prefix : ");
      //  string nameprefix = Console.ReadLine();
        static string GetPrefix(){
           Console.WriteLine("====================================================");
           Console.WriteLine("1 = Mr.");
           Console.WriteLine("2 = Ms.");
           Console.WriteLine("3 = Mrs.");
           Console.Write("pls select your Prefix :");
           int input = int.Parse(Console.ReadLine());
           if(input == 1) {
            return "Mr";
            }
           else if (input == 2){
            return "Ms";
           }
           else if (input == 3){
            return "Mrs";
           }
            else {
            return GetPrefix();
          }

        }

        GetPrefix();


        Console.Write("Input name : ");
        string name = Console.ReadLine();
        Console.Write("Input surname : ");
        string surname = Console.ReadLine();
        Console.Write("Input age : ");
        string age = Console.ReadLine();
        Console.Write("Input email : ");
        string email = Console.ReadLine();
        Console.Write("Input password : ");
        int password = int.Parse(Console.ReadLine());
        Console.Write("Input confirm password : ");
        int confirmpassword = int.Parse(Console.ReadLine());

        if(password != confirmpassword){
            Console.WriteLine("====================================================");
            Console.WriteLine("Invalid email. Please try again.");
            Console.ReadKey();

            BackToRegisterMenu();
        }
    
        Console.Clear();
        Console.WriteLine("Your information");
        Console.WriteLine("====================================================");
        Console.WriteLine("Name : {0}{1} {2}",GetPrefix,name,surname);
        Console.WriteLine("Age : {0}",age);
        Console.WriteLine("Email : {0}",email);
        Console.WriteLine("====================================================");

        return;

    }

    static void RegisterStudent() 
    {
        Console.Clear();
        Console.WriteLine("Register for the event (Student)");
        Console.Write("Input name prefix : ");
        string nameprefix = Console.ReadLine();
        Console.Write("Input name : ");
        string name = Console.ReadLine();
        Console.Write("Input surname : ");
        string surname = Console.ReadLine();
        Console.Write("Input age : ");
        string age = Console.ReadLine();
        Console.Write("Input email : ");
        string email = Console.ReadLine();
        Console.Write("Input student ID : ");
        string studentID = Console.ReadLine();
        Console.Write("Input password : ");
        int password = int.Parse(Console.ReadLine());
        Console.Write("Input confirm password : ");
        int confirmpassword = int.Parse(Console.ReadLine());

        if(password != confirmpassword){
            Console.WriteLine("====================================================");
            Console.WriteLine("Invalid email. Please try again.");
            Console.ReadKey();

            BackToRegisterMenu();
        }

        Console.Clear();
        Console.WriteLine("Your information");
        Console.WriteLine("====================================================");
        Console.WriteLine("Name : {0} {1} {2}",nameprefix,name,surname);
        Console.WriteLine("Age : {0}",age);
        Console.WriteLine("Email : {0}",email);
        Console.WriteLine("Student ID : {0}",studentID);
        Console.WriteLine("====================================================");
       
        return;
                 
    }


   static void InputMenuRegisterFromKeyboard() 
    {
        Console.Write("Please input Menu : ");
         Menu = int.Parse(Console.ReadLine());
    }

    static void BackToRegisterMenu() {
        Console.Clear();
        Register reg = new Register();
        reg.PrintMenuRegister();
        InputRegister();
    }

    
}