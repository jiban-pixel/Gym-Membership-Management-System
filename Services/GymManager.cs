using GymMembershipManagementSystem.Models;

namespace GymMembershipManagementSystem.Services
{
    public class GymManager
    {
        private readonly List<Member> members = new List<Member>();

        public IReadOnlyList<Member> Members => members.AsReadOnly();

        public void AddMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            if (members.Any(m => m.MemberId == member.MemberId))
            {
                throw new InvalidOperationException(
                    "A member with this ID already exists.");
            }

            if (string.IsNullOrWhiteSpace(member.FullName))
            {
                throw new ArgumentException(
                    "Member name cannot be empty.");
            }

            members.Add(member);
        }

        public Member FindMemberById(int memberId)
        {
            return members.FirstOrDefault(
                m => m.MemberId == memberId);
        }

        public bool RemoveMember(int memberId)
        {
            Member member = FindMemberById(memberId);

            if (member == null)
            {
                return false;
            }

            members.Remove(member);
            return true;
        }

        public int GetMemberCount()
        {
            return members.Count;
        }
    }
}