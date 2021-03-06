﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using thecloudbilltest.Models;

namespace thecloudbilltest.Migrations.Login
{
    [DbContext(typeof(LoginContext))]
    [Migration("20200422061939_Login")]
    partial class Login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("thecloudbilltest.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LoginPassword")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("LoginID");

                    b.ToTable("Login");
                });
#pragma warning restore 612, 618
        }
    }
}
