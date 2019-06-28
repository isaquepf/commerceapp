using System;

namespace OrderApi.Models
{
  public class Order
  {
    public static Order NewOrder(decimal amount)
        => new Order
        {
          Id = Guid.NewGuid(),
          Amount = amount
        };

    public Guid Id { get; private set; }
    public decimal Amount { get; private set; }
  }
}