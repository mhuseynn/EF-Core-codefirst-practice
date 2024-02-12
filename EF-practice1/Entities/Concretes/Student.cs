using EF_practice1.Entities.Abstrsacts;
using EF_practice1.Enums;

namespace EF_practice1.Entities.Concretes;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? SchoolNumber { get; set; }

    public Gender? Gender { get; set; }


    public DateTime? Birthday { get; set; }

    public string? PhoneNumber { get; set; }


    public ICollection<Book>? Books { get; set; }


}
