using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            // 1 Ford GT
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "GT",
                    Color = "White",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            // 2 Bugatti Veyron
            new Auction
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Status = Status.Live,
                ReservePrice = 90000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(60),
                Item = new Item
                {
                    Make = "Bugatti",
                    Model = "Veyron",
                    Color = "Black",
                    Mileage = 15035,
                    Year = 2009,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg"
                }
            },
            // 3 Ford mustang
            new Auction
            {
                Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "Mustang",
                    Color = "Black",
                    Mileage = 65125,
                    Year = 2012,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2012/11/02/13/02/car-63930_960_720.jpg"
                }
            },
            // 4 Mercedes SLK
            new Auction
            {
                Id = Guid.Parse("155225c1-4448-4066-9886-6786536e05ea"),
                Status = Status.ReserveNotMet,
                ReservePrice = 50000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(-10),
                Item = new Item
                {
                    Make = "Mercedes",
                    Model = "SLK",
                    Color = "Silver",
                    Mileage = 15001,
                    Year = 2010,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2016/04/17/22/10/mercedes-benz-1335674_960_720.png"
                }
            },
            // 5 BMW X1
            new Auction
            {
                Id = Guid.Parse("466e4744-4dc5-4987-aae0-b621acfc5e39"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Make = "BMW",
                    Model = "X1",
                    Color = "White",
                    Mileage = 90000,
                    Year = 2013,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2017/08/31/05/47/bmw-2699538_960_720.jpg"
                }
            },
            // 6 Ferrari spider
            new Auction
            {
                Id = Guid.Parse("dc1e4071-d19d-459b-b848-b5c3cd3d151f"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(45),
                Item = new Item
                {
                    Make = "Ferrari",
                    Model = "Spider",
                    Color = "Red",
                    Mileage = 50000,
                    Year = 2015,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2017/11/09/01/49/ferrari-458-spider-2932191_960_720.jpg"
                }
            },
            // 7 Ferrari F-430
            new Auction
            {
                Id = Guid.Parse("47111973-d176-4feb-848d-0ea22641c31a"),
                Status = Status.Live,
                ReservePrice = 150000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(13),
                Item = new Item
                {
                    Make = "Ferrari",
                    Model = "F-430",
                    Color = "Red",
                    Mileage = 5000,
                    Year = 2022,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2017/11/08/14/39/ferrari-f430-2930661_960_720.jpg"
                }
            },
            // 8 Audi R8
            new Auction
            {
                Id = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346b289391"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(19),
                Item = new Item
                {
                    Make = "Audi",
                    Model = "R8",
                    Color = "White",
                    Mileage = 10050,
                    Year = 2014,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2019/12/26/20/50/audi-r8-4721217_960_720.jpg"
                }
            },
            // 9 Audi TT
            new Auction
            {
                Id = Guid.Parse("40490065-dac7-46b6-acc4-df507e0d6570"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
                {
                    Make = "Audi",
                    Model = "TT",
                    Color = "Black",
                    Mileage = 25400,
                    Year = 2010,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2016/09/01/15/06/audi-1636320_960_720.jpg"
                }
            },
            // 10 Ford Model T
            new Auction
            {
                Id = Guid.Parse("3659ac24-29dd-407a-81f5-ecfe6f924b9b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(48),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "Model T",
                    Color = "Rust",
                    Mileage = 150150,
                    Year = 1938,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2017/08/02/19/47/vintage-2573090_960_720.jpg"
                }
            },
            // 11 C63
            new Auction
            {
                Id = Guid.Parse("a8328dd6-38d1-4b74-9a5a-09ec4038c97b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Mercedes Benz",
                    Model = "AMG C63s",
                    Color = "White",
                    Mileage = 42100,
                    Year = 2015,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2018/08/05/07/39/mercedes-benz-3585098_1280.jpg"
                }
            },
            // 12 M5
            new Auction
            {
                Id = Guid.Parse("e64fa675-5a59-4219-89d2-df8b94a7bbe3"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "BMW",
                    Model = "M5",
                    Color = "Blue",
                    Mileage = 42100,
                    Year = 2015,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2018/03/22/11/33/auto-3250134_1280.jpg"
                }
            },
            // 13 Mustang
            new Auction
            {
                Id = Guid.Parse("a88dec85-9659-4214-af2c-a73788249ffa"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "Mustang",
                    Color = "Red",
                    Mileage = 42100,
                    Year = 1965,
                    ImageUrl = "https://cdn.pixabay.com/photo/2013/06/15/18/15/car-139529_1280.jpg"
                }
            },
            // 14 918 Spyder
            new Auction
            {
                Id = Guid.Parse("1456a70d-54de-41ad-92b4-38e1df94d64b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Porsche",
                    Model = "918 Spyder",
                    Color = "Silver",
                    Mileage = 42100,
                    Year = 2012,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2017/07/01/18/45/porsche-918-spyder-2462278_1280.jpg"
                }
            },
            // 15 Fiat 500
            new Auction
            {
                Id = Guid.Parse("b8e7b948-1394-4ce8-bf2a-eef4eed8120b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.5),
                Item = new Item
                {
                    Make = "Fiat",
                    Model = "500",
                    Color = "Red",
                    Mileage = 42100,
                    Year = 1969,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2020/06/09/06/39/fiat-5277218_1280.jpg"
                }
            },
            // 16 G63
            new Auction
            {
                Id = Guid.Parse("bc2685ce-25af-4551-8cad-157efed56279"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(2),
                Item = new Item
                {
                    Make = "Mercedes Benz",
                    Model = "AMG G63",
                    Color = "Red",
                    Mileage = 42100,
                    Year = 2017,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2018/05/13/06/47/mercedes-benz-3395531_1280.jpg"
                }
            },
            // 17 A180d
            new Auction
            {
                Id = Guid.Parse("9ac193b8-5b78-495e-a8f9-51433a23b5ab"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Mercedes Benz",
                    Model = "A180d",
                    Color = "Black",
                    Mileage = 42100,
                    Year = 2016,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2020/04/28/10/37/vehicle-5103861_1280.jpg"
                }
            },
            // 18 Tesla Model 3
            new Auction
            {
                Id = Guid.Parse("1098c6ca-80ce-4064-bdab-82e1cdf5224f"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item
                {
                    Make = "Tesla",
                    Model = "Model 3",
                    Color = "Red",
                    Mileage = 42100,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photo/2024/03/02/07/09/car-8607713_1280.jpg"
                }
            },
            // 19 RS6
            new Auction
            {
                Id = Guid.Parse("bc4c82ba-f134-4d53-a0fc-122b6e054aac"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Make = "Audi",
                    Model = "RS6",
                    Color = "Blue",
                    Mileage = 42100,
                    Year = 2017,
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/04/28/13/28/car-3357296_1280.jpg"
                }
            },
            // 20 320d
            new Auction
            {
                Id = Guid.Parse("ec28ad25-0c23-4f76-8a69-2fdf27b7b56e"),
                Status = Status.Live,
                ReservePrice = 30000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item
                {
                    Make = "BMW",
                    Model = "320d",
                    Color = "Light Blue",
                    Mileage = 42100,
                    Year = 2006,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/07/01/07/39/bmw-2460764_1280.jpg"
                }
            },
            // 21 Opel GT
            new Auction
            {
                Id = Guid.Parse("038843c7-674d-45d4-b964-461df75576db"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Opel",
                    Model = "GT",
                    Color = "Red",
                    Mileage = 42100,
                    Year = 1972,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2020/05/19/10/05/opel-5190050_1280.jpg"
                }
            },
            // 22 Bentley Continental GT
            new Auction
            {
                Id = Guid.Parse("cf868654-00e8-4abd-93ef-b62d5cd81faa"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Bentley",
                    Model = "Continental GT",
                    Color = "Aqua Blue",
                    Mileage = 42100,
                    Year = 2014,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2016/11/22/23/55/car-1851299_1280.jpg"
                }
            },
            // 23 500
            new Auction
            {
                Id = Guid.Parse("a30abb4a-be8b-4d2a-a8cb-bd718c7f0858"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Fiat",
                    Model = "500",
                    Color = "Bubblegum Pink",
                    Mileage = 42100,
                    Year = 2012,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2018/04/04/08/04/car-3289114_1280.jpg"
                }
            },
            // 24
            new Auction
            {
                Id = Guid.Parse("9ac8b62e-9acc-4ec0-842b-e5c35236134b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "Porsche",
                    Model = "Panamera",
                    Color = "Gray",
                    Mileage = 42100,
                    Year = 2020,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2019/01/26/16/09/car-3956530_1280.jpg"
                }
            },
            // 25 i8
            new Auction
            {
                Id = Guid.Parse("669f5541-f963-4d10-947d-9fbfa9ed153c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(0.1),
                Item = new Item
                {
                    Make = "BMW",
                    Model = "i8",
                    Color = "Black",
                    Mileage = 42100,
                    Year = 2019,
                    ImageUrl =
                        "https://cdn.pixabay.com/photo/2016/12/11/18/16/bmw-1899973_1280.jpg"
                }
            },
        };

        context.AddRange(auctions);

        context.SaveChanges();
    }
}
