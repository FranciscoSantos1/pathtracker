using System;

namespace PathTracker.Client.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string PositionTitle { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime? NextFollowUp { get; set; }
    }
}
