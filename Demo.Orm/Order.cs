using System;
using System.Collections.Generic;

namespace Demo.Orm;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
