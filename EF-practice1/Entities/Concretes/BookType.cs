using EF_practice1.Entities.Abstrsacts;

namespace EF_practice1.Entities.Concretes;

public class BookType :BaseEntity 
{ 
    public string? Name { get; set; }



    public ICollection<Book>? Books { get; set;}
}
 