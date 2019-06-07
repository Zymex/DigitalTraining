using System;
using System.Collections.Generic;

namespace DigitalTraining._ApplicationModels.GeneralTraining
{
    public class TrainingRoster
    {
        public int Id { get; set; }
        public virtual Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string CostCenter { get; set; }
        public string PreTestScore { get; set; }
        public string PostTestScore { get; set; }
    }
}