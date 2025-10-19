using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities;

public class OrderStatus : Auditable
{
    public string Name { get; set; }
    public int Code { get; set; }
}

