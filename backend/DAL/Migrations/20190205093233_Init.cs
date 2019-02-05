using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarUrl", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "https://s3.amazonaws.com/uifaces/faces/twitter/gregrwilkinson/128.jpg", "Moises.Effertz19@gmail.com", "Moises", "Effertz" },
                    { 28, "https://s3.amazonaws.com/uifaces/faces/twitter/ismail_biltagi/128.jpg", "Marie_Bogan@yahoo.com", "Marie", "Bogan" },
                    { 29, "https://s3.amazonaws.com/uifaces/faces/twitter/g3d/128.jpg", "Chyna.Crist@gmail.com", "Chyna", "Crist" },
                    { 30, "https://s3.amazonaws.com/uifaces/faces/twitter/weglov/128.jpg", "Linnea_McLaughlin10@gmail.com", "Linnea", "McLaughlin" },
                    { 31, "https://s3.amazonaws.com/uifaces/faces/twitter/lewisainslie/128.jpg", "Elva_Howe4@hotmail.com", "Elva", "Howe" },
                    { 32, "https://s3.amazonaws.com/uifaces/faces/twitter/duivvv/128.jpg", "Idell54@hotmail.com", "Idell", "Collier" },
                    { 33, "https://s3.amazonaws.com/uifaces/faces/twitter/dgclegg/128.jpg", "Adrian_Leuschke@hotmail.com", "Adrian", "Leuschke" },
                    { 34, "https://s3.amazonaws.com/uifaces/faces/twitter/dzantievm/128.jpg", "Eliseo.Franecki91@gmail.com", "Eliseo", "Franecki" },
                    { 35, "https://s3.amazonaws.com/uifaces/faces/twitter/alan_zhang_/128.jpg", "Jermey_Robel65@hotmail.com", "Jermey", "Robel" },
                    { 36, "https://s3.amazonaws.com/uifaces/faces/twitter/lososina/128.jpg", "Joe.Carter76@gmail.com", "Joe", "Carter" },
                    { 37, "https://s3.amazonaws.com/uifaces/faces/twitter/moscoz/128.jpg", "Keshawn4@gmail.com", "Keshawn", "Gusikowski" },
                    { 38, "https://s3.amazonaws.com/uifaces/faces/twitter/ludwiczakpawel/128.jpg", "Cortez_Conn@gmail.com", "Cortez", "Conn" },
                    { 39, "https://s3.amazonaws.com/uifaces/faces/twitter/helderleal/128.jpg", "Liza53@hotmail.com", "Liza", "Schmidt" },
                    { 40, "https://s3.amazonaws.com/uifaces/faces/twitter/xadhix/128.jpg", "Agustin_Harber@yahoo.com", "Agustin", "Harber" },
                    { 41, "https://s3.amazonaws.com/uifaces/faces/twitter/logorado/128.jpg", "Braden_Morissette39@yahoo.com", "Braden", "Morissette" },
                    { 42, "https://s3.amazonaws.com/uifaces/faces/twitter/_kkga/128.jpg", "Gage_Veum24@yahoo.com", "Gage", "Veum" },
                    { 43, "https://s3.amazonaws.com/uifaces/faces/twitter/sharvin/128.jpg", "Genoveva_Ullrich@yahoo.com", "Genoveva", "Ullrich" },
                    { 44, "https://s3.amazonaws.com/uifaces/faces/twitter/tjrus/128.jpg", "Vincent72@gmail.com", "Vincent", "Labadie" },
                    { 45, "https://s3.amazonaws.com/uifaces/faces/twitter/aaronalfred/128.jpg", "Lavonne_Haag@gmail.com", "Lavonne", "Haag" },
                    { 46, "https://s3.amazonaws.com/uifaces/faces/twitter/itstotallyamy/128.jpg", "Madelyn.Monahan@gmail.com", "Madelyn", "Monahan" },
                    { 47, "https://s3.amazonaws.com/uifaces/faces/twitter/mds/128.jpg", "Deion.Pollich@yahoo.com", "Deion", "Pollich" },
                    { 48, "https://s3.amazonaws.com/uifaces/faces/twitter/VMilescu/128.jpg", "Annette.Skiles10@hotmail.com", "Annette", "Skiles" },
                    { 27, "https://s3.amazonaws.com/uifaces/faces/twitter/carlfairclough/128.jpg", "Lurline.Dickens@gmail.com", "Lurline", "Dickens" },
                    { 26, "https://s3.amazonaws.com/uifaces/faces/twitter/emmandenn/128.jpg", "Jaleel.Bahringer@yahoo.com", "Jaleel", "Bahringer" },
                    { 25, "https://s3.amazonaws.com/uifaces/faces/twitter/el_fuertisimo/128.jpg", "Emory.Harris0@gmail.com", "Emory", "Harris" },
                    { 24, "https://s3.amazonaws.com/uifaces/faces/twitter/ssbb_me/128.jpg", "Lonny61@yahoo.com", "Lonny", "Schimmel" },
                    { 2, "https://s3.amazonaws.com/uifaces/faces/twitter/djsherman/128.jpg", "Jevon.Ziemann18@gmail.com", "Jevon", "Ziemann" },
                    { 3, "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg", "Annabell_Purdy@yahoo.com", "Annabell", "Purdy" },
                    { 4, "https://s3.amazonaws.com/uifaces/faces/twitter/danmartin70/128.jpg", "Reed_Fisher@gmail.com", "Reed", "Fisher" },
                    { 5, "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg", "Marlin14@yahoo.com", "Marlin", "Block" },
                    { 6, "https://s3.amazonaws.com/uifaces/faces/twitter/kevinjohndayy/128.jpg", "Freddy.Torphy@gmail.com", "Freddy", "Torphy" },
                    { 7, "https://s3.amazonaws.com/uifaces/faces/twitter/kolsvein/128.jpg", "Gretchen_Mitchell@yahoo.com", "Gretchen", "Mitchell" },
                    { 8, "https://s3.amazonaws.com/uifaces/faces/twitter/kostaspt/128.jpg", "Tyler_Rau@hotmail.com", "Tyler", "Rau" },
                    { 9, "https://s3.amazonaws.com/uifaces/faces/twitter/llun/128.jpg", "Megane.Rempel48@hotmail.com", "Megane", "Rempel" },
                    { 10, "https://s3.amazonaws.com/uifaces/faces/twitter/9lessons/128.jpg", "Ona_Wintheiser@yahoo.com", "Ona", "Wintheiser" },
                    { 11, "https://s3.amazonaws.com/uifaces/faces/twitter/ruzinav/128.jpg", "Nash29@gmail.com", "Nash", "Wuckert" },
                    { 49, "https://s3.amazonaws.com/uifaces/faces/twitter/okandungel/128.jpg", "Cleve_Rippin@yahoo.com", "Cleve", "Rippin" },
                    { 12, "https://s3.amazonaws.com/uifaces/faces/twitter/baires/128.jpg", "Lenna96@yahoo.com", "Lenna", "Gislason" },
                    { 14, "https://s3.amazonaws.com/uifaces/faces/twitter/doronmalki/128.jpg", "Alfredo.Dibbert@hotmail.com", "Alfredo", "Dibbert" },
                    { 15, "https://s3.amazonaws.com/uifaces/faces/twitter/woodydotmx/128.jpg", "German_Larson@hotmail.com", "German", "Larson" },
                    { 16, "https://s3.amazonaws.com/uifaces/faces/twitter/hugocornejo/128.jpg", "Toni.Bosco@hotmail.com", "Toni", "Bosco" },
                    { 17, "https://s3.amazonaws.com/uifaces/faces/twitter/nateschulte/128.jpg", "Nigel.Orn@yahoo.com", "Nigel", "Orn" },
                    { 18, "https://s3.amazonaws.com/uifaces/faces/twitter/bergmartin/128.jpg", "Amaya.McLaughlin18@hotmail.com", "Amaya", "McLaughlin" },
                    { 19, "https://s3.amazonaws.com/uifaces/faces/twitter/badlittleduck/128.jpg", "Dan_Vandervort@gmail.com", "Dan", "Vandervort" },
                    { 20, "https://s3.amazonaws.com/uifaces/faces/twitter/jesseddy/128.jpg", "Cleveland_Mann@gmail.com", "Cleveland", "Mann" },
                    { 21, "https://s3.amazonaws.com/uifaces/faces/twitter/abotap/128.jpg", "Diamond87@hotmail.com", "Diamond", "Mertz" },
                    { 22, "https://s3.amazonaws.com/uifaces/faces/twitter/fabbianz/128.jpg", "Samir.Brakus63@gmail.com", "Samir", "Brakus" },
                    { 23, "https://s3.amazonaws.com/uifaces/faces/twitter/oksanafrewer/128.jpg", "Steve.Powlowski50@yahoo.com", "Steve", "Powlowski" },
                    { 13, "https://s3.amazonaws.com/uifaces/faces/twitter/rickdt/128.jpg", "Emely.Gusikowski@yahoo.com", "Emely", "Gusikowski" },
                    { 50, "https://s3.amazonaws.com/uifaces/faces/twitter/chrisstumph/128.jpg", "Georgiana_Balistreri23@hotmail.com", "Georgiana", "Balistreri" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Product", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 22, "Watermelon", 1, 1 },
                    { 21, "Banana", 5, 23 },
                    { 12, "Grape", 4, 26 },
                    { 41, "Banana", 6, 26 },
                    { 37, "Grape", 7, 27 },
                    { 47, "Orange", 8, 27 },
                    { 23, "Orange", 4, 28 },
                    { 49, "Grape", 10, 28 },
                    { 36, "Apple", 2, 29 },
                    { 4, "Kiwi", 7, 31 },
                    { 6, "Kiwi", 4, 31 },
                    { 13, "Orange", 2, 31 },
                    { 31, "Lemon", 5, 32 },
                    { 39, "Grape", 10, 32 },
                    { 16, "Kiwi", 5, 33 },
                    { 26, "Lemon", 6, 34 },
                    { 33, "Watermelon", 5, 36 },
                    { 35, "Banana", 7, 40 },
                    { 9, "Banana", 6, 42 },
                    { 20, "Banana", 6, 42 },
                    { 15, "Banana", 8, 43 },
                    { 45, "Kiwi", 5, 44 },
                    { 17, "Apple", 2, 23 },
                    { 10, "Banana", 5, 23 },
                    { 7, "Apple", 1, 23 },
                    { 25, "Banana", 1, 20 },
                    { 29, "Banana", 8, 1 },
                    { 43, "Watermelon", 3, 3 },
                    { 50, "Lemon", 1, 5 },
                    { 3, "Orange", 9, 6 },
                    { 5, "Apple", 10, 6 },
                    { 14, "Banana", 7, 6 },
                    { 19, "Banana", 1, 6 },
                    { 27, "Lemon", 3, 6 },
                    { 34, "Grape", 4, 6 },
                    { 44, "Apple", 7, 6 },
                    { 2, "Watermelon", 4, 48 },
                    { 11, "Kiwi", 7, 7 },
                    { 8, "Watermelon", 5, 8 },
                    { 48, "Orange", 2, 8 },
                    { 18, "Apple", 7, 11 },
                    { 24, "Watermelon", 4, 11 },
                    { 32, "Grape", 1, 12 },
                    { 38, "Orange", 9, 13 },
                    { 1, "Watermelon", 6, 15 },
                    { 28, "Apple", 8, 15 },
                    { 30, "Kiwi", 9, 16 },
                    { 40, "Apple", 7, 19 },
                    { 46, "Banana", 1, 7 },
                    { 42, "Apple", 2, 48 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
