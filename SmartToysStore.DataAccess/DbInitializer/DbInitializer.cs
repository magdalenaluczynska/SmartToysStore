using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartToysStore.DataAccess.Data;
using SmartToysStore.Models;
using SmartToysStore.Utility;

namespace SmartToysStore.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        
        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
                
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "admin@smarttoysstore.com",
                    Email = "admin@smarttoysstore.com",
                    Name = "Jan Kowalski",
                    PhoneNumber = "123456789",
                    StreetAddress = "123 Main St",
                    State = "NY",
                    PostalCode = "23422",
                    City = "New York"

                }, "Admin123!").GetAwaiter().GetResult();
                
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "jakub@smarttoysstore.com",
                    Email = "jakub@smarttoysstore.com",
                    Name = "Jakub Kowalski",
                    PhoneNumber = "111333222",
                    StreetAddress = "321 Main St",
                    State = "NY",
                    PostalCode = "23422",
                    City = "New York"

                }, "Haslo123!").GetAwaiter().GetResult();
                
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "john@readersclub.com",
                    Email = "john@readersclub.com",
                    Name = "John Smith",
                    PhoneNumber = "222333111",
                    StreetAddress = "321 Main St",
                    State = "NY",
                    PostalCode = "23422",
                    City = "New York",
                    Company = _db.Companies.FirstOrDefault(c => c.Name == "Readers Club")

                }, "Haslo123!").GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "julia@gmail.com",
                    Email = "julia@gmail.com",
                    Name = "Julia Kowalska",
                    PhoneNumber = "123123123",
                    StreetAddress = "213 Main St",
                    State = "NY",
                    PostalCode = "23422",
                    City = "New York"

                }, "Haslo123!").GetAwaiter().GetResult();


                ApplicationUser adminUser = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@smarttoysstore.com");
                ApplicationUser employeeUser = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "jakub@smarttoysstore.com");
                ApplicationUser companyUser = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "john@readersclub.com");
                ApplicationUser customerUser = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "julia@gmail.com");
                
                _userManager.AddToRoleAsync(adminUser, SD.Role_Admin).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(employeeUser, SD.Role_Employee).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(companyUser, SD.Role_Company).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(customerUser, SD.Role_Customer).GetAwaiter().GetResult();
            }

            return;
        }
    }
}
