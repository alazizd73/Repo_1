using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Groep9_SE7.Migrations
{
    public partial class kids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonus",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(nullable: false),
                    Bonus_date = table.Column<DateTime>(nullable: false),
                    Bonus_amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus", x => new { x.Emp_ID, x.Bonus_date, x.Bonus_amount });
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Address_1 = table.Column<string>(nullable: true),
                    Address_2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<int>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Zip_Code = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Company_Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Big_small = table.Column<string>(nullable: true),
                    Max_Quantity_Order = table.Column<int>(nullable: true),
                    Discount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip_Code = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Ss_Number = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    Start_Date = table.Column<DateTime>(nullable: false),
                    Termination_Date = table.Column<DateTime>(nullable: true),
                    Birth_Date = table.Column<DateTime>(nullable: true),
                    Bene_health_ins = table.Column<string>(nullable: true),
                    Bene_life_ins = table.Column<string>(nullable: true),
                    Bene_day_care = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    TargetMissed = table.Column<string>(nullable: true),
                    Manager = table.Column<int>(nullable: true),
                    Job_ID = table.Column<int>(nullable: true),
                    Dept_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Excursion",
                columns: table => new
                {
                    Exc_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excursion", x => x.Exc_ID);
                });

            migrationBuilder.CreateTable(
                name: "Excursion_planned",
                columns: table => new
                {
                    Excursion = table.Column<int>(nullable: false),
                    Travel_planned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excursion_planned", x => new { x.Excursion, x.Travel_planned });
                });

            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    Order_detail_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Order_number = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Unit_cost = table.Column<decimal>(nullable: true),
                    Unit_price = table.Column<decimal>(nullable: true),
                    Unit_sale_price = table.Column<decimal>(nullable: true),
                    Ship_date = table.Column<DateTime>(nullable: false),
                    Prod_ID = table.Column<int>(nullable: false),
                    Dept_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => x.Order_detail_code);
                });

            migrationBuilder.CreateTable(
                name: "Order_Header",
                columns: table => new
                {
                    Order_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Order_date = table.Column<DateTime>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    Emp_ID = table.Column<int>(nullable: false),
                    Dept_ID = table.Column<int>(nullable: true),
                    Cust_ID = table.Column<int>(nullable: false),
                    Order_method = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Header", x => x.Order_number);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Emp_ID = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Course = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Travel_planned",
                columns: table => new
                {
                    Travel_plan_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date_start = table.Column<DateTime>(nullable: false),
                    Date_end = table.Column<DateTime>(nullable: false),
                    Travel_product = table.Column<int>(nullable: false),
                    Customer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel_planned", x => x.Travel_plan_ID);
                });

            migrationBuilder.CreateTable(
                name: "Travel_product",
                columns: table => new
                {
                    Trav_prod_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Length = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Min_capacity = table.Column<int>(nullable: false),
                    Max_capacity = table.Column<int>(nullable: false),
                    Kids_Allowed = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel_product", x => x.Trav_prod_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Excursion");

            migrationBuilder.DropTable(
                name: "Excursion_planned");

            migrationBuilder.DropTable(
                name: "Order_Details");

            migrationBuilder.DropTable(
                name: "Order_Header");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Travel_planned");

            migrationBuilder.DropTable(
                name: "Travel_product");
        }
    }
}
