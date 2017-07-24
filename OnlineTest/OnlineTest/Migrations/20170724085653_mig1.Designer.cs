using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OnlineTest.Data;
using OnlineTest.Models;

namespace OnlineTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170724085653_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineTest.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("OnlineTest.Models.FeedBack", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Rating");

                    b.Property<int?>("TestId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("feedback");
                });

            modelBuilder.Entity("OnlineTest.Models.FinalResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Duration");

                    b.Property<int?>("TestId");

                    b.Property<int>("TotalScore");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("finalresult");
                });

            modelBuilder.Entity("OnlineTest.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorrectAnswer");

                    b.Property<int>("Expectedtime");

                    b.Property<string>("Questionn");

                    b.Property<int>("Score");

                    b.Property<string>("Screenshot");

                    b.Property<int?>("SubCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("OnlineTest.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("subcategory");
                });

            modelBuilder.Entity("OnlineTest.Models.Test", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("Level");

                    b.Property<float>("Minscore");

                    b.Property<int?>("QuestionId");

                    b.Property<string>("Result");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("test");
                });

            modelBuilder.Entity("OnlineTest.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("CellPhone");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FaxPhone");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("HomePhone");

                    b.Property<string>("IdUser");

                    b.Property<string>("Image");

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

                    b.Property<string>("PostalCode");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OnlineTest.Models.UserQA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int?>("FinralResultId");

                    b.Property<bool>("IsCorrect");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FinralResultId");

                    b.HasIndex("UserId");

                    b.ToTable("userqa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineTest.Models.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineTest.Models.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineTest.Models.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineTest.Models.FeedBack", b =>
                {
                    b.HasOne("OnlineTest.Models.Test", "Test")
                        .WithMany("Feedbacks")
                        .HasForeignKey("TestId");

                    b.HasOne("OnlineTest.Models.User", "User")
                        .WithMany("FeedBacks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineTest.Models.FinalResult", b =>
                {
                    b.HasOne("OnlineTest.Models.Test", "Test")
                        .WithMany("FinalResult")
                        .HasForeignKey("TestId");

                    b.HasOne("OnlineTest.Models.User", "User")
                        .WithMany("FinalResults")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineTest.Models.Question", b =>
                {
                    b.HasOne("OnlineTest.Models.SubCategory", "SubCategory")
                        .WithMany("Questions")
                        .HasForeignKey("SubCategoryId");
                });

            modelBuilder.Entity("OnlineTest.Models.SubCategory", b =>
                {
                    b.HasOne("OnlineTest.Models.Category", "Category")
                        .WithMany("SubCats")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("OnlineTest.Models.Test", b =>
                {
                    b.HasOne("OnlineTest.Models.Category", "Category")
                        .WithMany("Test")
                        .HasForeignKey("CategoryId");

                    b.HasOne("OnlineTest.Models.Question")
                        .WithMany("Tests")
                        .HasForeignKey("QuestionId");

                    b.HasOne("OnlineTest.Models.User", "User")
                        .WithMany("Tests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineTest.Models.UserQA", b =>
                {
                    b.HasOne("OnlineTest.Models.FinalResult", "FinralResult")
                        .WithMany("UserQA")
                        .HasForeignKey("FinralResultId");

                    b.HasOne("OnlineTest.Models.User", "User")
                        .WithMany("UserQAs")
                        .HasForeignKey("UserId");
                });
        }
    }
}
