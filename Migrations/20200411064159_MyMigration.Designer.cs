﻿// <auto-generated />
using System;
using CoreUIAppn.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreUIAppn.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20200411064159_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.2.20159.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core3MeetingApplication.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attendees")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("MeetingAgenda")
                        .IsRequired()
                        .HasColumnType("varchar(4000)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingSubject")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("MeetingId");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}
