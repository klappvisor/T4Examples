
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FridayConfigsViewModel {
      	public System.Guid Id { get; set; }
    	public bool IsClosed { get; set; }
    	public System.DateTime StartTime { get; set; }
    	public System.DateTime ExpiredTime { get; set; }
    }
}
