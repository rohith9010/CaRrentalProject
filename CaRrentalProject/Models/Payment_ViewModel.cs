namespace CaRrentalProject.Models
{
    public class Payment_ViewModel
    {
        public int Payment_Id { get; set; }
        public int Amount { get; set; }
        public int BankID { get; set; }
        public string? BankName { get; set; }
        public string? Carname { get; set; }
        public int UserID { get; set; }
        public int BookingID { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
