using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class BasketItemProductAttribute : Auditable
{
    public int BasketItemId { get; set; }
    public BasketItem BasketItem { get; set; }
    public string SelectedProductAttributeName { get; set; }
    public string SelectedProductAttributeValue { get; set; }
}

