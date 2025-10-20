using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Addresses;

public class City : Auditable
{
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
}

