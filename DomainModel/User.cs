namespace DomainModel;

public class User
{
    private string userName;
    private string password;
    private string email;
    
    public void login() {
        Console.WriteLine("Enter username:");
        string enteredUsername = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string enteredPassword = Console.ReadLine();

        // Check if entered username and password match the stored values
        if (enteredUsername == userName && enteredPassword == password)
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed. Incorrect username or password.");
        }
        
    }

    public void logout() {
        {
        Console.WriteLine("User logged out.");
        }
    }

}


