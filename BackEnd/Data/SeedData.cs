using BackEnd.Models;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Data
{
    public static class SeedData
    {
        public static void Init(Database db)
        {

            if (!db.Users.Any())
            {
                db.Users.Add(new User
                {
                    Username = "admin",
                    Password = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    Role = "Admin"
                });

                db.SaveChanges();
            }

            if (db.Products.Any()) return;

            var products = new List<Product>
            {
                
                
            // ===============================
            // QUẦN ÁO (1 - 25)
            // ===============================
            new Product{Id=1, Name="Áo thể thao Mixi DryFit", Price=189000, Image="/images/Quần Áo (1-25)/1.jpg", Rating=4.2, ReviewCount=120},
            new Product{Id=2, Name="Áo bóng đá Mixi Pro", Price=249000, Image="/images/Quần Áo (1-25)/2.jpg", Rating=4.3, ReviewCount=210},
            new Product{Id=3, Name="Áo tập gym Mixi Flex", Price=219000, Image="/images/Quần Áo (1-25)/3.jpg", Rating=4.4, ReviewCount=340},
            new Product{Id=4, Name="Áo hoodie Mixi Sport", Price=399000, Image="/images/Quần Áo (1-25)/4.jpg", Rating=4.5, ReviewCount=520},
            new Product{Id=5, Name="Áo khoác gió Mixi Wind", Price=459000, Image="/images/Quần Áo (1-25)/5.jpg", Rating=4.4, ReviewCount=460},
            new Product{Id=6, Name="Áo ba lỗ tập gym", Price=149000, Image="/images/Quần Áo (1-25)/6.jpg", Rating=4.1, ReviewCount=98},
            new Product{Id=7, Name="Áo polo thể thao", Price=269000, Image="/images/Quần Áo (1-25)/7.jpg", Rating=4.3, ReviewCount=180},
            new Product{Id=8, Name="Áo chạy bộ QuickRun", Price=199000, Image="/images/Quần Áo (1-25)/8.jpg", Rating=4.2, ReviewCount=165},
            new Product{Id=9, Name="Quần short thể thao", Price=179000, Image="/images/Quần Áo (1-25)/9.jpg", Rating=4.0, ReviewCount=90},
            new Product{Id=10, Name="Quần jogger Mixi", Price=329000, Image="/images/Quần Áo (1-25)/10.jpg", Rating=4.5, ReviewCount=620},
            new Product{Id=11, Name="Quần tập gym FlexFit", Price=239000, Image="/images/Quần Áo (1-25)/11.jpg", Rating=4.3, ReviewCount=210},
            new Product{Id=12, Name="Áo thể thao nữ Mixi", Price=189000, Image="/images/Quần Áo (1-25)/12.jpg", Rating=4.2, ReviewCount=175},
            new Product{Id=13, Name="Quần legging nữ", Price=259000, Image="/images/Quần Áo (1-25)/13.jpg", Rating=4.4, ReviewCount=310},
            new Product{Id=14, Name="Áo tập yoga", Price=219000, Image="/images/Quần Áo (1-25)/14.jpg", Rating=4.3, ReviewCount=260},
            new Product{Id=15, Name="Áo khoác training", Price=439000, Image="/images/Quần Áo (1-25)/15.jpg", Rating=4.5, ReviewCount=420},
            new Product{Id=16, Name="Áo chạy bộ Reflect", Price=209000, Image="/images/Quần Áo (1-25)/16.jpg", Rating=4.1, ReviewCount=120},
            new Product{Id=17, Name="Quần thể thao Mixi Run", Price=229000, Image="/images/Quần Áo (1-25)/17.jpg", Rating=4.3, ReviewCount=200},
            new Product{Id=18, Name="Áo gym ProFit", Price=219000, Image="/images/Quần Áo (1-25)/18.jpg", Rating=4.4, ReviewCount=270},
            new Product{Id=19, Name="Quần short training", Price=179000, Image="/images/Quần Áo (1-25)/19.jpg", Rating=4.2, ReviewCount=150},
            new Product{Id=20, Name="Áo thể thao SpeedFit", Price=199000, Image="/images/Quần Áo (1-25)/20.jpg", Rating=4.1, ReviewCount=110},
            new Product{Id=21, Name="Áo hoodie Mixi Basic", Price=359000, Image="/images/Quần Áo (1-25)/21.jpg", Rating=4.5, ReviewCount=550},
            new Product{Id=22, Name="Áo thể thao chạy bộ", Price=209000, Image="/images/Quần Áo (1-25)/22.jpg", Rating=4.2, ReviewCount=160},
            new Product{Id=23, Name="Quần gym nữ Fit", Price=239000, Image="/images/Quần Áo (1-25)/23.jpg", Rating=4.4, ReviewCount=295},
            new Product{Id=24, Name="Áo training Elite", Price=299000, Image="/images/Quần Áo (1-25)/24.jpg", Rating=4.3, ReviewCount=240},
            new Product{Id=25, Name="Áo thể thao Mixi Sport", Price=175000, Image="/images/Quần Áo (1-25)/25.jpg", Rating=4.4, ReviewCount=310},

            // ===============================
            // GIÀY (26 - 50)
            // ===============================
            new Product{Id=26, Name="Giày chạy bộ Mixi Speed", Price=899000, Image="/images/Giày (26-50)/26.jpg", Rating=4.5, ReviewCount=820},
            new Product{Id=27, Name="Giày bóng đá Mixi Predator", Price=1059000, Image="/images/Giày (26-50)/27.jpg", Rating=4.6, ReviewCount=950},
            new Product{Id=28, Name="Giày training Pro", Price=799000, Image="/images/Giày (26-50)/28.jpg", Rating=4.4, ReviewCount=710},
            new Product{Id=29, Name="Giày gym Flex", Price=729000, Image="/images/Giày (26-50)/29.jpg", Rating=4.3, ReviewCount=600},
            new Product{Id=30, Name="Giày chạy bộ AirRun", Price=939000, Image="/images/Giày (26-50)/30.jpg", Rating=4.5, ReviewCount=870},
            new Product{Id=31, Name="Giày futsal Mixi", Price=689000, Image="/images/Giày (26-50)/31.jpg", Rating=4.3, ReviewCount=560},
            new Product{Id=32, Name="Giày training Elite", Price=819000, Image="/images/Giày (26-50)/32.jpg", Rating=4.4, ReviewCount=620},
            new Product{Id=33, Name="Giày bóng rổ JumpPro", Price=999000, Image="/images/Giày (26-50)/33.jpg", Rating=4.5, ReviewCount=780},
            new Product{Id=34, Name="Giày tennis CourtMax", Price=879000, Image="/images/Giày (26-50)/34.jpg", Rating=4.4, ReviewCount=690},
            new Product{Id=35, Name="Giày chạy bộ UltraRun", Price=959000, Image="/images/Giày (26-50)/35.jpg", Rating=4.5, ReviewCount=840},
            new Product{Id=36, Name="Giày gym LiftPro", Price=799000, Image="/images/Giày (26-50)/36.jpg", Rating=4.3, ReviewCount=610},
            new Product{Id=37, Name="Giày bóng đá SpeedKick", Price=1129000, Image="/images/Giày (26-50)/37.jpg", Rating=4.6, ReviewCount=980},
            new Product{Id=38, Name="Giày chạy bộ Mixi Light", Price=899000, Image="/images/Giày (26-50)/38.jpg", Rating=4.4, ReviewCount=720},
            new Product{Id=39, Name="Giày training AirFit", Price=769000, Image="/images/Giày (26-50)/39.jpg", Rating=4.3, ReviewCount=650},
            new Product{Id=40, Name="Giày chạy bộ CarbonRun", Price=1299000, Image="/images/Giày (26-50)/40.jpg", Rating=4.7, ReviewCount=1200},
            new Product{Id=41, Name="Giày gym Stability", Price=829000, Image="/images/Giày (26-50)/41.jpg", Rating=4.4, ReviewCount=700},
            new Product{Id=42, Name="Giày bóng rổ Slam", Price=989000, Image="/images/Giày (26-50)/42.jpg", Rating=4.5, ReviewCount=880},
            new Product{Id=43, Name="Giày tennis ProCourt", Price=899000, Image="/images/Giày (26-50)/43.jpg", Rating=4.4, ReviewCount=730},
            new Product{Id=44, Name="Giày futsal Street", Price=659000, Image="/images/Giày (26-50)/44.jpg", Rating=4.2, ReviewCount=540},
            new Product{Id=45, Name="Giày chạy bộ SpeedLite", Price=879000, Image="/images/Giày (26-50)/45.jpg", Rating=4.4, ReviewCount=690},
            new Product{Id=46, Name="Giày gym CoreFit", Price=749000, Image="/images/Giày (26-50)/46.jpg", Rating=4.3, ReviewCount=610},
            new Product{Id=47, Name="Giày training Alpha", Price=819000, Image="/images/Giày (26-50)/47.jpg", Rating=4.4, ReviewCount=670},
            new Product{Id=48, Name="Giày chạy bộ MaxRun", Price=959000, Image="/images/Giày (26-50)/48.jpg", Rating=4.5, ReviewCount=820},
            new Product{Id=49, Name="Giày thể thao Mixi Sport", Price=839000, Image="/images/Giày (26-50)/49.jpg", Rating=4.3, ReviewCount=640},
            new Product{Id=50, Name="Giày chạy bộ UltraMix", Price=999000, Image="/images/Giày (26-50)/50.jpg", Rating=4.5, ReviewCount=910},

            // ===============================
            // DỤNG CỤ (51 - 75)
            // ===============================
            new Product{Id=51, Name="Bóng đá Mixi Pro Ball", Price=259000, Image="/images/Dụng Cụ (51-75)/51.jpg", Rating=4.4, ReviewCount=330},
            new Product{Id=52, Name="Bóng rổ Mixi Court", Price=289000, Image="/images/Dụng Cụ (51-75)/52.jpg", Rating=4.3, ReviewCount=290},
            new Product{Id=53, Name="Thảm yoga Mixi", Price=189000, Image="/images/Dụng Cụ (51-75)/53.jpg", Rating=4.5, ReviewCount=420},
            new Product{Id=54, Name="Găng tay tập gym Mixi Grip", Price=149000, Image="/images/Dụng Cụ (51-75)/54.jpg", Rating=4.2, ReviewCount=210},
            new Product{Id=55, Name="Dây kháng lực Fitness", Price=99000, Image="/images/Dụng Cụ (51-75)/55.jpg", Rating=4.3, ReviewCount=250},
            new Product{Id=56, Name="Con lăn tập bụng", Price=139000, Image="/images/Dụng Cụ (51-75)/56.jpg", Rating=4.4, ReviewCount=310},
            new Product{Id=57, Name="Bình nước thể thao Mixi", Price=79000, Image="/images/Dụng Cụ (51-75)/57.jpg", Rating=4.1, ReviewCount=180},
            new Product{Id=58, Name="Tạ tay 5kg", Price=299000, Image="/images/Dụng Cụ (51-75)/58.jpg", Rating=4.5, ReviewCount=470},
            new Product{Id=59, Name="Tạ tay 10kg", Price=459000, Image="/images/Dụng Cụ (51-75)/59.jpg", Rating=4.6, ReviewCount=520},
            new Product{Id=60, Name="Dây nhảy thể lực", Price=59000, Image="/images/Dụng Cụ (51-75)/60.jpg", Rating=4.2, ReviewCount=230},
            new Product{Id=61, Name="Đai lưng gym", Price=239000, Image="/images/Dụng Cụ (51-75)/61.jpg", Rating=4.4, ReviewCount=340},
            new Product{Id=62, Name="Balo thể thao Mixi", Price=329000, Image="/images/Dụng Cụ (51-75)/62.jpg", Rating=4.3, ReviewCount=300},
            new Product{Id=63, Name="Túi gym Mixi", Price=289000, Image="/images/Dụng Cụ (51-75)/63.jpg", Rating=4.4, ReviewCount=360},
            new Product{Id=64, Name="Tạ đòn mini", Price=499000, Image="/images/Dụng Cụ (51-75)/64.jpg", Rating=4.5, ReviewCount=410},
            new Product{Id=65, Name="Ghế tập bụng", Price=899000, Image="/images/Dụng Cụ (51-75)/65.jpg", Rating=4.6, ReviewCount=480},
            new Product{Id=66, Name="Xà đơn treo cửa", Price=259000, Image="/images/Dụng Cụ (51-75)/66.jpg", Rating=4.4, ReviewCount=350},
            new Product{Id=67, Name="Dây tập TRX", Price=399000, Image="/images/Dụng Cụ (51-75)/67.jpg", Rating=4.5, ReviewCount=420},
            new Product{Id=68, Name="Bóng tập yoga", Price=159000, Image="/images/Dụng Cụ (51-75)/68.jpg", Rating=4.3, ReviewCount=260},
            new Product{Id=69, Name="Bình shaker protein", Price=69000, Image="/images/Dụng Cụ (51-75)/69.jpg", Rating=4.2, ReviewCount=210},
            new Product{Id=70, Name="Thảm tập gym Pro", Price=249000, Image="/images/Dụng Cụ (51-75)/70.jpg", Rating=4.4, ReviewCount=300},
            new Product{Id=71, Name="Băng cổ tay gym", Price=79000, Image="/images/Dụng Cụ (51-75)/71.jpg", Rating=4.2, ReviewCount=200},
            new Product{Id=72, Name="Đai bảo vệ đầu gối", Price=129000, Image="/images/Dụng Cụ (51-75)/72.jpg", Rating=4.3, ReviewCount=230},
            new Product{Id=73, Name="Con lăn massage cơ", Price=179000, Image="/images/Dụng Cụ (51-75)/73.jpg", Rating=4.4, ReviewCount=260},
            new Product{Id=74, Name="Dây kháng lực Pro", Price=119000, Image="/images/Dụng Cụ (51-75)/74.jpg", Rating=4.3, ReviewCount=240},
            new Product{Id=75, Name="Găng tay boxing", Price=339000, Image="/images/Dụng Cụ (51-75)/75.jpg", Rating=4.5, ReviewCount=390},

            // ===============================
            // THỰC PHẨM (76 - 100)
            // ===============================
            new Product{Id=76, Name="Thanh năng lượng Mixi Bar", Price=36000, Image="/images/Thực Phẩm (76-100)/76.jpg", Rating=4.2, ReviewCount=180},
            new Product{Id=77, Name="Thanh protein chocolate", Price=45000, Image="/images/Thực Phẩm (76-100)/77.jpg", Rating=4.3, ReviewCount=240},
            new Product{Id=78, Name="Thanh protein dâu", Price=45000, Image="/images/Thực Phẩm (76-100)/78.jpg", Rating=4.2, ReviewCount=210},
            new Product{Id=79, Name="Bột whey protein 500g", Price=399000, Image="/images/Thực Phẩm (76-100)/79.jpg", Rating=4.6, ReviewCount=1200},
            new Product{Id=80, Name="Bột whey protein 1kg", Price=699000, Image="/images/Thực Phẩm (76-100)/80.jpg", Rating=4.7, ReviewCount=2100},
            new Product{Id=81, Name="Khô gà lá chanh", Price=99000, Image="/images/Thực Phẩm (76-100)/81.jpg", Rating=5.0, ReviewCount=12000},
            new Product{Id=82, Name="Khô bò cay", Price=129000, Image="/images/Thực Phẩm (76-100)/82.jpg", Rating=4.6, ReviewCount=3200},
            new Product{Id=83, Name="Khô mực nướng", Price=159000, Image="/images/Thực Phẩm (76-100)/83.jpg", Rating=5.0, ReviewCount=9800},
            new Product{Id=84, Name="Ngũ cốc protein", Price=189000, Image="/images/Thực Phẩm (76-100)/84.jpg", Rating=4.3, ReviewCount=410},
            new Product{Id=85, Name="Bơ đậu phộng gym", Price=119000, Image="/images/Thực Phẩm (76-100)/85.jpg", Rating=4.5, ReviewCount=620},
            new Product{Id=86, Name="Yến mạch nguyên chất", Price=89000, Image="/images/Thực Phẩm (76-100)/86.jpg", Rating=4.4, ReviewCount=520},
            new Product{Id=87, Name="Granola mix hạt", Price=139000, Image="/images/Thực Phẩm (76-100)/87.jpg", Rating=4.5, ReviewCount=640},
            new Product{Id=88, Name="Thanh năng lượng dừa", Price=42000, Image="/images/Thực Phẩm (76-100)/88.jpg", Rating=4.2, ReviewCount=200},
            new Product{Id=89, Name="Thanh protein caramel", Price=47000, Image="/images/Thực Phẩm (76-100)/89.jpg", Rating=4.3, ReviewCount=230},
            new Product{Id=90, Name="Snack protein Mixi", Price=69000, Image="/images/Thực Phẩm (76-100)/90.jpg", Rating=4.6, ReviewCount=1800},
            new Product{Id=91, Name="Bánh protein gym", Price=59000, Image="/images/Thực Phẩm (76-100)/91.jpg", Rating=4.2, ReviewCount=210},
            new Product{Id=92, Name="Hạt hạnh nhân rang", Price=129000, Image="/images/Thực Phẩm (76-100)/92.jpg", Rating=4.4, ReviewCount=450},
            new Product{Id=93, Name="Hạt điều rang muối", Price=119000, Image="/images/Thực Phẩm (76-100)/93.jpg", Rating=4.3, ReviewCount=390},
            new Product{Id=94, Name="Trà detox giảm mỡ", Price=159000, Image="/images/Thực Phẩm (76-100)/94.jpg", Rating=4.2, ReviewCount=310},
            new Product{Id=95, Name="Nước điện giải thể thao", Price=39000, Image="/images/Thực Phẩm (76-100)/95.jpg", Rating=4.1, ReviewCount=180},
            new Product{Id=96, Name="Bột tăng cơ Mass 1kg", Price=559000, Image="/images/Thực Phẩm (76-100)/96.jpg", Rating=4.6, ReviewCount=2500},
            new Product{Id=97, Name="Bột tăng cơ Mass 3kg", Price=1360000, Image="/images/Thực Phẩm (76-100)/97.jpg", Rating=4.7, ReviewCount=4200},
            new Product{Id=98, Name="Thanh protein Mixi Pro", Price=49000, Image="/images/Thực Phẩm (76-100)/98.jpg", Rating=4.4, ReviewCount=620},
            new Product{Id=99, Name="Khô gà lá chanh", Price=89000, Image="/images/Thực Phẩm (76-100)/99.jpg", Rating=5.0, ReviewCount=12500},
            new Product{Id=100, Name="Khô mực nướng", Price=159000, Image="/images/Thực Phẩm (76-100)/100.jpg", Rating=5.0, ReviewCount=11200}
            };

            using var transaction = db.Database.BeginTransaction();

            db.Database.OpenConnection();

            db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products ON");

            db.Products.AddRange(products);
            db.SaveChanges();

            db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products OFF");

            transaction.Commit();

        }
    }
}