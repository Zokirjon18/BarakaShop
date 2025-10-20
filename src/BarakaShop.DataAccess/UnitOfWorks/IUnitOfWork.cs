using BarakaShop.DataAccess.Repositories;
using BarakaShop.Domain.Entities;
using BarakaShop.Domain.Entities.Addresses;
using BarakaShop.Domain.Entities.Categories;
using BarakaShop.Domain.Entities.Payments;
using BarakaShop.Domain.Entities.Promocodes;
using BarakaShop.Domain.Entities.Stores;
using BarakaShop.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BarakaShop.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IRepository<Address> Addresses { get; }
        IRepository<City> Cities { get; }
        IRepository<Country> Countries { get; }
        IRepository<District> Districts { get; }
        IRepository<ShippingPoint> ShippingPoints { get; }
        IRepository<Basket> Baskets { get; }
        IRepository<BasketItem> BasketItems { get; }
        IRepository<BasketItemProductAttribute> BasketItemProductAttributes { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<OrderStatus> OrderStatuses { get; }
        IRepository<PaymentMethod> PaymentMethods { get; }
        IRepository<Product> Products { get; }
        IRepository<ProductChildAttribute> ProductChildAttributes { get; }
        IRepository<ProductCategory> ProductCategories { get; }
        IRepository<ProductComment> ProductComments { get; }
        IRepository<ProductDetail> ProductDetails { get; }
        IRepository<ProductImage> ProductImages { get; }
        IRepository<ProductRootAttribute> ProductRootAttributes { get; }
        IRepository<ProductScore> ProductScores { get; }
        IRepository<PromoCode> PromoCodes { get; }
        IRepository<UserPromoCode> UserPromoCodes { get; }
        IRepository<Store> Stores { get; }
        IRepository<User> Users { get; }
        IRepository<UserAddress> UserAddresses { get; }
        IRepository<UserFavouriteProduct> UserFavouriteProducts { get; }

        Task SaveAsync();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
