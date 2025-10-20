using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductChildCategory : Auditable
{
    public string Name { get; set; }
    public int RootCategoryId { get; set; }
    public ProductRootCategory RootCategory { get; set; }
}

