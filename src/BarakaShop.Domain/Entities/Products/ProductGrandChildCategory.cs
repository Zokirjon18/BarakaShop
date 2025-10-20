using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductGrandChildCategory : Auditable
{
    public string Name { get; set; }
    public int ChildCategoryId { get; set; }
    public ProductChildCategory ChildCategory { get; set; }
}

