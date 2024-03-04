using System;
using System.Collections.Generic;

namespace WebApi_01.Database;

public partial class Transaction
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
