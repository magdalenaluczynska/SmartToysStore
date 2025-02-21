using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Interactive", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Puzzle", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Feeder", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Waterer", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Plush", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Travel", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Movers", DisplayOrder = 7 }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", StreetAddress = "123 Tech St", City = "Tech City", State = "IL", PostalCode = "12121", PhoneNumber = "1234567890"},
                new Company { Id = 2, Name = "Vivid Books", StreetAddress = "999 Vid St", City = "Vid City", State = "IL", PostalCode = "66666", PhoneNumber = "0987654321"},
                new Company { Id = 3, Name = "Readers Club", StreetAddress = "587 Main St", City = "Lala Land", State = "NY", PostalCode = "99999", PhoneNumber = "1112223334"}
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1, 
                    Name = "Duck with Soft Squeaker",
                    Description = "<p>This <strong>plush</strong> dog toy features a soft pink duck design with vibrant yellow beak and feet, making it an adorable and engaging playmate for your pet. <strong>Durable</strong> and <strong>lightweight</strong>, it&rsquo;s perfect for <strong>fetching</strong>, <strong>chewing</strong>, and <strong>cuddling</strong>, ensuring hours of fun for dogs of all sizes.</p>",
                    ModelCode = "B09BBP8FP3",
                    Price = 45.00,
                    Price50 = 44.00,
                    Price100 = 43.50,
                    Color = "Pink",
                    Link = "",
                    Image = "\\images\\product\\f8551ae3-8ccc-4f17-8b3f-8330ec9bda5e.jpg",
                    CategoryId = 5
                }, 
                new Product
                {
                    Id = 2, 
                    Name = "Treat Dispensing Dog Toy",
                    Description = "<p>The dog toy <strong>opens</strong> in the middle and fill the dog <strong>treat</strong> tray with your dog's favorite foods or treats, pop it in the freezer, Pop the frozen treats in the toy for <strong>delicious</strong>, <strong>large </strong>capacity 6 cavities silicone dog treat tray can be used for l<strong>ong-lasting</strong> dog play.</p>",
                    ModelCode = "B0CQR9741Z",
                    Price = 80,
                    Price50 = 79,
                    Price100 = 78,
                    Color = "Green",
                    Link = "",
                    Image = "\\images\\product\\6f8d1e45-0a58-46b5-9103-4a4cd8f333e4.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3, 
                    Name = "Interactive Rolling Ball For Dogs",
                    Description = "<p style=\"list-style-type: disc;\">Interactive Dog Ball Toy is made of <strong>durable</strong>, <strong>non-toxic </strong>nylon and does not contain&nbsp;BPA. However, please note that it is not <strong>suitable </strong>for <strong>aggressive chewers</strong></p>  <p style=\"list-style-type: disc;\"><strong>Waterproof </strong>rating of IP54, suitable for both <strong>indoor </strong>and <strong>outdoor </strong>use and play</p>",
                    ModelCode = "B0CFXSQSKH",
                    Price = 75,
                    Price50 = 72,
                    Price100 = 70,
                    Color = "Multicolor",
                    Link = "",
                    Image = "\\images\\product\\96564181-f9a3-484d-b11f-4ba4af827ac2.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4, 
                    Name = "Interactive Treat Puzzle For Dog",
                    Description = "<p style=\"list-style-type: disc;\"><strong>Advanced</strong> dog puzzle &ndash; an interactive <strong>challenge </strong>for <strong>smart </strong>dogs, this treat game is great for pets who have mastered easier puzzles.</p>",
                    ModelCode = "B0719Q89X8",
                    Price = 40,
                    Price50 = 39,
                    Price100 = 36,
                    Color = "Blue",
                    Link = "",
                    Image = "\\images\\product\\f5388d76-c917-47ea-abdb-02ccd5daabb7.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5, 
                    Name = "7L Dog and Cat Water Dispenser",
                    Description = "<p>The <strong>large </strong>water storage capacity allows owners to go out <strong>without worrying </strong>about their pets running out of water. <strong>Last </strong>about <strong>2-23 days </strong>for cat or dog use according to the pet's size.</p>",
                    ModelCode = "B0CJR8KM2Y",
                    Price = 120,
                    Price50 = 115,
                    Price100 = 110,
                    Color = "Black",
                    Link = "",
                    Image = "\\images\\product\\df552834-a21f-4736-a3c6-f0caa3a48fd4.jpg",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 6, 
                    Name = "Octopus Plush Toy For Dog",
                    Description = "<p>Fuufome plush dog toys features a reali<strong>stic cartoon design that will keep your dog interested and satisfies the dog&rsquo;s natural urge to chew.This large dog toys can accompany your dog for a fun tim</strong>e. Large dog plush toys length is 13.5 inch, perfect pet dog toys</p>",
                    ModelCode = "B0B1LVKG8D",
                    Price = 30,
                    Price50 = 28,
                    Price100 = 27,
                    Color = "Multicolor",
                    Link = "",
                    Image = "\\images\\product\\c61e0a9c-9618-44c3-853f-91de4103932b.jpg",
                    CategoryId = 5
                }
            );
        }
    }
};