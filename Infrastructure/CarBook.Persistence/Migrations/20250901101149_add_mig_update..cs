using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_mig_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // PickUpDate'i time(7)'den date'e değiştir
            migrationBuilder.AlterColumn<DateTime>(
                name: "PickUpDate",
                table: "RentACarProcesses", // Tablo adını buraya yaz
                type: "date",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(7)");

            // DropOffDate'i time(7)'den date'e değiştir
            migrationBuilder.AlterColumn<DateTime>(
                name: "DropOffDate",
                table: "RentACarProcesses", // Tablo adını buraya yaz
                type: "date",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(7)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Geri alma işlemleri - eski haline döndür
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "PickUpDate",
                table: "RentACarProcess", // Tablo adını buraya yaz
                type: "time(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "DropOffDate",
                table: "RentACarProcess", // Tablo adını buraya yaz
                type: "time(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}