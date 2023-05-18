using System.Security.Principal;

namespace OkitechWebApp.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public  string? Password { get; set; }
        public string? confirmPassword { get; set; }
        public string? Phone { get; set; }
        public string?[] Qualification { get; } = new string[7];
        public string?[] Department { get; } = new string[3];
        public string?[] Intended_Duration { get; } = new string[8];
        public string?[] Experience { get; } = new string[4];
        public string?[] English_Fluency { get; } = new string[4];
        public long National_Identity_Number { get; set; }
    }
}
