namespace GymMembershipManagementSystem.Models
{
    public class Membership
    {
        public string MembershipType { get; set; }
        public decimal MonthlyFee { get; set; }
        public DateTime StartDate { get; set; }

        public Membership(
            string membershipType,
            decimal monthlyFee,
            DateTime startDate)
        {
            MembershipType = membershipType;
            MonthlyFee = monthlyFee;
            StartDate = startDate;
        }

        public bool IsActive()
        {
            return StartDate <= DateTime.Today;
        }

        public decimal GetAnnualFee()
        {
            return MonthlyFee * 12;
        }
    }
}