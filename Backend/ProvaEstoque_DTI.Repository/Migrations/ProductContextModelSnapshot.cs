﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaEstoque_DTI.Repository.Context;

namespace ProvaEstoque_DTI.Repository.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProvaEstoque_DTI.Domain.Entity.Product", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Identifier");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
