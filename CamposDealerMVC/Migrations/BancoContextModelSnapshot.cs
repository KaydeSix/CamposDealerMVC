﻿// <auto-generated />
using System;
using CamposDealerMVC.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CamposDealerMVC.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CamposDealerMVC.Models.ClienteModel", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.HasKey("IdCliente");

                    b.ToTable("CLIENTE");
                });

            modelBuilder.Entity("CamposDealerMVC.Models.ProdutoModel", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("DESCRICAO_PRODUTO");

                    b.Property<float>("VlrUnitario")
                        .HasColumnType("real")
                        .HasColumnName("VALOR_UNITARIO");

                    b.HasKey("IdProduto");

                    b.ToTable("PRODUTO");
                });

            modelBuilder.Entity("CamposDealerMVC.Models.VendaModel", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_VENDA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenda"), 1L, 1);

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_VENDA");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("ID_PRODUTO");

                    b.Property<long>("QtdVenda")
                        .HasColumnType("bigint")
                        .HasColumnName("QTD_VENDA");

                    b.Property<float>("VlrTotalVenda")
                        .HasColumnType("real")
                        .HasColumnName("VLR_TOTAL_VENDA");

                    b.Property<long>("VlrUnitarioVenda")
                        .HasColumnType("bigint")
                        .HasColumnName("VLR_UNITARIO_VENDA");

                    b.HasKey("IdVenda");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProduto");

                    b.ToTable("VENDA");
                });

            modelBuilder.Entity("CamposDealerMVC.Models.VendaModel", b =>
                {
                    b.HasOne("CamposDealerMVC.Models.ClienteModel", "ClienteModel")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CamposDealerMVC.Models.ProdutoModel", "ProdutoModel")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteModel");

                    b.Navigation("ProdutoModel");
                });
#pragma warning restore 612, 618
        }
    }
}