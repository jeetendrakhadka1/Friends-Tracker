﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using team_origin;

namespace team_origin.Migrations
{
    [DbContext(typeof(TeamOriginContext))]
    [Migration("20171125225222_Testing the db error")]
    partial class Testingthedberror
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(200);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(200);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId")
                        .HasMaxLength(50);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(50);

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("team_origin.Entities.Friendship", b =>
                {
                    b.Property<int>("FrienshipId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FriendshipStatusId");

                    b.Property<string>("FromUserId");

                    b.Property<string>("ToUserId");

                    b.HasKey("FrienshipId");

                    b.HasIndex("FriendshipStatusId");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Friendship");
                });

            modelBuilder.Entity("team_origin.Entities.FriendshipStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusDescription")
                        .HasMaxLength(50);

                    b.HasKey("StatusId");

                    b.ToTable("FriendshipStatus");
                });

            modelBuilder.Entity("team_origin.Entities.Mood", b =>
                {
                    b.Property<int>("MoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("MoodDescription")
                        .HasMaxLength(140);

                    b.Property<string>("UserId");

                    b.HasKey("MoodId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Mood");
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<bool>("NotificationAcknowledged");

                    b.Property<string>("NotificationDetails");

                    b.Property<int>("NotificationTypeId");

                    b.HasKey("NotificationId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.NotificationType", b =>
                {
                    b.Property<int>("NotificationTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NotificationTypeDescription")
                        .HasMaxLength(200);

                    b.HasKey("NotificationTypeId");

                    b.ToTable("NotificationType");
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.UserNotificationRef", b =>
                {
                    b.Property<int>("UserNotificationRefId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NotificationId");

                    b.Property<string>("RecipientUserId");

                    b.HasKey("UserNotificationRefId");

                    b.HasIndex("NotificationId")
                        .IsUnique();

                    b.HasIndex("RecipientUserId");

                    b.ToTable("UserNotificationRef");
                });

            modelBuilder.Entity("team_origin.Entities.Schedule.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DayId");

                    b.Property<string>("EventDescription");

                    b.Property<int>("From");

                    b.Property<int>("To");

                    b.Property<string>("UserId");

                    b.HasKey("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("team_origin.Entities.Schedule.UserEventRef", b =>
                {
                    b.Property<int>("UserEventRefId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("UserId");

                    b.HasKey("UserEventRefId");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserEventRef");
                });

            modelBuilder.Entity("team_origin.Entities.VerificationCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("VerificationCode");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("team_origin.Entities.Notifications.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("team_origin.Entities.Friendship", b =>
                {
                    b.HasOne("team_origin.Entities.FriendshipStatus", "FriendshipStatus")
                        .WithMany("Friendship")
                        .HasForeignKey("FriendshipStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("team_origin.Entities.Notifications.User", "FromUser")
                        .WithMany("FromUserFriendship")
                        .HasForeignKey("FromUserId");

                    b.HasOne("team_origin.Entities.Notifications.User", "ToUser")
                        .WithMany("ToUserFriendship")
                        .HasForeignKey("ToUserId");
                });

            modelBuilder.Entity("team_origin.Entities.Mood", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User", "User")
                        .WithOne("Mood")
                        .HasForeignKey("team_origin.Entities.Mood", "UserId");
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.Notification", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User", "User")
                        .WithMany("Notification")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("team_origin.Entities.Notifications.NotificationType", "NotificationType")
                        .WithMany("Notification")
                        .HasForeignKey("NotificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("team_origin.Entities.Notifications.UserNotificationRef", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.Notification", "Notification")
                        .WithOne("UserNotificationRef")
                        .HasForeignKey("team_origin.Entities.Notifications.UserNotificationRef", "NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("team_origin.Entities.Notifications.User", "User")
                        .WithMany("UserNotificationRef")
                        .HasForeignKey("RecipientUserId");
                });

            modelBuilder.Entity("team_origin.Entities.Schedule.Event", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User")
                        .WithMany("Event")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("team_origin.Entities.Schedule.UserEventRef", b =>
                {
                    b.HasOne("team_origin.Entities.Schedule.Event", "Event")
                        .WithOne("UserEventRef")
                        .HasForeignKey("team_origin.Entities.Schedule.UserEventRef", "EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("team_origin.Entities.Notifications.User", "User")
                        .WithMany("UserEventRef")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("team_origin.Entities.VerificationCode", b =>
                {
                    b.HasOne("team_origin.Entities.Notifications.User", "User")
                        .WithOne("VerificationCode")
                        .HasForeignKey("team_origin.Entities.VerificationCode", "UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
