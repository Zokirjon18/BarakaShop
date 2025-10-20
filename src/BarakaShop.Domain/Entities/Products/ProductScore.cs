using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Users;
using BarakaShop.Domain.Enums;

namespace BarakaShop.Domain.Entities;

public class ProductScore : Auditable
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int Id { get; set; }
    public ProductGrade Grade { get; set; }
}

