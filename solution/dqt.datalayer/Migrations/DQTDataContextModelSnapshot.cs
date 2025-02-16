﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dqt.datalayer.Database;

namespace dqt.datalayer.Migrations
{
    [DbContext(typeof(DQTDataContext))]
    partial class DQTDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("dqt.datalayer.Model.DQTFileTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Error")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastRun")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DQTFileTransfer");
                });

            modelBuilder.Entity("dqt.datalayer.Model.QualifiedTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<bool>("ActiveAlert")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ITTStartDate")
                        .HasColumnType("Date");

                    b.Property<string>("ITTSubject1Code")
                        .HasColumnType("text");

                    b.Property<string>("ITTSubject2Code")
                        .HasColumnType("text");

                    b.Property<string>("ITTSubject3Code")
                        .HasColumnType("text");

                    b.Property<string>("NINumber")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("QTSAwardDate")
                        .HasColumnType("Date");

                    b.Property<string>("QualificationName")
                        .HasColumnType("text");

                    b.Property<string>("Trn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QualifiedTeachers");
                });

            modelBuilder.Entity("dqt.datalayer.Model.QualifiedTeacherBackup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<bool>("ActiveAlert")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ITTStartDate")
                        .HasColumnType("Date");

                    b.Property<string>("ITTSubject1Code")
                        .HasColumnType("text");

                    b.Property<string>("ITTSubject2Code")
                        .HasColumnType("text");

                    b.Property<string>("ITTSubject3Code")
                        .HasColumnType("text");

                    b.Property<string>("NINumber")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("QTSAwardDate")
                        .HasColumnType("Date");

                    b.Property<string>("QualificationName")
                        .HasColumnType("text");

                    b.Property<string>("Trn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QualifiedTeachersBackup");
                });
#pragma warning restore 612, 618
        }
    }
}
