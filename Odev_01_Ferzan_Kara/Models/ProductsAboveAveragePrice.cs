using System;
using System.Collections.Generic;

namespace Odev_01_Ferzan_Kara.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
