// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BlackCoderTestVehicleTracker.Models;

namespace BlackCoderTestVehicleTracker.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlackCoderTestVehicleTracker.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleRegNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("BlackCoderTestVehicleTracker.Models.VehicleTrackingInfo", b =>
                {
                    b.Property<int>("VehicleTrackingInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longtitude")
                        .HasColumnType("real");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("VehicleTrackingInfoId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleTrackingInfos");
                });

            modelBuilder.Entity("BlackCoderTestVehicleTracker.Models.VehicleTrackingInfo", b =>
                {
                    b.HasOne("BlackCoderTestVehicleTracker.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleTrackingInfo")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
