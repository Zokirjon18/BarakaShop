using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Users;

public class UserFavouriteProduct : Auditable
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}

