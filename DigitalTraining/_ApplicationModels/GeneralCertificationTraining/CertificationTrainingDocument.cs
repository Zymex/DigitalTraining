using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining._ApplicationModels.GeneralCertificationTraining
{
    public class CertificationTrainingDocument
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public string ProcedureNumber { get; set; }
        public string Rev { get; set; }
        public string Employee { get; set; }
        public string Training { get; set; }
        public string Manager { get; set; }
        public DateTime DateTrainingBegun { get; set; }
        public string Distinguish { get; set; }
        public string Identify { get; set; }
        public string Describe { get; set; }
        public virtual List<CertificationTrainingDocumentTopics> Topics { get; set; }
        public virtual List<CertificationTrainingDocumentQuestions> Questions { get; set; }
    }
}
