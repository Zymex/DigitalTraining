using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining._ApplicationModels.GeneralTraining
{
    public class TrainingDocument
    {
        public Guid Id { get; set; }
        public DateTime DateOfTraining { get; set; }
        public string Location { get; set; }
        public string ProcedureNumber { get; set; }
        public string RevisionNumber { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public virtual TrainingCourseType TrainingCourseType { get; set; }

        //FOR HR ONLY
        public virtual List<TrainingHRDocument> TrainingHRDocument {get ;set;}

        //TRAINING ROSTER
        public virtual List<TrainingRoster> TrainingRoster { get; set; }
    }
}
