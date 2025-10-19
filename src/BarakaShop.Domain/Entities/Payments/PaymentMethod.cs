using BarakaShop.Domain.Commons;

namespace BarakaShop.Domain.Entities.Payments;

public class PaymentMethod : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}

