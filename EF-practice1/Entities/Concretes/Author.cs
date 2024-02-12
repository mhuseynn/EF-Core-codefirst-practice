﻿using EF_practice1.Entities.Abstrsacts;

namespace EF_practice1.Entities.Concretes;

public class Author : BaseEntity
{

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
                    

    public ICollection<Book>? Books { get; set; }
}