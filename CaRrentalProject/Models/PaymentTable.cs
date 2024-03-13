using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class PaymentTable
    {
        [Key]
        public int Payment_Id { get; set; }
        public int Car_ID { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int BankID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int BookingID { get; set; }
        [NotMapped]
        public string? Username { get; set; }
    }
}
