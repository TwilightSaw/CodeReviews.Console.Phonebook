﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwilightSaw.Phonebook.Controller;

#nullable disable

namespace TwilightSaw.Phonebook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241122181557_Create")]
    partial class Create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryContact", b =>
                {
                    b.Property<int>("categoriesId")
                        .HasColumnType("int");

                    b.Property<int>("contactsId")
                        .HasColumnType("int");

                    b.HasKey("categoriesId", "contactsId");

                    b.HasIndex("contactsId");

                    b.ToTable("ContactCategories", (string)null);
                });

            modelBuilder.Entity("TwilightSaw.Phonebook.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TwilightSaw.Phonebook.Model.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CategoryContact", b =>
                {
                    b.HasOne("TwilightSaw.Phonebook.Model.Category", null)
                        .WithMany()
                        .HasForeignKey("categoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwilightSaw.Phonebook.Model.Contact", null)
                        .WithMany()
                        .HasForeignKey("contactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}