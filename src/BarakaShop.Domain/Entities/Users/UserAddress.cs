using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Addresses;

namespace BarakaShop.Domain.Entities.Users;

public class UserAddress : Auditable
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }
}

