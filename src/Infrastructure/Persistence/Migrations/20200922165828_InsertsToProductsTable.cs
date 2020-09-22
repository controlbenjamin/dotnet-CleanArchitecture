using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ca.Infrastructure.Persistence.Migrations
{
    public partial class InsertsToProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Contactor', 15, GETDATE() - 1)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Interruptor', 77, GETDATE() - 77)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Bombilla', 45, GETDATE() - 16)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Cinta Aisladora', 345, GETDATE() - 236)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Cable Subterraneo x 100m', 22, GETDATE() - 453)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Tester', 33, GETDATE() - 28)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Bateria 9V', 211, GETDATE() - 777)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Gabinete', 80, GETDATE() - 236)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Alarma', 40, GETDATE() - 499)");
            migrationBuilder.Sql("INSERT INTO Products(Description, Stock, LastModified) VALUES('Timbre', 87, GETDATE() - 10)");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
