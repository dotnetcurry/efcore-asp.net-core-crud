using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi_With_EFCore.Models;

namespace WebApi_With_EFCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi_With_EFCore.Models.Book", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Genre");

                    b.Property<int>("Price");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Books");
                });
        }
    }
}
