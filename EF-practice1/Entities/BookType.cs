namespace EF_practice1.Entities;

public class BookType : BaseEntity
{
    public string? Name { get; set; }



    public ICollection<Book>? Books { get; set; }
}
