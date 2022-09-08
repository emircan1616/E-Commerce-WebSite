using EvKur.Models.Comment;
using EvKur.Models.Factory;
using EvKur.Models.Shop;
using EvKur.Models.ShopCart;
using EvKur.Models.SignIn;
using EvKur.Models.User;
using Microsoft.EntityFrameworkCore;

namespace EvKur.Models.Entity
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            
        }
       

        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Bayii> bayiis { get; set; }
        public DbSet<Company>companies { get; set; }
        public DbSet<Tedarikci> tedarikcis { get; set; }        
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        
        public DbSet<Login> logins { get; set; }
        public DbSet<Register> registers { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Shipping> shippings { get; set; }
        public DbSet<CustomerComment> customerComments { get; set; }
        public DbSet<BayiProduct> bayiProducts { get; set; }
        public DbSet<BayiSiparis> bayiSiparis { get; set; }
        public DbSet<ProductOrder> productOrders { get; set; }
        public DbSet<AddProduct> addProducts { get; set; }
        public DbSet<Sepet> sepet { get; set; }
        public DbSet<ShoppingCart> Shoppingcarts { get; set; }
        public DbSet<Class> Class { get; set; }
    }
}
