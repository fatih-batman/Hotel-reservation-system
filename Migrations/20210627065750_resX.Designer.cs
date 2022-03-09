﻿// <auto-generated />
using System;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210627065750_resX")]
    partial class resX
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel.Models.account", b =>
                {
                    b.Property<int>("admin_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("user_name")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("admin_ID");

                    b.ToTable("accountx");
                });

            modelBuilder.Entity("Hotel.Models.guest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("first_name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("last_name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("member_since")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("guest");
                });

            modelBuilder.Entity("Hotel.Models.hosted_at", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("guest_idid")
                        .HasColumnType("int");

                    b.Property<int?>("occupied_room_idid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("guest_idid");

                    b.HasIndex("occupied_room_idid");

                    b.ToTable("hosted_at");
                });

            modelBuilder.Entity("Hotel.Models.occupied_room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("check_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("check_out")
                        .HasColumnType("datetime2");

                    b.Property<int?>("reservation_idid")
                        .HasColumnType("int");

                    b.Property<int?>("room_idid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("reservation_idid");

                    b.HasIndex("room_idid");

                    b.ToTable("occupied_room");
                });

            modelBuilder.Entity("Hotel.Models.reservation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_out")
                        .HasColumnType("datetime2");

                    b.Property<int?>("guest_idid")
                        .HasColumnType("int");

                    b.Property<string>("made_by")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.HasIndex("guest_idid");

                    b.ToTable("reservation");
                });

            modelBuilder.Entity("Hotel.Models.reservationX", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("check_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("check_out")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_out")
                        .HasColumnType("datetime2");

                    b.Property<string>("guest_first_name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("guest_last_name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("made_by")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("room_number")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("Hotel.Models.reserved_room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("number_of_room")
                        .HasColumnType("int");

                    b.Property<int?>("reservation_idid")
                        .HasColumnType("int");

                    b.Property<int?>("room_type_idid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.HasIndex("reservation_idid");

                    b.HasIndex("room_type_idid");

                    b.ToTable("reserved_room");
                });

            modelBuilder.Entity("Hotel.Models.room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("number")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("room_type_idid")
                        .HasColumnType("int");

                    b.Property<bool>("smoke")
                        .HasColumnType("bit");

                    b.Property<string>("status")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("room_type_idid");

                    b.ToTable("room");
                });

            modelBuilder.Entity("Hotel.Models.room_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("max_capasity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("room_type");
                });

            modelBuilder.Entity("Hotel.Models.hosted_at", b =>
                {
                    b.HasOne("Hotel.Models.guest", "guest_id")
                        .WithMany()
                        .HasForeignKey("guest_idid");

                    b.HasOne("Hotel.Models.occupied_room", "occupied_room_id")
                        .WithMany()
                        .HasForeignKey("occupied_room_idid");

                    b.Navigation("guest_id");

                    b.Navigation("occupied_room_id");
                });

            modelBuilder.Entity("Hotel.Models.occupied_room", b =>
                {
                    b.HasOne("Hotel.Models.reservation", "reservation_id")
                        .WithMany()
                        .HasForeignKey("reservation_idid");

                    b.HasOne("Hotel.Models.room", "room_id")
                        .WithMany()
                        .HasForeignKey("room_idid");

                    b.Navigation("reservation_id");

                    b.Navigation("room_id");
                });

            modelBuilder.Entity("Hotel.Models.reservation", b =>
                {
                    b.HasOne("Hotel.Models.guest", "guest_id")
                        .WithMany()
                        .HasForeignKey("guest_idid");

                    b.Navigation("guest_id");
                });

            modelBuilder.Entity("Hotel.Models.reserved_room", b =>
                {
                    b.HasOne("Hotel.Models.reservation", "reservation_id")
                        .WithMany()
                        .HasForeignKey("reservation_idid");

                    b.HasOne("Hotel.Models.room_type", "room_type_id")
                        .WithMany()
                        .HasForeignKey("room_type_idid");

                    b.Navigation("reservation_id");

                    b.Navigation("room_type_id");
                });

            modelBuilder.Entity("Hotel.Models.room", b =>
                {
                    b.HasOne("Hotel.Models.room_type", "room_type_id")
                        .WithMany()
                        .HasForeignKey("room_type_idid");

                    b.Navigation("room_type_id");
                });
#pragma warning restore 612, 618
        }
    }
}
