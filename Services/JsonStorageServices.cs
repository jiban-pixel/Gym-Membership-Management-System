using GymMembershipManagementSystem.Models;
using System.Text.Json;

namespace GymMembershipManagementSystem.Services
{
    public class JsonStorageService
    {
        private readonly string filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "members.json");

        public void SaveMembers(IReadOnlyList<Member> members)
        {
            string json = JsonSerializer.Serialize(
                members,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);
        }

        public List<Member> LoadMembers()
        {
            if (!File.Exists(filePath))
            {
                return new List<Member>();
            }

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<Member>>(json)
                   ?? new List<Member>();
        }
    }
}