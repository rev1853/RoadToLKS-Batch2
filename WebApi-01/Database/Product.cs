using System;
using System.Collections.Generic;

namespace WebApi_01.Database;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Brand { get; set; }

    public int Stock { get; set; }

    public int CategoryId { get; set; }

    public double Price { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
