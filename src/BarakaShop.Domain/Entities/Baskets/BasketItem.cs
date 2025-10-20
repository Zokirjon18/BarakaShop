using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class BasketItem : Auditable
{
    public int BastketId { get; set; }
    public Basket Bastket { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public double Count { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}

