using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Addresses;

public class Address : Auditable
{
    public int CountyId { get; set; }
    public Country Country { get; set; }

    public int CityId { get; set; }
    public City City { get; set; }

    public int DistrictId { get; set; }
    public District District { get; set; }

    public string Street { get; set; }
    public string Home { get; set; }
}

