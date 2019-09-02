using System;

namespace HomeOwnerBestie.Common
{
    public class Person
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class HOBAppUser : Person
    {
        public string ClientIPAddress { get; set; }
    }
}
