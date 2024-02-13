using EF_practice1.Enums;

namespace EF_practice1.Entities;

public class BaseEntity
{

    public int? Id { get; set; }

    public DataStatus? Status { get; set; }


    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

}
