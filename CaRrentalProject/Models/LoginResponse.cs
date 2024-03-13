namespace CaRrentalProject.Models
{
    public class LoginResponse
    {
        public string? Username { get; set; }
        public string? Token { get; set; }
        public int UserTypeID { get; set; }
    }
}
