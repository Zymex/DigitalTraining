using System.ComponentModel.DataAnnotations;

namespace DigitalTraining._ApplicationModels.TemplatingSystem
{
    public class GeneralCertificationTopicTemplate
    {
        [Key]
        public int TopicTemplateId { get; set; }
        public string TopicDescriptionTemplate { get; set; }

    }
}