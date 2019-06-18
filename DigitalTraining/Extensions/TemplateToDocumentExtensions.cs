using DigitalTraining._ApplicationModels.GeneralCertificationTraining;
using DigitalTraining.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining.Extensions
{
    public static class TemplateToDocumentExtensions
    {
        public static bool CreateDocumentFromTemplate(this ApplicationContext db, Guid id)
        {
            try
            {
                //Grab our template to build from
                var Template = db.GeneralCertificationTrainingTemplates.Where(x => x.GeneralCertificationTemplateId == id).FirstOrDefault();

                //Create our temporary list of topics
                var TempTopicList = new List<CertificationTrainingDocumentTopics>();
                //Get our list of topics and add to our list.
                foreach (var topic in Template.TopicTemplates)
                {
                    TempTopicList.Add(new CertificationTrainingDocumentTopics
                    {
                        TopicDescription = topic.TopicDescriptionTemplate
                    });
                }

                //Create our temporary list of questions
                var TempQuestionList = new List<CertificationTrainingDocumentQuestions>();
                //Get our Questions and add them to our list
                foreach (var question in Template.QuestionTemplates)
                {
                    TempQuestionList.Add(new CertificationTrainingDocumentQuestions
                    {
                        QuestionDescription = question.QuestionDescriptionTemplate,
                        ExpectedAnswer = question.ExpectedAnswerTemplate
                    });
                }

                CertificationTrainingDocument certificationTrainingDocument = new CertificationTrainingDocument
                {
                    ProcedureName = Template.ProceedureNameTemplate,
                    ProcedureNumber = Template.ProceedureNumberTemplate,
                    Rev = Template.RevisionTemplate,
                    Distinguish = Template.DistinguishTemplate,
                    Identify = Template.IdentifyTemplate,
                    Describe = Template.DescribeTemplate,
                    Topics = TempTopicList,
                    Questions = TempQuestionList,

                };
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
