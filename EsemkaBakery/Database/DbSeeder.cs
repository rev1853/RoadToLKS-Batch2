namespace EsemkaBakery.Database
{
    public class DbSeeder
    {
        public static void SeedData(EsemkaBakeryContext context)
        {
            // Check if the database is already seeded
            if (context.Users.Any() || context.Cakes.Any() || context.PromoCodes.Any())
            {
                Console.WriteLine("Database already seeded. Skipping seed operation.");
                return;
            }

            // Seed Users
            var users = new[]
            {
                new User { Username = "john_doe", Password = "password", Email = "john@example.com", FirstName = "John", LastName = "Doe" },
                new User { Username = "jane_doe", Password = "password", Email = "jane@example.com", FirstName = "Jane", LastName = "Doe" },
            };
            context.Users.AddRange(users);

            var cakes = new[]
            {
                new Cake { Name = "Mini Pound Cake", Description = "Make any moment a little sweeter with the delicious taste of Entenmann's Baker's Delights Mini Pound Cakes. With a rich and buttery texture, these pound cake snacks have a homemade taste everyone will love. Entenmann’s Baker's Delights Mini Pound Cakes are the perfect size for satisfying your sweet tooth without overindulging and are individually wrapped, making them great lunch snacks and on the go snacks. Entenmann’s baked goods are always made with care and quality ingredients for a delicious taste you can count on whether you enjoy them as a breakfast food, a midday snack or for dessert. These snack cakes are kosher, allowing everyone to enjoy a spontaneous sprinkle of delight whenever they need one. Entenmann’s cakes, coffee cakes, donuts and pastries help families celebrate special occasions and the everyday with heritage baked goods.", Price = 4.39m, ImageURL = "https://i.ibb.co/9hwHyLR/img1.png" },
                new Cake { Name = "Single Serve Pound Cakes", Description = "Big, rich, buttery flavor in a convenient on-the go size, this is the classic Entenmann’s Buttery Pound Cake turned miniature! Each package contains 2 cakes that carry the same delectably dense texture and great taste that has made this cake a family-favorite for years!\r\n\r\nSince 1898, the Entenmann’s name has stood for moist and delicious baked goods. Over the years, families have made it part of their everyday lives and special occasions. It’s a tradition of quality that is found in every Entenmann’s product baked with care every day. Grab some for your next party, sporting event or snack!", Price = 5.79m, ImageURL = "https://i.ibb.co/Bt7nDtJ/img2.png" },
                new Cake { Name = "All Butter Loaf Cake", Description = "Indulge yourself with Entenmann's All Butter Loaf Cake, a delectably dense and delicious cake. The perfect sweet treat for brunches, picnics or parties, this moist golden loaf is sure to please even the most discerning crowd. It can be enjoyed alone, with fruit, or whipped topping. The delicious taste of Entenmann's All Butter Loaf Cake will be sure to leave your friends and family with a smile. The incomparable flavor will make you want more! \r\n\r\n Great for breakfast or dessert: top with berries and whipped cream.  \r\n\r\nThe perfect companion to your morning coffee, afternoon cup of coffee, dessert, or just to satisfy your sweet tooth craving! ", Price = 3.99m, ImageURL = "https://i.ibb.co/hZTbD4q/img3.png" },
                new Cake { Name = "Banana Loaf Cake", Description = "You’ll go bananas for Entenmann’s Banana Bread Loaf Cake! Indulge yourself with this delectably dense and delicious pound cake infused the mouthwatering flavor of bananas. The perfect treat for brunches, picnics or parties, this moist cake is sure to please even the most discerning crowd.\r\n\r\nThis is a seasonal product. Please check store locator for availability.", Price = 5.29m, ImageURL = "https://i.ibb.co/cJZ5YJy/img4.png" },
                new Cake { Name = "Chocolate Chip Crumb Loaf Cake", Description = "Moist cake with chocolate chips topped with a chocolate and sugar crumb topping.", Price = 2.59m, ImageURL = "https://i.ibb.co/gm58RJz/img5.png" },
                new Cake { Name = "Chocolate Loaf Cake", Description = "Entenmann’s classic loaf cake now for chocolate lovers! Entenmann’s Chocolate Loaf is a delectably dense and delicious pound cake. The perfect sweet treat for brunches, picnics or parties, this moist chocolate loaf is sure to please even the most discerning chocolate lover. Enjoy it by the slice or garnish it with fruit and whip cream topping for an oh-so yummy dessert.\r\n\r\nSince 1898, the Entenmann’s name has stood for moist and delicious baked goods. Over the years, families have made it part of their everyday lives and special occasions. It’s a tradition of quality that is found in every Entenmann’s product baked with care every day. Grab a box for your next party, sporting event or snack!", Price = 6.39m, ImageURL = "https://i.ibb.co/4gsWXNH/img6.png" },
                new Cake { Name = "Lemon Loaf Cake", Description = "Craving a simple but sweet treat to add some flavor to your day? Look no further than the Entenmann’s Lemon Loaf Cake. Offering the light citrusy taste of lemon cake, this 11.5oz cake is the perfect snack that will leave you feeling content. Pair with your morning cup of coffee, in the afternoon with a hot cup of tea, or as a late-night snack paired with a cold glass of milk. At any time of day, the Lemon Loaf Cake offers the perfect opportunity to treat yourself with a delicious break from a busy routine. Save it for yourself or share with loved ones to offer a classic cake that’s sure to hit the spot. With more than 120 years of experience in the kitchen, Entenmann’s has upheld its reputation for the finest baked goods and tradition of quality that’s proven with this expertly crafted cake.", Price = 5.89m, ImageURL = "https://i.ibb.co/YTtsMNT/img7.png" },
                new Cake { Name = "Pumpkin Loaf Cake", Description = "Can’t get enough of that great pumpkin flavor? Entenmann’s soft, moist, and delicious Pumpkin Loaf is delicately spiced to celebrate the flavors of the season. Enjoy them by the slice and savor the taste of Entenmann’s classic loaf cake recipe in a mouthwatering pumpkin flavor. Great with coffee, milk, or apple cider or add a dollop of whipped cream to make the perfect dessert.\r\n\r\nSince 1898, the Entenmann’s name has stood for moist and delicious baked goods. Over the years, families have made it part of their everyday lives and special occasions. It’s a tradition of quality that is found in every Entenmann’s product baked with care every day. Grab a box for your next party, sporting event or snack!", Price = 19.89m, ImageURL = "https://i.ibb.co/9qwmS7B/img9.png" },
            };
            context.Cakes.AddRange(cakes);

            var promoCodes = new[]
            {
                new PromoCode { Code = "FIRSTORDER", Percentage = 18, Max = 4.59m, ValidUntil = DateTime.Now.AddMonths(3) },
                new PromoCode { Code = "STUDENTONLY", Percentage = 20, Max = 6.99m, ValidUntil = DateTime.Now.AddDays(3) },
                new PromoCode { Code = "ONLYFRIEND", Percentage = 50, Max = 7.99m, ValidUntil = DateTime.Now.AddMonths(-1) },
            };
            context.PromoCodes.AddRange(promoCodes);

            context.SaveChanges();

            Console.WriteLine("Database seeded successfully.");
        }
    }
}
