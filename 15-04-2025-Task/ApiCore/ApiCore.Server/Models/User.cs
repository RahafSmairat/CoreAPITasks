using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiCore.Server.Models;

public partial class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
    public string? Password { get; set; }
}
