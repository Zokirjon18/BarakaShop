using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Users;

namespace BarakaShop.Domain.Entities.Promocodes;

public class UserPromoCode : Auditable
{
    public int UserId { get; set; }
    public User User { get; set; }  
    public int PromoCodeId { get; set; }
    public PromoCode PromoCode { get; set; }
    public int ActivationCount { get; set; }
}

