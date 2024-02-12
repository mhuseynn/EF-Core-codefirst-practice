using EF_practice1.Entities.Abstrsacts;

namespace EF_practice1.Entities.Concretes;

public class Book : BaseEntity
{
    public string? Name { get; set; }

    public int?  PageCount { get; set; }


    public int? AuthorId { get; set; }

    public int? BookTypeId { get; set; }


    public ICollection<Student>? Students { get; set; }


    public Author? Author { get; set; }

    public BookType? BookType { get; set; }
}
