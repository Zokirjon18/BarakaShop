using BarakaShop.Domain.Entities;
using BarakaShop.Domain.Entities.Addresses;
using BarakaShop.Domain.Entities.Categories;
using BarakaShop.Domain.Entities.Promocodes;
using BarakaShop.Domain.Entities.Stores;
using BarakaShop.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BarakaShop.DataAccess.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Address> Addresses { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<ShippingPoint> ShippingPoints { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<BasketItemProductAttribute> BasketItemProductAttributes { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<OrderStatus> OrderStatuses { get; set; }
        DbSet<OrderStatus> PaymentMethods { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductChildAttribute> ProductChildAttributes { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<ProductComment> ProductComments { get; set; }
        DbSet<ProductDetail> ProductDetails { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<ProductRootAttribute> ProductRootAttributes { get; set; }
        DbSet<ProductScore> ProductScores { get; set; }
        DbSet<PromoCode> PromoCodes { get; set; }
        DbSet<UserPromoCode> UserPromoCodes { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; }
        DbSet<UserFavouriteProduct> UserFavouriteProducts { get; set; }
    }
}
