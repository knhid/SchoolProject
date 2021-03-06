﻿// <auto-generated />
using LoginAndBoard.UserControl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginAndBoard.Migrations
{
    [DbContext(typeof(UserAccount))]
    partial class UserAccountModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("LoginAndBoard.UserControl.Join", b =>
                {
                    b.Property<string>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPW")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("JoinUser");
                });

            modelBuilder.Entity("LoginAndBoard.UserControl.Login", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserID")
                        .IsRequired();

                    b.Property<string>("UserName");

                    b.Property<string>("UserPW")
                        .IsRequired();

                    b.HasKey("UserNo");

                    b.ToTable("LoginUser");
                });
#pragma warning restore 612, 618
        }
    }
}
