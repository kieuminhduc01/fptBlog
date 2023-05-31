﻿// <auto-generated />
using System;
using MARShop.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MARShop.Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220803021921_AddIdPropertyOfMeia")]
    partial class AddIdPropertyOfMeia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MARShop.Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MARShop.Core.Entities.AccountRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("MARShop.Core.Entities.AppInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppInfos");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageIdentity")
                        .HasColumnType("text");

                    b.Property<string>("ImageIdentityIdInVuforia")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("MediaFile")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("MARShop.Core.Entities.OTP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("CreateTime")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("ExpriredTime")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OTPs");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 83, DateTimeKind.Local).AddTicks(2510),
                            IsDelete = false,
                            Key = "media-create",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(8005),
                            ParentId = 0,
                            Title = "Thêm media"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9224),
                            IsDelete = false,
                            Key = "media-update",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9229),
                            ParentId = 0,
                            Title = "Sửa media"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9231),
                            IsDelete = false,
                            Key = "media-delete",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9232),
                            ParentId = 0,
                            Title = "Xóa media"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9233),
                            IsDelete = false,
                            Key = "media-get",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9234),
                            ParentId = 0,
                            Title = "Xem media"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8295),
                            IsDelete = false,
                            Key = "shop-create",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8302),
                            ParentId = 0,
                            Title = "Thêm cửa hàng"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8309),
                            IsDelete = false,
                            Key = "shop-update",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8311),
                            ParentId = 0,
                            Title = "Sửa cửa hàng"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8313),
                            IsDelete = false,
                            Key = "shop-delete",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8314),
                            ParentId = 0,
                            Title = "Xóa cửa hàng"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8315),
                            IsDelete = false,
                            Key = "shop-get",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8316),
                            ParentId = 0,
                            Title = "Xem cửa hàng"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8412),
                            IsDelete = false,
                            Key = "app-update",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8413),
                            ParentId = 0,
                            Title = "Sửa thông tin ứng dụng"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8415),
                            IsDelete = false,
                            Key = "app-get",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8415),
                            ParentId = 0,
                            Title = "Xem thông tin ứng dụng"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8432),
                            IsDelete = false,
                            Key = "account-create",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8433),
                            ParentId = 0,
                            Title = "Thêm tài khoản"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8434),
                            IsDelete = false,
                            Key = "account-update",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8435),
                            ParentId = 0,
                            Title = "Sửa tài khoản"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8436),
                            IsDelete = false,
                            Key = "account-delete",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8437),
                            ParentId = 0,
                            Title = "Xóa tài khoản"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8439),
                            IsDelete = false,
                            Key = "account-get",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8440),
                            ParentId = 0,
                            Title = "Xem tài khoản"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8453),
                            IsDelete = false,
                            Key = "role-create",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8454),
                            ParentId = 0,
                            Title = "Thêm nhóm quyền"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8456),
                            IsDelete = false,
                            Key = "role-update",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8456),
                            ParentId = 0,
                            Title = "Sửa nhóm quyền"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8458),
                            IsDelete = false,
                            Key = "role-delete",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8459),
                            ParentId = 0,
                            Title = "Xóa nhóm quyền"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8460),
                            IsDelete = false,
                            Key = "role-get",
                            LastModified = new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8461),
                            ParentId = 0,
                            Title = "Xem nhóm quyền"
                        });
                });

            modelBuilder.Entity("MARShop.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MARShop.Core.Entities.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CloseTime")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OpenTime")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("MARShop.Core.Entities.AccountRole", b =>
                {
                    b.HasOne("MARShop.Core.Entities.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MARShop.Core.Entities.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MARShop.Core.Entities.RolePermission", b =>
                {
                    b.HasOne("MARShop.Core.Entities.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MARShop.Core.Entities.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("MARShop.Core.Entities.Role", b =>
                {
                    b.Navigation("AccountRoles");

                    b.Navigation("RolePermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
