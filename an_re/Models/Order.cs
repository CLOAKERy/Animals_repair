using System;
using System.Collections.Generic;
using an_re.Models;

namespace an_re;

public partial class Order
{
    public int Id { get; set; }

    public int IdCustomer { get; set; }

    public string Date { get; set; } = null!;

    public double Price { get; set; }

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual Customer IdCustomerNavigation { get; set; } = null!;
}
