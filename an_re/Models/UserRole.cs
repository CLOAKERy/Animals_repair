﻿using System;
using System.Collections.Generic;

namespace an_re.Models;

public partial class UserRole
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
