using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Addresses;

public class Country : Auditable
{
    public string Name { get; set; }
    public string Code { get; set; }
}

