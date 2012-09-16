
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VariantsViewModel {
      	public System.Guid Id { get; set; }
    	public string Answer { get; set; }
    	public int AnswersCount { get; set; }
    	public System.Guid PollId { get; set; }
    }
}

