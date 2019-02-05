﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(UserDBContext))]
    partial class UserDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product");

                    b.Property<int>("Quantity");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Product = "Watermelon",
                            Quantity = 6,
                            UserId = 15
                        },
                        new
                        {
                            Id = 2,
                            Product = "Watermelon",
                            Quantity = 4,
                            UserId = 48
                        },
                        new
                        {
                            Id = 3,
                            Product = "Orange",
                            Quantity = 9,
                            UserId = 6
                        },
                        new
                        {
                            Id = 4,
                            Product = "Kiwi",
                            Quantity = 7,
                            UserId = 31
                        },
                        new
                        {
                            Id = 5,
                            Product = "Apple",
                            Quantity = 10,
                            UserId = 6
                        },
                        new
                        {
                            Id = 6,
                            Product = "Kiwi",
                            Quantity = 4,
                            UserId = 31
                        },
                        new
                        {
                            Id = 7,
                            Product = "Apple",
                            Quantity = 1,
                            UserId = 23
                        },
                        new
                        {
                            Id = 8,
                            Product = "Watermelon",
                            Quantity = 5,
                            UserId = 8
                        },
                        new
                        {
                            Id = 9,
                            Product = "Banana",
                            Quantity = 6,
                            UserId = 42
                        },
                        new
                        {
                            Id = 10,
                            Product = "Banana",
                            Quantity = 5,
                            UserId = 23
                        },
                        new
                        {
                            Id = 11,
                            Product = "Kiwi",
                            Quantity = 7,
                            UserId = 7
                        },
                        new
                        {
                            Id = 12,
                            Product = "Grape",
                            Quantity = 4,
                            UserId = 26
                        },
                        new
                        {
                            Id = 13,
                            Product = "Orange",
                            Quantity = 2,
                            UserId = 31
                        },
                        new
                        {
                            Id = 14,
                            Product = "Banana",
                            Quantity = 7,
                            UserId = 6
                        },
                        new
                        {
                            Id = 15,
                            Product = "Banana",
                            Quantity = 8,
                            UserId = 43
                        },
                        new
                        {
                            Id = 16,
                            Product = "Kiwi",
                            Quantity = 5,
                            UserId = 33
                        },
                        new
                        {
                            Id = 17,
                            Product = "Apple",
                            Quantity = 2,
                            UserId = 23
                        },
                        new
                        {
                            Id = 18,
                            Product = "Apple",
                            Quantity = 7,
                            UserId = 11
                        },
                        new
                        {
                            Id = 19,
                            Product = "Banana",
                            Quantity = 1,
                            UserId = 6
                        },
                        new
                        {
                            Id = 20,
                            Product = "Banana",
                            Quantity = 6,
                            UserId = 42
                        },
                        new
                        {
                            Id = 21,
                            Product = "Banana",
                            Quantity = 5,
                            UserId = 23
                        },
                        new
                        {
                            Id = 22,
                            Product = "Watermelon",
                            Quantity = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 23,
                            Product = "Orange",
                            Quantity = 4,
                            UserId = 28
                        },
                        new
                        {
                            Id = 24,
                            Product = "Watermelon",
                            Quantity = 4,
                            UserId = 11
                        },
                        new
                        {
                            Id = 25,
                            Product = "Banana",
                            Quantity = 1,
                            UserId = 20
                        },
                        new
                        {
                            Id = 26,
                            Product = "Lemon",
                            Quantity = 6,
                            UserId = 34
                        },
                        new
                        {
                            Id = 27,
                            Product = "Lemon",
                            Quantity = 3,
                            UserId = 6
                        },
                        new
                        {
                            Id = 28,
                            Product = "Apple",
                            Quantity = 8,
                            UserId = 15
                        },
                        new
                        {
                            Id = 29,
                            Product = "Banana",
                            Quantity = 8,
                            UserId = 1
                        },
                        new
                        {
                            Id = 30,
                            Product = "Kiwi",
                            Quantity = 9,
                            UserId = 16
                        },
                        new
                        {
                            Id = 31,
                            Product = "Lemon",
                            Quantity = 5,
                            UserId = 32
                        },
                        new
                        {
                            Id = 32,
                            Product = "Grape",
                            Quantity = 1,
                            UserId = 12
                        },
                        new
                        {
                            Id = 33,
                            Product = "Watermelon",
                            Quantity = 5,
                            UserId = 36
                        },
                        new
                        {
                            Id = 34,
                            Product = "Grape",
                            Quantity = 4,
                            UserId = 6
                        },
                        new
                        {
                            Id = 35,
                            Product = "Banana",
                            Quantity = 7,
                            UserId = 40
                        },
                        new
                        {
                            Id = 36,
                            Product = "Apple",
                            Quantity = 2,
                            UserId = 29
                        },
                        new
                        {
                            Id = 37,
                            Product = "Grape",
                            Quantity = 7,
                            UserId = 27
                        },
                        new
                        {
                            Id = 38,
                            Product = "Orange",
                            Quantity = 9,
                            UserId = 13
                        },
                        new
                        {
                            Id = 39,
                            Product = "Grape",
                            Quantity = 10,
                            UserId = 32
                        },
                        new
                        {
                            Id = 40,
                            Product = "Apple",
                            Quantity = 7,
                            UserId = 19
                        },
                        new
                        {
                            Id = 41,
                            Product = "Banana",
                            Quantity = 6,
                            UserId = 26
                        },
                        new
                        {
                            Id = 42,
                            Product = "Apple",
                            Quantity = 2,
                            UserId = 48
                        },
                        new
                        {
                            Id = 43,
                            Product = "Watermelon",
                            Quantity = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 44,
                            Product = "Apple",
                            Quantity = 7,
                            UserId = 6
                        },
                        new
                        {
                            Id = 45,
                            Product = "Kiwi",
                            Quantity = 5,
                            UserId = 44
                        },
                        new
                        {
                            Id = 46,
                            Product = "Banana",
                            Quantity = 1,
                            UserId = 7
                        },
                        new
                        {
                            Id = 47,
                            Product = "Orange",
                            Quantity = 8,
                            UserId = 27
                        },
                        new
                        {
                            Id = 48,
                            Product = "Orange",
                            Quantity = 2,
                            UserId = 8
                        },
                        new
                        {
                            Id = 49,
                            Product = "Grape",
                            Quantity = 10,
                            UserId = 28
                        },
                        new
                        {
                            Id = 50,
                            Product = "Lemon",
                            Quantity = 1,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarUrl");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/gregrwilkinson/128.jpg",
                            Email = "Moises.Effertz19@gmail.com",
                            FirstName = "Moises",
                            LastName = "Effertz"
                        },
                        new
                        {
                            Id = 2,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/djsherman/128.jpg",
                            Email = "Jevon.Ziemann18@gmail.com",
                            FirstName = "Jevon",
                            LastName = "Ziemann"
                        },
                        new
                        {
                            Id = 3,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg",
                            Email = "Annabell_Purdy@yahoo.com",
                            FirstName = "Annabell",
                            LastName = "Purdy"
                        },
                        new
                        {
                            Id = 4,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/danmartin70/128.jpg",
                            Email = "Reed_Fisher@gmail.com",
                            FirstName = "Reed",
                            LastName = "Fisher"
                        },
                        new
                        {
                            Id = 5,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg",
                            Email = "Marlin14@yahoo.com",
                            FirstName = "Marlin",
                            LastName = "Block"
                        },
                        new
                        {
                            Id = 6,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/kevinjohndayy/128.jpg",
                            Email = "Freddy.Torphy@gmail.com",
                            FirstName = "Freddy",
                            LastName = "Torphy"
                        },
                        new
                        {
                            Id = 7,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/kolsvein/128.jpg",
                            Email = "Gretchen_Mitchell@yahoo.com",
                            FirstName = "Gretchen",
                            LastName = "Mitchell"
                        },
                        new
                        {
                            Id = 8,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/kostaspt/128.jpg",
                            Email = "Tyler_Rau@hotmail.com",
                            FirstName = "Tyler",
                            LastName = "Rau"
                        },
                        new
                        {
                            Id = 9,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/llun/128.jpg",
                            Email = "Megane.Rempel48@hotmail.com",
                            FirstName = "Megane",
                            LastName = "Rempel"
                        },
                        new
                        {
                            Id = 10,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/9lessons/128.jpg",
                            Email = "Ona_Wintheiser@yahoo.com",
                            FirstName = "Ona",
                            LastName = "Wintheiser"
                        },
                        new
                        {
                            Id = 11,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/ruzinav/128.jpg",
                            Email = "Nash29@gmail.com",
                            FirstName = "Nash",
                            LastName = "Wuckert"
                        },
                        new
                        {
                            Id = 12,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/baires/128.jpg",
                            Email = "Lenna96@yahoo.com",
                            FirstName = "Lenna",
                            LastName = "Gislason"
                        },
                        new
                        {
                            Id = 13,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/rickdt/128.jpg",
                            Email = "Emely.Gusikowski@yahoo.com",
                            FirstName = "Emely",
                            LastName = "Gusikowski"
                        },
                        new
                        {
                            Id = 14,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/doronmalki/128.jpg",
                            Email = "Alfredo.Dibbert@hotmail.com",
                            FirstName = "Alfredo",
                            LastName = "Dibbert"
                        },
                        new
                        {
                            Id = 15,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/woodydotmx/128.jpg",
                            Email = "German_Larson@hotmail.com",
                            FirstName = "German",
                            LastName = "Larson"
                        },
                        new
                        {
                            Id = 16,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/hugocornejo/128.jpg",
                            Email = "Toni.Bosco@hotmail.com",
                            FirstName = "Toni",
                            LastName = "Bosco"
                        },
                        new
                        {
                            Id = 17,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/nateschulte/128.jpg",
                            Email = "Nigel.Orn@yahoo.com",
                            FirstName = "Nigel",
                            LastName = "Orn"
                        },
                        new
                        {
                            Id = 18,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/bergmartin/128.jpg",
                            Email = "Amaya.McLaughlin18@hotmail.com",
                            FirstName = "Amaya",
                            LastName = "McLaughlin"
                        },
                        new
                        {
                            Id = 19,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/badlittleduck/128.jpg",
                            Email = "Dan_Vandervort@gmail.com",
                            FirstName = "Dan",
                            LastName = "Vandervort"
                        },
                        new
                        {
                            Id = 20,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/jesseddy/128.jpg",
                            Email = "Cleveland_Mann@gmail.com",
                            FirstName = "Cleveland",
                            LastName = "Mann"
                        },
                        new
                        {
                            Id = 21,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/abotap/128.jpg",
                            Email = "Diamond87@hotmail.com",
                            FirstName = "Diamond",
                            LastName = "Mertz"
                        },
                        new
                        {
                            Id = 22,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/fabbianz/128.jpg",
                            Email = "Samir.Brakus63@gmail.com",
                            FirstName = "Samir",
                            LastName = "Brakus"
                        },
                        new
                        {
                            Id = 23,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/oksanafrewer/128.jpg",
                            Email = "Steve.Powlowski50@yahoo.com",
                            FirstName = "Steve",
                            LastName = "Powlowski"
                        },
                        new
                        {
                            Id = 24,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/ssbb_me/128.jpg",
                            Email = "Lonny61@yahoo.com",
                            FirstName = "Lonny",
                            LastName = "Schimmel"
                        },
                        new
                        {
                            Id = 25,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/el_fuertisimo/128.jpg",
                            Email = "Emory.Harris0@gmail.com",
                            FirstName = "Emory",
                            LastName = "Harris"
                        },
                        new
                        {
                            Id = 26,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/emmandenn/128.jpg",
                            Email = "Jaleel.Bahringer@yahoo.com",
                            FirstName = "Jaleel",
                            LastName = "Bahringer"
                        },
                        new
                        {
                            Id = 27,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/carlfairclough/128.jpg",
                            Email = "Lurline.Dickens@gmail.com",
                            FirstName = "Lurline",
                            LastName = "Dickens"
                        },
                        new
                        {
                            Id = 28,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/ismail_biltagi/128.jpg",
                            Email = "Marie_Bogan@yahoo.com",
                            FirstName = "Marie",
                            LastName = "Bogan"
                        },
                        new
                        {
                            Id = 29,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/g3d/128.jpg",
                            Email = "Chyna.Crist@gmail.com",
                            FirstName = "Chyna",
                            LastName = "Crist"
                        },
                        new
                        {
                            Id = 30,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/weglov/128.jpg",
                            Email = "Linnea_McLaughlin10@gmail.com",
                            FirstName = "Linnea",
                            LastName = "McLaughlin"
                        },
                        new
                        {
                            Id = 31,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/lewisainslie/128.jpg",
                            Email = "Elva_Howe4@hotmail.com",
                            FirstName = "Elva",
                            LastName = "Howe"
                        },
                        new
                        {
                            Id = 32,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/duivvv/128.jpg",
                            Email = "Idell54@hotmail.com",
                            FirstName = "Idell",
                            LastName = "Collier"
                        },
                        new
                        {
                            Id = 33,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/dgclegg/128.jpg",
                            Email = "Adrian_Leuschke@hotmail.com",
                            FirstName = "Adrian",
                            LastName = "Leuschke"
                        },
                        new
                        {
                            Id = 34,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/dzantievm/128.jpg",
                            Email = "Eliseo.Franecki91@gmail.com",
                            FirstName = "Eliseo",
                            LastName = "Franecki"
                        },
                        new
                        {
                            Id = 35,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/alan_zhang_/128.jpg",
                            Email = "Jermey_Robel65@hotmail.com",
                            FirstName = "Jermey",
                            LastName = "Robel"
                        },
                        new
                        {
                            Id = 36,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/lososina/128.jpg",
                            Email = "Joe.Carter76@gmail.com",
                            FirstName = "Joe",
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = 37,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/moscoz/128.jpg",
                            Email = "Keshawn4@gmail.com",
                            FirstName = "Keshawn",
                            LastName = "Gusikowski"
                        },
                        new
                        {
                            Id = 38,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/ludwiczakpawel/128.jpg",
                            Email = "Cortez_Conn@gmail.com",
                            FirstName = "Cortez",
                            LastName = "Conn"
                        },
                        new
                        {
                            Id = 39,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/helderleal/128.jpg",
                            Email = "Liza53@hotmail.com",
                            FirstName = "Liza",
                            LastName = "Schmidt"
                        },
                        new
                        {
                            Id = 40,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/xadhix/128.jpg",
                            Email = "Agustin_Harber@yahoo.com",
                            FirstName = "Agustin",
                            LastName = "Harber"
                        },
                        new
                        {
                            Id = 41,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/logorado/128.jpg",
                            Email = "Braden_Morissette39@yahoo.com",
                            FirstName = "Braden",
                            LastName = "Morissette"
                        },
                        new
                        {
                            Id = 42,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/_kkga/128.jpg",
                            Email = "Gage_Veum24@yahoo.com",
                            FirstName = "Gage",
                            LastName = "Veum"
                        },
                        new
                        {
                            Id = 43,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/sharvin/128.jpg",
                            Email = "Genoveva_Ullrich@yahoo.com",
                            FirstName = "Genoveva",
                            LastName = "Ullrich"
                        },
                        new
                        {
                            Id = 44,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/tjrus/128.jpg",
                            Email = "Vincent72@gmail.com",
                            FirstName = "Vincent",
                            LastName = "Labadie"
                        },
                        new
                        {
                            Id = 45,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/aaronalfred/128.jpg",
                            Email = "Lavonne_Haag@gmail.com",
                            FirstName = "Lavonne",
                            LastName = "Haag"
                        },
                        new
                        {
                            Id = 46,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/itstotallyamy/128.jpg",
                            Email = "Madelyn.Monahan@gmail.com",
                            FirstName = "Madelyn",
                            LastName = "Monahan"
                        },
                        new
                        {
                            Id = 47,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/mds/128.jpg",
                            Email = "Deion.Pollich@yahoo.com",
                            FirstName = "Deion",
                            LastName = "Pollich"
                        },
                        new
                        {
                            Id = 48,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/VMilescu/128.jpg",
                            Email = "Annette.Skiles10@hotmail.com",
                            FirstName = "Annette",
                            LastName = "Skiles"
                        },
                        new
                        {
                            Id = 49,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/okandungel/128.jpg",
                            Email = "Cleve_Rippin@yahoo.com",
                            FirstName = "Cleve",
                            LastName = "Rippin"
                        },
                        new
                        {
                            Id = 50,
                            AvatarUrl = "https://s3.amazonaws.com/uifaces/faces/twitter/chrisstumph/128.jpg",
                            Email = "Georgiana_Balistreri23@hotmail.com",
                            FirstName = "Georgiana",
                            LastName = "Balistreri"
                        });
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
