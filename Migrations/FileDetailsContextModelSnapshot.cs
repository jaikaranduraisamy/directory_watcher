﻿// <auto-generated />
using System;
using FileWatcherApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FileWatcherApp.Migrations
{
    [DbContext(typeof(FileDetailsContext))]
    partial class FileDetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("FileWatcherApp.Models.ChangeType", b =>
                {
                    b.Property<int>("ChangeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChangeTypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("ChangeTypeId");

                    b.ToTable("changeTypes");

                    b.HasData(
                        new
                        {
                            ChangeTypeId = 1,
                            ChangeTypeName = "File Added"
                        },
                        new
                        {
                            ChangeTypeId = 2,
                            ChangeTypeName = "File Deleted"
                        });
                });

            modelBuilder.Entity("FileWatcherApp.Models.FileDetails", b =>
                {
                    b.Property<int>("FileDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChangeTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TaskDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("FileDetailsId");

                    b.ToTable("fileDetails");
                });

            modelBuilder.Entity("FileWatcherApp.Models.Logging", b =>
                {
                    b.Property<int>("LoggingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogDetails")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("LoggingId");

                    b.ToTable("logging");
                });

            modelBuilder.Entity("FileWatcherApp.Models.TaskDetails", b =>
                {
                    b.Property<int>("TaskDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TaskNameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TaskStatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskDetailsId");

                    b.ToTable("taskDetails");
                });

            modelBuilder.Entity("FileWatcherApp.Models.TaskName", b =>
                {
                    b.Property<int>("TaskNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskNameId");

                    b.ToTable("taskName");

                    b.HasData(
                        new
                        {
                            TaskNameId = 1,
                            Name = "Task Started"
                        },
                        new
                        {
                            TaskNameId = 2,
                            Name = "Task Ended"
                        });
                });

            modelBuilder.Entity("FileWatcherApp.Models.TaskStatus", b =>
                {
                    b.Property<int>("TaskStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskStatusId");

                    b.ToTable("taskStatus");

                    b.HasData(
                        new
                        {
                            TaskStatusId = 1,
                            StatusName = "Running"
                        },
                        new
                        {
                            TaskStatusId = 2,
                            StatusName = "Ended"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
