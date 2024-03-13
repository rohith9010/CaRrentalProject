using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class BookingTable
    {
        [Key]
        public int BookingID { get; set; }
        public string? Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string? S_address { get; set; }
        public string? D_address { get; set; }
        public string? Email_Id { get; set; }
        public string? Contact_No { get; set; }
        public int Car_Id { get; set; }
        public int Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Username { get; set; }
        public string? Carname { get; set; }
        public string? ModelName { get; set; }
        public string? BankName { get; set; }
        public string? Status { get; set; }
    }
}
