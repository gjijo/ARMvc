using System;

namespace AlKhalidModels
{
    public class UserModel : ConnectorResponseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
