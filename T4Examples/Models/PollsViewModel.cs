
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PollsViewModel {
      	public System.Guid Id { get; set; }
    	public int TypeId { get; set; }
    	public int ForTypeId { get; set; }
    	public string Question { get; set; }
    	public System.DateTime PublishDate { get; set; }
    	public bool isPublish { get; set; }
    }
}
