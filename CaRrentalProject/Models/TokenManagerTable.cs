using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class TokenManagerTable
    {
        [Key]
        public int TokenID { get; set; }
        public string? TokenKey { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserID { get; set; }
    }
}
