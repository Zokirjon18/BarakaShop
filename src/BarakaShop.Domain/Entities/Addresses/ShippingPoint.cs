using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Addresses;

public class ShippingPoint : Auditable
{
    public string Name { get; set; }
    public int AddressId { get; set; }
    public Address Address {  get; set; }
}

