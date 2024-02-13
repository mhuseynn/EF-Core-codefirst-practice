namespace EF_practice1.Entities;

public class Author : BaseEntity
{

    public string? FirstName { get; set; }

    public string? LastName { get; set; }


    public ICollection<Book>? Books { get; set; }
}
