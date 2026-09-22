namespace GymMembershipManagementSystem.Models
{
    public class PremiumMember : Member
    {
        public bool PersonalTrainerIncluded { get; set; }

        public PremiumMember(
            int memberId,
            string fullName,
            string phoneNumber,
            string email,
            string membershipType,
            bool personalTrainerIncluded)
            : base(
                memberId,
                fullName,
                phoneNumber,
                email,
                membershipType)
        {
            PersonalTrainerIncluded = personalTrainerIncluded;
        }

        public override string GetDetails()
        {
            string trainer = PersonalTrainerIncluded
                ? "Personal Trainer Included"
                : "No Personal Trainer";

            return $"{MemberId} - {FullName} - Premium - {trainer}";
        }
    }
}