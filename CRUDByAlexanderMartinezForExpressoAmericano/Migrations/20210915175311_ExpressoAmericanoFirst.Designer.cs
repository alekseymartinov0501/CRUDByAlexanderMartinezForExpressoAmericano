﻿// <auto-generated />
using CRUDByAlexanderMartinezForExpressoAmericano.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDByAlexanderMartinezForExpressoAmericano.Migrations
{
    [DbContext(typeof(ApplicationdbContext))]
    [Migration("20210915175311_ExpressoAmericanoFirst")]
    partial class ExpressoAmericanoFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUDByAlexanderMartinezForExpressoAmericano.Models.Producto", b =>
                {
                    b.Property<int>("id_producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("codigo")
                        .HasColumnType("int");

                    b.Property<string>("descripcion_producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_marca")
                        .HasColumnType("int");

                    b.Property<int>("id_proveedr")
                        .HasColumnType("int");

                    b.Property<int>("id_zona")
                        .HasColumnType("int");

                    b.Property<int>("iva")
                        .HasColumnType("int");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id_producto");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
