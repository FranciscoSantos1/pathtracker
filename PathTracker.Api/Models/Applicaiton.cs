using System.ComponentModel.DataAnnotations.Schema;

namespace PathTracker.Api.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string PositionTitle { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        public DateTime DateApplied { get; set; }
        public string Status { get; set; } = "Applied"; // Applied, Interview, Offer, Rejected
        public string? Notes { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NextFollowUp { get; set; } // Nullable
    }
}