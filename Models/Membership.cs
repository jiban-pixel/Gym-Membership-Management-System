namespace GymMembershipManagementSystem.Models
{
    public class Membership
    {
        public string MembershipType { get; set; }
        public decimal MonthlyFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PaymentStatus { get; set; } = "Outstanding";

        public Membership(
            string membershipType,
            decimal monthlyFee,
            DateTime startDate)
        {
            MembershipType = membershipType;
            MonthlyFee = monthlyFee;
            StartDate = startDate;

            // Membership is valid for 1 year
            ExpiryDate = startDate.AddYears(1);

            PaymentStatus = "Outstanding";
        }

        public bool IsActive()
        {
            return StartDate <= DateTime.Today &&
                   DateTime.Today <= ExpiryDate;
        }

        public bool IsExpired()
        {
            return DateTime.Today > ExpiryDate;
        }
        public bool IsAboutToExpire()
        {
            return !IsExpired() &&
                   ExpiryDate <= DateTime.Today.AddDays(30);
        }
        public decimal GetAnnualFee()
        {
            return MonthlyFee * 12;
        }
    }
}