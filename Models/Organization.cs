using System;

namespace Andon.Backend.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
