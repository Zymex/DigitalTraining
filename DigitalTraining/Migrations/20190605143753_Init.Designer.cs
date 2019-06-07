﻿// <auto-generated />
using System;
using DigitalTraining.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigitalTraining.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190605143753_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigitalTraining.ActiveDirectory.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<string>("OperatorId");

                    b.Property<string>("SocketName");

                    b.Property<string>("Theme");

                    b.Property<int?>("UserPreferencesId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("UserPreferencesId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("DigitalTraining.ActiveDirectory.UserPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingCourseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("TrainingCourseTypes");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName");

                    b.Property<DateTime>("DateOfTraining");

                    b.Property<string>("Instructor");

                    b.Property<string>("Location");

                    b.Property<string>("ProcedureNumber");

                    b.Property<string>("RevisionNumber");

                    b.Property<int?>("TrainingCourseTypeId");

                    b.HasKey("Id");

                    b.HasIndex("TrainingCourseTypeId");

                    b.ToTable("TrainingDocuments");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingHRDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Books");

                    b.Property<DateTime>("DateRequested");

                    b.Property<string>("Grades");

                    b.Property<Guid?>("TrainingDocumentId");

                    b.Property<string>("Tuition");

                    b.HasKey("Id");

                    b.HasIndex("TrainingDocumentId");

                    b.ToTable("TrainingHRDocuments");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingRoster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CostCenter");

                    b.Property<Guid>("EmployeeId");

                    b.Property<string>("EmployeeName");

                    b.Property<string>("EmployeeNumber");

                    b.Property<string>("PostTestScore");

                    b.Property<string>("PreTestScore");

                    b.Property<Guid?>("TrainingDocumentId");

                    b.HasKey("Id");

                    b.HasIndex("TrainingDocumentId");

                    b.ToTable("TrainingRosters");
                });

            modelBuilder.Entity("DigitalTraining.ActiveDirectory.ApplicationUser", b =>
                {
                    b.HasOne("DigitalTraining.ActiveDirectory.UserPreferences", "UserPreferences")
                        .WithMany()
                        .HasForeignKey("UserPreferencesId");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingDocument", b =>
                {
                    b.HasOne("DigitalTraining._ApplicationModels.TrainingCourseType", "TrainingCourseType")
                        .WithMany()
                        .HasForeignKey("TrainingCourseTypeId");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingHRDocument", b =>
                {
                    b.HasOne("DigitalTraining._ApplicationModels.TrainingDocument")
                        .WithMany("TrainingHRDocument")
                        .HasForeignKey("TrainingDocumentId");
                });

            modelBuilder.Entity("DigitalTraining._ApplicationModels.TrainingRoster", b =>
                {
                    b.HasOne("DigitalTraining._ApplicationModels.TrainingDocument")
                        .WithMany("TrainingRoster")
                        .HasForeignKey("TrainingDocumentId");
                });
#pragma warning restore 612, 618
        }
    }
}
