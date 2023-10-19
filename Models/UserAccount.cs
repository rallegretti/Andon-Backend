using System;

namespace Andon.Backend.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? PwChangeToken {  get; set; } = string.Empty;
        public DateTime? TokenExpires { get; set; }
        public DateTime LastPwChange {  get; set; }
        public bool Active { get; set; }
        public int OrgId { get; set; }
        public int PoolId { get; set; }
        public int? ShiftId { get; set; }
    }
}
