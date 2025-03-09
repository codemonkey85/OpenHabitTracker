﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenHabitTracker.Blazor.Web.Data;

#nullable disable

namespace OpenHabitTracker.Blazor.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250309173925_AddLastChangeAt")]
    partial class AddLastChangeAt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OpenHabitTracker.Blazor.Web.Data.ApplicationRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("OpenHabitTracker.Blazor.Web.Data.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastChangeAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("OpenHabitTracker.Blazor.Web.Data.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.CategoryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.ContentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasDiscriminator().HasValue("ContentEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.ItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DoneAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.PriorityEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.SettingsEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DisplayNoteContentAsMarkdown")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FirstDayOfWeek")
                        .HasColumnType("INTEGER");

                    b.PrimitiveCollection<string>("HiddenCategoryIds")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HorizontalMargin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InsertTabsInNoteContent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDarkMode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("RememberMe")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SelectedRatio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SelectedRatioMin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowColor")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowCreatedUpdated")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowHelp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowItemList")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowLargeCalendar")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ShowOnlyOverSelectedRatioMin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShowPriority")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("ShowPriority");

                    b.Property<bool>("ShowSmallCalendar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SortBy")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("SortBy");

                    b.Property<string>("StartPage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartSidebar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UncheckAllItemsOnHabitDone")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VerticalMargin")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.TimeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("HabitId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.HabitEntity", b =>
                {
                    b.HasBaseType("OpenHabitTracker.Data.Entities.ContentEntity");

                    b.Property<TimeOnly?>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastTimeDoneAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("RepeatCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RepeatInterval")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RepeatPeriod")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("HabitEntity");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.NoteEntity", b =>
                {
                    b.HasBaseType("OpenHabitTracker.Data.Entities.ContentEntity");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("NoteEntity");
                });

            modelBuilder.Entity("OpenHabitTracker.Data.Entities.TaskEntity", b =>
                {
                    b.HasBaseType("OpenHabitTracker.Data.Entities.ContentEntity");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly?>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PlannedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("TEXT");

                    b.ToTable("Contents", t =>
                        {
                            t.Property("Duration")
                                .HasColumnName("TaskEntity_Duration");
                        });

                    b.HasDiscriminator().HasValue("TaskEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("OpenHabitTracker.Blazor.Web.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
