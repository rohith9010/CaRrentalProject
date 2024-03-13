using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CaRrentalProject.Models
{
    public class CarTable
    {
        [Key]
        public int Car_Id { get; set; }
        public string? Model_Name { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public int No_of_Pas { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? Fueltype { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Username { get; set; }
    }
}
