using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{

    public class BankTable
    {
        [Key]
        public int BankID { get; set; }
        public string? BankName { get; set; }
    }
        
}
