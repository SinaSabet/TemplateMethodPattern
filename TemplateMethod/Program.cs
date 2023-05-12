



Client.Signup(new SignUpGoldUser());// this can be normal user


public abstract class SignUp
{

    public void RunMethods()
    {
        Console.WriteLine("Template Method Run .........");
        CreateUser();
        SendEmail();
        SendSms();
    }
    public abstract void CreateUser();
    public abstract void SendEmail();
    public abstract void SendSms();
}


public class SignUpGoldUser : SignUp
{
    public override void CreateUser()
    {
        Console.WriteLine("User Created (GoldUser)");
    }

    public override void SendEmail()
    {
        Console.WriteLine("Email Send (GoldUser)");
    }

    public override void SendSms()
    {
        Console.WriteLine("Sms Send (GoldUser)");
    }
}



public class SignUpNormalUser : SignUp
{
    public override void CreateUser()
    {
        Console.WriteLine("User Created (NormalUser)");
    }

    public override void SendEmail()
    {
        Console.WriteLine("Email Send (NormalUser)");
    }

    public override void SendSms()
    {
        Console.WriteLine("Sms Send (NormalUser)");
    }
}


public static class Client
{
    public static void Signup(SignUp signUp)
    {
        signUp.RunMethods();
    }
}