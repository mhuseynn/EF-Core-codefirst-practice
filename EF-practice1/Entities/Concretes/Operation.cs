using EF_practice1.Entities.Abstrsacts;

namespace EF_practice1.Entities.Concretes;

public class Operation : BaseEntity
{
    public DateTime? StartedDate { get; set; }

    public DateTime? EndDate { get; set; }
}
