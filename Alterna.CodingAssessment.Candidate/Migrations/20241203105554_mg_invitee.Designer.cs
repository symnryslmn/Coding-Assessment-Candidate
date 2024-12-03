﻿// <auto-generated />
using Alterna.CodingAssessment.Candidate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alterna.CodingAssessment.Candidate.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20241203105554_mg_invitee")]
    partial class mg_invitee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Alterna.CodingAssessment.Candidate.Entities.Invitee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCheck")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmailSent")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MailId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Invitees");
                });
#pragma warning restore 612, 618
        }
    }
}
