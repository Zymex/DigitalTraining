using DigitalTraining._ApplicationModels.TemplatingSystem;
using DigitalTraining.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining.Extensions
{
    public static class TemplateExtensions
    {
        //We build/define our templates here
        public static bool TemplateBuilder(this ApplicationContext db, GeneralCertificationTrainingTemplate trainingTemplate)
        {
            try
            {
                db.Add(trainingTemplate);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
     
        }
        public static bool TemplateBuilder(this ApplicationContext db, GeneralCertificationTopicTemplate topicTemplate)
        {
            try
            {
                db.Add(topicTemplate);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool TemplateBuilder(this ApplicationContext db, GeneralCertificationQuestionTemplate questionTemplate)
        {
            try
            {
                db.Add(questionTemplate);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
