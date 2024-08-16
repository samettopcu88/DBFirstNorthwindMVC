using System;
using System.Collections.Generic;

namespace DBFİrstNorthwindMVC.Models;

public partial class ViewCustomer
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? ContactTİtle { get; set; }
}
