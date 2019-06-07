using DigitalTraining._ApplicationModels;
using DigitalTraining._ApplicationModels.GeneralCertificationTraining;
using DigitalTraining._ApplicationModels.GeneralTraining;
using DigitalTraining._ApplicationModels.TemplatingSystem;
using DigitalTraining.ActiveDirectory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalTraining.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
                
        }
        public ApplicationContext(DbContextOptions options)  : base(options)  {      }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TrainingDocument> TrainingDocuments { get; set; }
        public DbSet<TrainingHRDocument> TrainingHRDocuments { get; set; }
        public DbSet<TrainingRoster> TrainingRosters { get; set; }
        public DbSet<TrainingCourseType> TrainingCourseTypes { get; set; }
        public DbSet<GeneralCertificationQuestionTemplate> GeneralCertificationQuestionTemplates { get; set; }
        public DbSet<GeneralCertificationTopicTemplate> GeneralCertificationTopicTemplates { get; set; }
        public DbSet<GeneralCertificationTrainingTemplate> GeneralCertificationTrainingTemplates { get; set; }
        public DbSet<CertificationTrainingDocument> CertificationTrainingDocuments { get; set; }
        public DbSet<CertificationTrainingDocumentQuestions> CertificationTrainingDocumentQuestions { get; set; }
        public DbSet<CertificationTrainingDocumentTopics> CertificationTrainingDocumentTopics { get; set; }
    }
}
