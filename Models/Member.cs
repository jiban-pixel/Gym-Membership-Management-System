namespace GymMembershipManagementSystem.Models
{
    public class Member : Person
    {
        public int MemberId { get; set; }
        public string Email { get; set; }
        public string MembershipType { get; set; }
        public Membership Membership { get; set; }

        public Member(
            int memberId,
            string fullName,
            string phoneNumber,
            string email,
            string membershipType)
            : base(fullName, phoneNumber)
        {
            MemberId = memberId;
            Email = email;
            MembershipType = membershipType;

            decimal fee = membershipType switch
            {
                "Basic" => 30m,
                "Standard" => 45m,
                "Premium" => 60m,
                _ => 0m
            };

            Membership = new Membership(
                membershipType,
                fee,
                DateTime.Today);
        }

        public override string GetDetails()
        {
            return $"{MemberId} - {FullName} - {MembershipType} - ${Membership.MonthlyFee:F2}/month";
        }
    }
}