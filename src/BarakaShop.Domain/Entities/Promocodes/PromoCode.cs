using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Enums;

namespace BarakaShop.Domain.Entities.Promocodes;

public class PromoCode : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal MinOrderSum { get; set; }
    public PromoCodeType Type {  get; set; }
    public string Value { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int ActivationCountPerUser { get; set; }
}

