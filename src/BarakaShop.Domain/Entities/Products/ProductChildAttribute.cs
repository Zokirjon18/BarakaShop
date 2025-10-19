using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductChildAttribute : Auditable
{
    public string Name { get; set; }
    public string Value { get; set; }
    public decimal AdditionalPrice { get; set; }
    public int RootAttributeId { get; set; }
    public ProductRootAttribute RootAttribute { get; set; }
}

