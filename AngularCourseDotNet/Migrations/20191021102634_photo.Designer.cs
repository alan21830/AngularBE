﻿// <auto-generated />
using System;
using AngularCourseDotNet.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularCourseDotNet.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191021102634_photo")]
    partial class photo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("AngularCourseDotNet.Controllers.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Creazione");

                    b.Property<string>("Description");

                    b.Property<string>("Url");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("AngularCourseDotNet.Controllers.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.Property<string>("gender");

                    b.Property<string>("password");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AngularCourseDotNet.Controllers.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("AngularCourseDotNet.Controllers.Models.Photo", b =>
                {
                    b.HasOne("AngularCourseDotNet.Controllers.Models.User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
