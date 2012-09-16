
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttestationPeriodsViewModel {
      	public System.Guid Id { get; set; }
    	public System.DateTime StartDate { get; set; }
    	public Nullable<System.DateTime> EndDate { get; set; }
    	public int RequiredPoints { get; set; }
    	public int StartPoints { get; set; }
    	public string FromGrade { get; set; }
    	public string Grade { get; set; }
    	public System.Guid User_Id { get; set; }
    }
}
