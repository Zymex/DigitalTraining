using System;

namespace DigitalTraining._ApplicationModels.GeneralCertificationTraining
{
    public class CertificationTrainingDocumentTopics
    {
        public int Id { get; set; }
        public string TopicDescription { get; set; }
        public DateTime EmployeeDateSigned { get; set; }
        public string EmployeeInitial { get; set; }
        public DateTime TrainerDateSigned { get; set; }
        public string TrainerInitial { get; set; }
        public DateTime ManagerDateSigned { get; set; }
        public string ManagerDate { get; set; }
    }
}