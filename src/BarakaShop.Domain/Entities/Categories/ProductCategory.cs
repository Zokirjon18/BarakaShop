using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Categories;

public class ProductCategory : Auditable
{
    public string Name { get; set; }
    public string Icon { get; set; }
    public int RootCategoryId { get; set; }
    public ProductRootCategory RootCategory { get; set; }
}

