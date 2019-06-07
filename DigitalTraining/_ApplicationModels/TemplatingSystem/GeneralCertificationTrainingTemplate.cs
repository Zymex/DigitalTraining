using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining._ApplicationModels.TemplatingSystem
{
    public class GeneralCertificationTrainingTemplate
    {
        public Guid GeneralCertificationTemplateId { get; set; }
        public string ProceedureNameTemplate { get; set; }
        public string ProceedureNumberTemplate { get; set; }
        public string RevisionTemplate { get; set; }
        public string DistinguishTemplate { get; set; }
        public string IdentifyTemplate { get; set; }
        public string DescribeTemplate { get; set; }
        public virtual List<GeneralCertificationTopicTemplate> TopicTemplates { get; set; }
        public virtual List<GeneralCertificationQuestionTemplate> QuestionTemplates { get; set; }

    }
}
