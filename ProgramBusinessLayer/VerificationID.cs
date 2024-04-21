using ProgramDataLayer;

namespace ProgramBusinessLayer
{
    public class VerificationID
    {
        public bool VerifyUserID(string UserID)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetAccount(UserID);

            return result.UserID != null ? true : false;
        }
        public bool VerifyPassword(string Password)
        {
            UserDataService PasswordService = new UserDataService();
            var result = PasswordService.GetPassword(Password);

            return result.Password != null ? true : false;
        }
    }
}

