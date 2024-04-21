using ProgramBusinessLayer;

namespace ProgramUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserID:");
            string UserID = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string Password = Console.ReadLine();

            VerificationID DataService = new VerificationID();
            bool result = DataService.VerifyUserID(UserID);

            VerificationID PasswordService = new VerificationID();
            bool result1 = PasswordService.VerifyPassword(Password);

            if (result1 && result)
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }

    }
}

