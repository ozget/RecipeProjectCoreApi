﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeProjectDal.Concreate.EntityFramework;

namespace RecipeProjectDal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190424184853_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Amount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IngredientId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Amounts");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desciription");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Amount", b =>
                {
                    b.HasOne("RecipeProjectEntity.Concreate.Ingredient", "Ingredient")
                        .WithMany("Amounts")
                        .HasForeignKey("IngredientId");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Category", b =>
                {
                    b.HasOne("RecipeProjectEntity.Concreate.Recipe", "Recipe")
                        .WithMany("Categories")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("RecipeProjectEntity.Concreate.Ingredient", b =>
                {
                    b.HasOne("RecipeProjectEntity.Concreate.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });
#pragma warning restore 612, 618
        }
    }
}
