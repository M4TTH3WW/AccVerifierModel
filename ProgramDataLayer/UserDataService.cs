using AccVerifierModel;

namespace ProgramDataLayer
{
    public class UserDataService
    {
        List<ModelService> dummyAcc = new List<ModelService>();

        public UserDataService()
        {
            CreateDummyAccount();
        }

        private void CreateDummyAccount()
        {
            ModelService dummy1 = new ModelService
            {
                UserID = "pascua",
                Password = "pogilang"
            };
            ModelService dummy2 = new ModelService
            {
                UserID = "matthew",
                Password = "sakalam"
            };
            ModelService dummy3 = new ModelService
            {
                UserID = "hicrush",
                Password = "imissyou123"
            };
            ModelService dummy4 = new ModelService
            {
                UserID = "nonchalant",
                Password = "salam"
            };

            dummyAcc.Add(dummy1);
            dummyAcc.Add(dummy2);
            dummyAcc.Add(dummy3);
            dummyAcc.Add(dummy4);
        }
        public ModelService GetAccount(string UserID)
        {
            ModelService FoundAccount = new ModelService();

            foreach (var dummy in dummyAcc)
            {
                if (UserID == dummy.UserID)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
        public ModelService GetPassword(string Password)
        {
            ModelService FoundAccount = new ModelService();

            foreach (var dummy in dummyAcc)
            {
                if (Password == dummy.Password)
                {
                    FoundAccount = dummy;
                }

            }

            return FoundAccount;

        }
    }
}
