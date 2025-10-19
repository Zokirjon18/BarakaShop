using System.ComponentModel.DataAnnotations.Schema;
using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Entities.Addresses;
using BarakaShop.Domain.Entities.Payments;
using BarakaShop.Domain.Entities.Promocodes;
using BarakaShop.Domain.Entities.Users;
using BarakaShop.Domain.Enums;

namespace BarakaShop.Domain.Entities;

public class Order : Auditable
{
    public string Number { get; set; }
    public OrderType Type { get; set; }
    public decimal TotalProductsPrice { get; set; }
    public decimal DeliveryFee { get; set; }
    public decimal Discount { get; set; }
    public decimal SumTotal { get; set; }

    [NotMapped]
    public decimal SavingSum { get; set; }

    public int StatusId { get; set; }
    public OrderStatus Status { get; set; }

    public int ShippingPointId { get; set; }
    public ShippingPoint ShippingPoint { get; set; }
   
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    
    public int UserPromoCodeId { get; set; }
    public UserPromoCode UserPromoCode { get; set; }
   
    public int AddressId { get; set; }
    public Address Address { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }

}

