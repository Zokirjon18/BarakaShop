using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductDetail : Auditable
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}

