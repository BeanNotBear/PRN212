using System;
using System.Collections.Generic;

namespace EF_DB_First.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public override string ToString()
    {
        return $"{ProductId} {ProductName} {UnitPrice} {UnitsInStock} {CategoryId}";
    }
}
