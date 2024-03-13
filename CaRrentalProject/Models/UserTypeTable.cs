using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class UserTypeTable
    {
        [Key]
        public int UserTypeID { get; set; }
        public string?   UserTypeName { get; set; }
    }
}
