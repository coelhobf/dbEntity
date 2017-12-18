using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dbEntity;

namespace dbEntity.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20171218185343_Promocao")]
    partial class Promocao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dbEntity.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("PrecoT");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quant");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("dbEntity.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Nome");

                    b.Property<double>("PrecoU");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("dbEntity.Promocao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Categoria");

                    b.Property<int>("Nome");

                    b.Property<int>("PrecoUnitario");

                    b.Property<int?>("PromocaoId");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.HasIndex("PromocaoId");

                    b.ToTable("Promocoes");
                });

            modelBuilder.Entity("dbEntity.Compra", b =>
                {
                    b.HasOne("dbEntity.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dbEntity.Promocao", b =>
                {
                    b.HasOne("dbEntity.Promocao")
                        .WithMany("Promocoes")
                        .HasForeignKey("PromocaoId");
                });
        }
    }
}
