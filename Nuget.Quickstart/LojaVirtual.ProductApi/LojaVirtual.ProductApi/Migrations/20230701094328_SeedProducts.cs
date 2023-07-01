using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaVirtual.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        //Insert Products on Table Product
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Price,Description,Stock,ImageUrl,CategoryId) " +
                "Values('Caderno' ,7.55, 'Caderno' ,10, 'caderno1.jpg' ,1)");
            
            mb.Sql("INSERT INTO Products(Name,Price,Description,Stock,ImageUrl,CategoryId) " +
                "Values('Lápis' ,3.45, 'Lápis' ,20, 'lapis1.jpg' ,1)");

            mb.Sql("INSERT INTO Products(Name,Price,Description,Stock,ImageUrl,CategoryId) " +
                "Values('Clips' ,5.33, 'Clips' ,50, 'clips1.jpg' ,2)");
        }

        /// <inheritdoc />
        //Remove case fail
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
