public class SignIn{
    private string email;
    private int password;


    public SignIn(string email , int password) {
        this.email = email;
        this.password = password;
    }

    public string GetEmail() {
        return this.email;
    }

    public int GetPassWord() {
        return this.password;
    }

    public static string InputEmail() {
        
        Console.WriteLine("====================================================");
        Console.Write("Input Email : ");

        return Console.ReadLine();
    }
     public static string InputPassWord() {
    
        Console.Write("Input PassWord : ");
       
        return Console.ReadLine();
    }
    



}