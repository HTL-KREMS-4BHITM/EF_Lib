﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configurations;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241112113221_initcreate")]
    partial class initcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("AUTHOR");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AUTHORID");

                    b.Property<int>("BookDetailsId")
                        .HasColumnType("int")
                        .HasColumnName("BOOKDETAILSID");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ISBN");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("varchar(21)");

                    b.Property<DateTime>("PublishedDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("PUBLISHEDDATE");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookDetailsId")
                        .IsUnique();

                    b.ToTable("BOOKS");

                    b.HasDiscriminator<string>("ItemType").HasValue("Book");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Model.Entities.BookDetails", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BOOKID");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int")
                        .HasColumnName("AVAILABLECOPIES");

                    b.Property<int>("BorrowedCopies")
                        .HasColumnType("int")
                        .HasColumnName("BORROWEDCOPIES");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int")
                        .HasColumnName("TOTALCOPIES");

                    b.HasKey("BookId");

                    b.ToTable("BOOKDETAILS");
                });

            modelBuilder.Entity("Model.Entities.BookLoans", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BOOKID");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMERID");

                    b.Property<int>("LibrarianId")
                        .HasColumnType("int")
                        .HasColumnName("LIBRARIANID");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LOANDATE");

                    b.Property<DateTime>("DueDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DUEDATE");

                    b.Property<DateTime?>("ReturnDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("RETURNDATE");

                    b.Property<int?>("ReturnLibrarianId")
                        .HasColumnType("int")
                        .HasColumnName("RETURNLIBRARIANID");

                    b.HasKey("BookId", "CustomerId", "LibrarianId", "LoanDate");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("ReturnLibrarianId");

                    b.ToTable("BOOKLOANS");
                });

            modelBuilder.Entity("Model.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateOfBirth")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATEOFBIRTH");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LASTNAME");

                    b.HasKey("Id");

                    b.ToTable("PERSONS");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Model.Entities.Biography", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("Biography");
                });

            modelBuilder.Entity("Model.Entities.Fantasy", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("Fantasy");
                });

            modelBuilder.Entity("Model.Entities.Mystery", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("Mystery");
                });

            modelBuilder.Entity("Model.Entities.NonFiction", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("NonFiction");
                });

            modelBuilder.Entity("Model.Entities.Novel", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("Novel");
                });

            modelBuilder.Entity("Model.Entities.ScienceFiction", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("ScienceFiction");
                });

            modelBuilder.Entity("Model.Entities.Textbook", b =>
                {
                    b.HasBaseType("Model.Entities.Book");

                    b.ToTable("BOOKS");

                    b.HasDiscriminator().HasValue("Textbook");
                });

            modelBuilder.Entity("Model.Entities.Author", b =>
                {
                    b.HasBaseType("Model.Entities.Person");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("BIOGRAPHY");

                    b.ToTable("AUTHORS", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Customer", b =>
                {
                    b.HasBaseType("Model.Entities.Person");

                    b.Property<DateTime>("MembershipDate")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("MEMBERSHIPDATE");

                    b.ToTable("CUSTOMERS", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Librarian", b =>
                {
                    b.HasBaseType("Model.Entities.Person");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("EMPLOYEEID");

                    b.ToTable("LIBRARIANS", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Book", b =>
                {
                    b.HasOne("Model.Entities.Author", "AuthorInit")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.BookDetails", "BookDetails")
                        .WithOne()
                        .HasForeignKey("Model.Entities.Book", "BookDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthorInit");

                    b.Navigation("BookDetails");
                });

            modelBuilder.Entity("Model.Entities.BookLoans", b =>
                {
                    b.HasOne("Model.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Librarian", "Librarian")
                        .WithMany()
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Librarian", "ReturnLibrarian")
                        .WithMany("BookLoans")
                        .HasForeignKey("ReturnLibrarianId");

                    b.Navigation("Book");

                    b.Navigation("Customer");

                    b.Navigation("Librarian");

                    b.Navigation("ReturnLibrarian");
                });

            modelBuilder.Entity("Model.Entities.Author", b =>
                {
                    b.HasOne("Model.Entities.Person", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.Author", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Customer", b =>
                {
                    b.HasOne("Model.Entities.Person", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Librarian", b =>
                {
                    b.HasOne("Model.Entities.Person", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.Librarian", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Model.Entities.Librarian", b =>
                {
                    b.Navigation("BookLoans");
                });
#pragma warning restore 612, 618
        }
    }
}
