﻿// <auto-generated />
using System;
using MARShop.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MARShop.Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(9606),
                            IsDelete = false,
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(9610),
                            Password = "123456789",
                            Role = 0,
                            UserName = "superadmin"
                        });
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

            modelBuilder.Entity("MARShop.Core.Entities.History", b =>
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

                    b.Property<int>("MediaId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Histories");
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

                    b.Property<int>("ImageIdentityWidth")
                        .HasColumnType("integer");

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
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(1212),
                            IsDelete = false,
                            Key = "media-create",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(8318),
                            ParentId = 0,
                            Title = "Thêm media"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9380),
                            IsDelete = false,
                            Key = "media-update",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9385),
                            ParentId = 0,
                            Title = "Sửa media"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9386),
                            IsDelete = false,
                            Key = "media-delete",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9387),
                            ParentId = 0,
                            Title = "Xóa media"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9388),
                            IsDelete = false,
                            Key = "media-get",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9389),
                            ParentId = 0,
                            Title = "Xem media"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7333),
                            IsDelete = false,
                            Key = "shop-create",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7339),
                            ParentId = 0,
                            Title = "Thêm cửa hàng"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7341),
                            IsDelete = false,
                            Key = "shop-update",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7342),
                            ParentId = 0,
                            Title = "Sửa cửa hàng"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7343),
                            IsDelete = false,
                            Key = "shop-delete",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7344),
                            ParentId = 0,
                            Title = "Xóa cửa hàng"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7345),
                            IsDelete = false,
                            Key = "shop-get",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7346),
                            ParentId = 0,
                            Title = "Xem cửa hàng"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7423),
                            IsDelete = false,
                            Key = "app-update",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7424),
                            ParentId = 0,
                            Title = "Sửa thông tin ứng dụng"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7426),
                            IsDelete = false,
                            Key = "app-get",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7427),
                            ParentId = 0,
                            Title = "Xem thông tin ứng dụng"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7443),
                            IsDelete = false,
                            Key = "account-create",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7444),
                            ParentId = 0,
                            Title = "Thêm tài khoản"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7445),
                            IsDelete = false,
                            Key = "account-update",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7446),
                            ParentId = 0,
                            Title = "Sửa tài khoản"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7447),
                            IsDelete = false,
                            Key = "account-delete",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7448),
                            ParentId = 0,
                            Title = "Xóa tài khoản"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7449),
                            IsDelete = false,
                            Key = "account-get",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7449),
                            ParentId = 0,
                            Title = "Xem tài khoản"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7462),
                            IsDelete = false,
                            Key = "role-create",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7463),
                            ParentId = 0,
                            Title = "Thêm nhóm quyền"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7464),
                            IsDelete = false,
                            Key = "role-update",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7465),
                            ParentId = 0,
                            Title = "Sửa nhóm quyền"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7466),
                            IsDelete = false,
                            Key = "role-delete",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7467),
                            ParentId = 0,
                            Title = "Xóa nhóm quyền"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7468),
                            IsDelete = false,
                            Key = "role-get",
                            LastModified = new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7469),
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

                    b.Property<string>("LatLong")
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
