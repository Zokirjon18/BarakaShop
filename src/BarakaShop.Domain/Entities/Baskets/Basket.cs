using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Users;

namespace BarakaShop.Domain.Entities;

public class Basket : Auditable
{
    public string Name { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}

