using CaRrentalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CaRrentalProject.DBContextmodel
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base()
        {
        }
        public DbSet<UserMasterTable> UserMasterTB { get; set; }
        public DbSet<CarTable> CarTB { get; set; }
        public DbSet<BookingTable> BookingTB { get; set; }
        public DbSet<PaymentTable> PaymentTB { get; set; }
        public DbSet<BankTable> BankTB { get; set; }
        public DbSet<TokenManagerTable> TokenManager { get; set; }
        public DbSet<UserTypeTable> UserType { get; set; }
    }
}
