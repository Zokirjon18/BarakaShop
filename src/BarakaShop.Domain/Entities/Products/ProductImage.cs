using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductImage : Auditable
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public string Path { get; set; } // filename filepath ga alohida entity ochishni oylab ko'r
}

