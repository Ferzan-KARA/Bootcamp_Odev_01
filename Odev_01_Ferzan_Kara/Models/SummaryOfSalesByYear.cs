using System;
using System.Collections.Generic;

namespace Odev_01_Ferzan_Kara.Models;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
