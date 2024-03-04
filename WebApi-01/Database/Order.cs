using System;
using System.Collections.Generic;

namespace WebApi_01.Database;

public partial class Order
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public int TransactionId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
