using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Stores;
using BarakaShop.Domain.Entities.Users;

namespace BarakaShop.Domain.Entities;

public class ProductComment : Auditable
{
    public string Content { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int StoreId { get; set; }
    public Store Store { get; set; }
}

