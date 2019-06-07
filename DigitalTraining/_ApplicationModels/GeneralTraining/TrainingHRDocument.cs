using System;

namespace DigitalTraining._ApplicationModels.GeneralTraining
{
    public class TrainingHRDocument
    {
        public int Id { get; set; }
        public string Tuition { get; set; }
        public string Books { get; set; }
        public string Grades { get; set; }
        public DateTime DateRequested { get; set; }
    }
}