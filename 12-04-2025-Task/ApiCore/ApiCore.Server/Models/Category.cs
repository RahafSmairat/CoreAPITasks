using System;
using System.Collections.Generic;

namespace ApiCore.Server.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDesc { get; set; }
}
