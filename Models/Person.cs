namespace GymMembershipManagementSystem.Models
{
    public abstract class Person
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        protected Person(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public abstract string GetDetails();
    }
}