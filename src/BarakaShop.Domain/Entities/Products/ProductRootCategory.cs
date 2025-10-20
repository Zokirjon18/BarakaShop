using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class ProductRootCategory : Auditable
{
    public string Name { get; set; }
    public string Icon { get; set; }
}

