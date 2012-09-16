
namespace T4Examples.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonthPointsViewModel {
      	public System.Guid Id { get; set; }
    	public int Points { get; set; }
    	public float Hours { get; set; }
    	public float Percentage { get; set; }
    	public string Comment { get; set; }
    	public System.DateTime Date { get; set; }
    	public float Certification { get; set; }
    	public int HoursForCertification { get; set; }
    	public int BonusForEstimation { get; set; }
    	public int BonusForBillableHours { get; set; }
    	public System.Guid User_Id { get; set; }
    	public System.Guid Period_Id { get; set; }
    }
}
