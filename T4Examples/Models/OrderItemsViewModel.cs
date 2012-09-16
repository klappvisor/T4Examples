
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItemsViewModel {
      	public System.Guid Id { get; set; }
    	public decimal Cost { get; set; }
    	public int Count { get; set; }
    	public string DisplayName { get; set; }
    	public System.Guid ProductId { get; set; }
    	public Nullable<System.Guid> Order_Id { get; set; }
    }
}
