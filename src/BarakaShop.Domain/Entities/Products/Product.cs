namespace BarakaShop.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public ProductGrandChildCategory Category { get; set; }
}

