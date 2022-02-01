﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAssociationAPI.Data;

namespace StudentAssociationAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220120171437_AddedAuth")]
    partial class AddedAuth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Application", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReviewerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssociationName");

                    b.HasIndex("MemberId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Association", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Associations");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.AssociationMembership", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AssociationName");

                    b.HasIndex("MemberId");

                    b.ToTable("AssociationMemberships");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.BoardMembership", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AssociationName");

                    b.HasIndex("MemberId");

                    b.ToTable("BoardMemberships");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Commitee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InaugurationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssociationName");

                    b.ToTable("Commitees");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.CommiteeMembership", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommiteeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CommiteeId");

                    b.HasIndex("MemberId")
                        .IsUnique()
                        .HasFilter("[MemberId] IS NOT NULL");

                    b.ToTable("CommiteeMemberships");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommiteeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CommiteeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.EventRegistration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("MemberId");

                    b.ToTable("EventRegistrations");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Member", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Application", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Association", "Association")
                        .WithMany("Applications")
                        .HasForeignKey("AssociationName");

                    b.HasOne("StudentAssociationAPI.Entities.Member", "Member")
                        .WithMany("Applications")
                        .HasForeignKey("MemberId");

                    b.Navigation("Association");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.AssociationMembership", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Association", "Association")
                        .WithMany("AssociationMemberships")
                        .HasForeignKey("AssociationName");

                    b.HasOne("StudentAssociationAPI.Entities.Member", "Member")
                        .WithMany("AssociationMemberships")
                        .HasForeignKey("MemberId");

                    b.Navigation("Association");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.BoardMembership", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Association", "Association")
                        .WithMany("BoardMemberships")
                        .HasForeignKey("AssociationName");

                    b.HasOne("StudentAssociationAPI.Entities.Member", "Member")
                        .WithMany("BoardMemberships")
                        .HasForeignKey("MemberId");

                    b.Navigation("Association");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Commitee", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Association", "Association")
                        .WithMany("Commitees")
                        .HasForeignKey("AssociationName");

                    b.Navigation("Association");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.CommiteeMembership", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Commitee", "Commitee")
                        .WithMany("CommiteeMemberships")
                        .HasForeignKey("CommiteeId");

                    b.HasOne("StudentAssociationAPI.Entities.Member", "Member")
                        .WithOne("CommiteeMembership")
                        .HasForeignKey("StudentAssociationAPI.Entities.CommiteeMembership", "MemberId");

                    b.Navigation("Commitee");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Event", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Commitee", "Commitee")
                        .WithMany("Events")
                        .HasForeignKey("CommiteeId");

                    b.Navigation("Commitee");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.EventRegistration", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Event", "Event")
                        .WithMany("EventRegistrations")
                        .HasForeignKey("EventId");

                    b.HasOne("StudentAssociationAPI.Entities.Member", "Member")
                        .WithMany("EventRegistrations")
                        .HasForeignKey("MemberId");

                    b.Navigation("Event");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.UserRole", b =>
                {
                    b.HasOne("StudentAssociationAPI.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentAssociationAPI.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("StudentAssociationAPI.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentAssociationAPI.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Association", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("AssociationMemberships");

                    b.Navigation("BoardMemberships");

                    b.Navigation("Commitees");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Commitee", b =>
                {
                    b.Navigation("CommiteeMemberships");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Event", b =>
                {
                    b.Navigation("EventRegistrations");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Member", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("AssociationMemberships");

                    b.Navigation("BoardMemberships");

                    b.Navigation("CommiteeMembership");

                    b.Navigation("EventRegistrations");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("StudentAssociationAPI.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
