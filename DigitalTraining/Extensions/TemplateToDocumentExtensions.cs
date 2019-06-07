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
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
