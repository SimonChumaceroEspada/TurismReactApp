﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PlacesApi.Migrations
{
    [DbContext(typeof(PlacesDbContext))]
    partial class PlacesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PlacesApi.Domain.Entities.Food", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("eng_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("eng_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("esp_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("esp_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<int>("place_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("place_id");

                    b.ToTable("foods", (string)null);
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.Party", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("eng_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("eng_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("esp_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("esp_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<int>("place_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("place_id");

                    b.ToTable("parties", (string)null);
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.Place", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("capital")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("eng_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("esp_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("id");

                    b.ToTable("places", (string)null);
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.TouristicPlace", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("eng_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("eng_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("esp_description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("esp_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<int>("place_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("place_id");

                    b.ToTable("touristic_places", (string)null);
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.Food", b =>
                {
                    b.HasOne("PlacesApi.Domain.Entities.Place", "Place")
                        .WithMany("foods")
                        .HasForeignKey("place_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.Party", b =>
                {
                    b.HasOne("PlacesApi.Domain.Entities.Place", "Place")
                        .WithMany("parties")
                        .HasForeignKey("place_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.TouristicPlace", b =>
                {
                    b.HasOne("PlacesApi.Domain.Entities.Place", "Place")
                        .WithMany("touristic_places")
                        .HasForeignKey("place_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("PlacesApi.Domain.Entities.Place", b =>
                {
                    b.Navigation("foods");

                    b.Navigation("parties");

                    b.Navigation("touristic_places");
                });
#pragma warning restore 612, 618
        }
    }
}
