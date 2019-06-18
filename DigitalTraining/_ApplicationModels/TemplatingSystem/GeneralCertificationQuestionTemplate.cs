using System.ComponentModel.DataAnnotations;

namespace DigitalTraining._ApplicationModels.TemplatingSystem
{
    public class GeneralCertificationQuestionTemplate
    {
        [Key]
        public int QuestionTemplateId { get; set; }
        public string QuestionDescriptionTemplate { get; set; }
        public string ExpectedAnswerTemplate { get; set; }
    }
}