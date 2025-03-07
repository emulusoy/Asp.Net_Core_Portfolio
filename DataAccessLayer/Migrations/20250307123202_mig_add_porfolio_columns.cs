using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_porfolio_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PortfolioFee",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImg1",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImg2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImg3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioImg4",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioPlatform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PortfolioStatus",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PortfolioValue",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfolioFee",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImg1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImg2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImg3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioImg4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioPlatform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioStatus",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioValue",
                table: "Portfolios");
        }
    }
}
