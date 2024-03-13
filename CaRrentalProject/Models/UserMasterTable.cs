using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class UserMasterTable
    {
        [Key]
        public int User_Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Contact_No { get; set; }
        public string? Email { get; set; }
        public int UserTypeID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
