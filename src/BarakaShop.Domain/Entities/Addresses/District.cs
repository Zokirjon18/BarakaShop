using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Addresses;

public class District : Auditable
{
    public string Name { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
}

