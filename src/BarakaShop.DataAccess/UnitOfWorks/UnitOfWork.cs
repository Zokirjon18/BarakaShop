using BarakaShop.DataAccess.Contexts;
using BarakaShop.DataAccess.Repositories;
using BarakaShop.Domain.Entities;
using BarakaShop.Domain.Entities.Addresses;
using BarakaShop.Domain.Entities.Payments;
using BarakaShop.Domain.Entities.Promocodes;
using BarakaShop.Domain.Entities.Stores;
using BarakaShop.Domain.Entities.Users;

namespace BarakaShop.DataAccess.UnitOfWorks
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork, IDisposable
    {
        public IRepository<Address> Addresses { get; } = new Repository<Address>(context);

        public IRepository<City> Cities { get; } = new Repository<City>(context);

        public IRepository<Country> Countries { get; } = new Repository<Country>(context);

        public IRepository<District> Districts { get; } = new Repository<District>(context);
        public IRepository<ShippingPoint> ShippingPoints { get; } = new Repository<ShippingPoint>(context);

        public IRepository<Basket> Baskets { get; } = new Repository<Basket>(context);

        public IRepository<BasketItem> BasketItems { get; } = new Repository<BasketItem>(context);

        public IRepository<BasketItemProductAttribute> BasketItemProductAttributes { get; } = new Repository<BasketItemProductAttribute>(context);

        public IRepository<Order> Orders { get; } = new Repository<Order>(context);

        public IRepository<OrderItem> OrderItems { get; } = new Repository<OrderItem>(context);

        public IRepository<OrderStatus> OrderStatuses { get; } = new Repository<OrderStatus>(context);

        public IRepository<PaymentMethod> PaymentMethods { get; } = new Repository<PaymentMethod>(context);

        public IRepository<Product> Products { get; } = new Repository<Product>(context);

        public IRepository<ProductChildAttribute> ProductChildAttributes { get; } = new Repository<ProductChildAttribute>(context);

        public IRepository<ProductChildCategory> ProductChildCategories { get; } = new Repository<ProductChildCategory>(context);

        public IRepository<ProductComment> ProductComments { get; } = new Repository<ProductComment>(context);

        public IRepository<ProductDetail> ProductDetails { get; } = new Repository<ProductDetail>(context);

        public IRepository<ProductGrandChildCategory> ProductGrandChildCategories { get; } = new Repository<ProductGrandChildCategory>(context);

        public IRepository<ProductImage> ProductImages { get; } = new Repository<ProductImage>(context);

        public IRepository<ProductRootAttribute> ProductRootAttributes { get; } = new Repository<ProductRootAttribute>(context);

        public IRepository<ProductRootCategory> ProductRootCategories { get; } = new Repository<ProductRootCategory>(context);

        public IRepository<ProductScore> ProductScores { get; } = new Repository<ProductScore>(context);

        public IRepository<PromoCode> PromoCodes { get; } = new Repository<PromoCode>(context);

        public IRepository<UserPromoCode> UserPromoCodes { get; } = new Repository<UserPromoCode>(context);

        public IRepository<Store> Stores { get; } = new Repository<Store>(context);

        public IRepository<User> Users { get; } = new Repository<User>(context);
      
        public IRepository<UserAddress> UserAddresses { get; } = new Repository<UserAddress>(context);
        
        public IRepository<UserFavouriteProduct> UserFavouriteProducts { get; } = new Repository<UserFavouriteProduct>(context);


        public async Task BeginTransactionAsync()
        {
            await context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await context.Database.CommitTransactionAsync();
        }

        public async Task RollbackAsync()
        {
            await context.Database.RollbackTransactionAsync();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
