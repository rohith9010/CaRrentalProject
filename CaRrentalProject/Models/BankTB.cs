using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{

    public class BankTB
    {
        [Key]
        public int BankID { get; set; }
        public string? BankName { get; set; }
    }
        
}
