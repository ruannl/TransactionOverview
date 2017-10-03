using System;

namespace TransactionOverview.Repository.models
{
    public class SalaryDate : EntityId
    {
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public int SalaryMonth { get; set; } 
        public int SalaryYear { get; set; } 
    }
}