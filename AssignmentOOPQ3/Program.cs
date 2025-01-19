using System;




interface IAuthenticationService
{
    bool AuthenticateUser(string username, string password);
    bool AuthorizeUser(string username, string role);
}
class BasicAuthenticationService : IAuthenticationService
{
    public bool AuthenticateUser(string username, string password)
    {
        return username == "yara" && password == "12345";
    }
    public bool AuthorizeUser(string username, string role)
    {
        return username == "yara" && role == "Admin";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAuthenticationService authService = new BasicAuthenticationService();

        if (authService.AuthenticateUser("yara", "12345"))
        {
            Console.WriteLine("Authentication Successful!");
            if (authService.AuthorizeUser("yara", "Admin"))
                Console.WriteLine("Authorization Successful!");
            else
                Console.WriteLine("Authorization Failed!");
        }
        else
        {
            Console.WriteLine("Authentication Successful!");
        }
    }
}
//result: Authentication Successful!
//Authorization Successful!


