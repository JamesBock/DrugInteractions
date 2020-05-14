﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UWPLockStep.Persistance.Services;

namespace UWPLockStep.Persistance.Migrations
{
    [DbContext(typeof(LockStepContextSql))]
    [Migration("20191023041612_IngredientDecorator")]
    partial class IngredientDecorator
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Factors.FactorBase", b =>
                {
                    b.Property<int>("FactorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FactorId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FactorName")
                        .HasColumnName("FactorName");

                    b.Property<string>("FactorType")
                        .HasColumnName("FactorType");

                    b.Property<string>("FactorUnit")
                        .HasColumnName("FactorUnit");

                    b.HasKey("FactorId");

                    b.ToTable("FactorBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FactorBase");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Ingredients.IngredientBase", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IngredientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("IngredientName")
                        .HasColumnName("IngredientName");

                    b.Property<string>("IngredientUnit")
                        .HasColumnName("IngredientUnit");

                    b.HasKey("IngredientId");

                    b.ToTable("IngredientBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IngredientBase");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Joins.FactorIngredient", b =>
                {
                    b.Property<int>("FactorId")
                        .HasColumnName("FactorId");

                    b.Property<int>("IngredientId")
                        .HasColumnName("IngredientId");

                    b.Property<int?>("FactorDecoratorFactorId");

                    b.HasKey("FactorId", "IngredientId");

                    b.HasIndex("FactorDecoratorFactorId");

                    b.HasIndex("IngredientId");

                    b.ToTable("FactorIngredients");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Joins.IngredientOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderId");

                    b.Property<int>("IngredientId")
                        .HasColumnName("IngredientId");

                    b.HasKey("OrderId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("IngredientOrders");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("OrderDescription");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("OrderName")
                        .HasColumnName("OrderName");

                    b.Property<Guid?>("PatientId");

                    b.Property<int>("PrescriberId");

                    b.Property<string>("PrescriberNotes")
                        .HasColumnName("PrescriberNotes");

                    b.Property<DateTime>("TimeExecuted");

                    b.Property<DateTime>("TimeOrdered");

                    b.HasKey("OrderId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PrescriberId");

                    b.ToTable("Orders");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Order");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.People.Patient", b =>
                {
                    b.Property<Guid>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PatientId");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DateOfBirth");

                    b.Property<decimal>("DayOfLife")
                        .HasColumnName("DayOfLife");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName");

                    b.Property<string>("PatientType")
                        .HasColumnName("PatientType");

                    b.Property<int?>("PractitionerUserId");

                    b.Property<decimal>("WeightG")
                        .HasColumnName("WeightG");

                    b.HasKey("PatientId");

                    b.HasIndex("PractitionerUserId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.People.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName");

                    b.Property<string>("PostNominals")
                        .HasColumnName("PostNominals");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.PolicyBase", b =>
                {
                    b.Property<int>("PolicyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PolicyId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<decimal>("Maximum")
                        .HasColumnName("Maximum");

                    b.Property<decimal>("Minimum")
                        .HasColumnName("Minimum");

                    b.Property<string>("PatientType")
                        .HasColumnName("PatientType");

                    b.Property<string>("PolicyBasis")
                        .HasColumnName("PolicyBasis");

                    b.Property<long>("PolicyDuration")
                        .HasColumnName("PolicyDuration");

                    b.Property<string>("WarningLevel")
                        .HasColumnName("WarningLevel");

                    b.HasKey("PolicyId");

                    b.ToTable("PolicyBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PolicyBase");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.FactorDecorator", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Factors.FactorBase");

                    b.HasDiscriminator().HasValue("FactorDecorator");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Factors.Factor", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Factors.FactorBase");

                    b.Property<int?>("IngredientBaseIngredientId");

                    b.HasIndex("IngredientBaseIngredientId");

                    b.HasDiscriminator().HasValue("Factor");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Ingredients.Ingredient", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Ingredients.IngredientBase");

                    b.Property<int?>("OrderId");

                    b.Property<Guid?>("PatientId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PatientId");

                    b.HasDiscriminator().HasValue("Ingredient");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Orders.FluidOrder", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Orders.Order");

                    b.Property<string>("AdministrationRoute")
                        .HasColumnName("AdimnistrationRoute");

                    b.Property<long>("Duration")
                        .HasColumnName("Duration");

                    b.Property<double>("Volume")
                        .HasColumnName("Volume");

                    b.HasDiscriminator().HasValue("FluidOrder");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.FactorPolicy", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Policies.PolicyBase");

                    b.Property<int>("FactorId");

                    b.HasIndex("FactorId");

                    b.HasDiscriminator().HasValue("FactorPolicy");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.IngredientPolicy", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Policies.PolicyBase");

                    b.Property<int>("IngredientId");

                    b.HasIndex("IngredientId");

                    b.HasDiscriminator().HasValue("IngredientPolicy");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.OrderPolicy", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Policies.PolicyBase");

                    b.Property<int?>("OrderId");

                    b.HasIndex("OrderId");

                    b.HasDiscriminator().HasValue("OrderPolicy");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.IngredientFactorDecorator", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.FactorDecorator");

                    b.Property<decimal>("AmountContained");

                    b.Property<decimal>("PerIngredientUnit");

                    b.HasDiscriminator().HasValue("IngredientFactorDecorator");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.OrderedFactorDecorator", b =>
                {
                    b.HasBaseType("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.FactorDecorator");

                    b.Property<decimal>("AmountOrdered");

                    b.Property<bool>("IsActive");

                    b.Property<Guid?>("PatientId");

                    b.HasIndex("PatientId");

                    b.HasDiscriminator().HasValue("OrderedFactorDecorator");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Joins.FactorIngredient", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.FactorDecorator")
                        .WithMany("FactorIngredients")
                        .HasForeignKey("FactorDecoratorFactorId");

                    b.HasOne("UWPLockStep.Domain.Entities.Factors.Factor", "Factor")
                        .WithMany("FactorIngredients")
                        .HasForeignKey("FactorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UWPLockStep.Domain.Entities.Ingredients.Ingredient", "Ingredient")
                        .WithMany("FactorIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Joins.IngredientOrder", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Ingredients.Ingredient", "Ingredient")
                        .WithMany("IngredientOrders")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UWPLockStep.Domain.Entities.Orders.Order", "Order")
                        .WithMany("IngredientOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.People.Patient")
                        .WithMany("Orders")
                        .HasForeignKey("PatientId");

                    b.HasOne("UWPLockStep.Domain.Entities.People.User", "Prescriber")
                        .WithMany("Orders")
                        .HasForeignKey("PrescriberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.People.Patient", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.People.User", "Practitioner")
                        .WithMany("Patients")
                        .HasForeignKey("PractitionerUserId");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Factors.Factor", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Ingredients.IngredientBase")
                        .WithMany("Factors")
                        .HasForeignKey("IngredientBaseIngredientId");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Ingredients.Ingredient", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Orders.Order")
                        .WithMany("Ingredients")
                        .HasForeignKey("OrderId");

                    b.HasOne("UWPLockStep.Domain.Entities.People.Patient")
                        .WithMany("Ingredients")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.FactorPolicy", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Factors.Factor")
                        .WithMany()
                        .HasForeignKey("FactorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.IngredientPolicy", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Ingredients.Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Policies.OrderPolicy", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.Orders.Order", "Order")
                        .WithMany("OrderPolicies")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("UWPLockStep.Domain.Entities.Decorators.FactorDecorators.OrderedFactorDecorator", b =>
                {
                    b.HasOne("UWPLockStep.Domain.Entities.People.Patient")
                        .WithMany("Factors")
                        .HasForeignKey("PatientId");
                });
#pragma warning restore 612, 618
        }
    }
}