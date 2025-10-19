using BarakaShop.Domain.Commons;
using BarakaShop.Domain.Enums;

namespace BarakaShop.Domain.Entities.Users;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
}

