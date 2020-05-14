using SmartCityDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCityDataAccess.Supporting_files;

namespace SmartCityDataAccess.MockService
{
    public static class MockDataService
    {
        public static List<DTOEvent> GetMockMovies()
        {
            var list = new List<DTOEvent>();

            DTOEvent bloodshot = new DTOEvent
            {
                Id = 0,
                Name = "Бладшот",
                Description = "Военный Рэй Гаррисон возвращается из очередной горячей точки к любимой красавице-жене. Супруги проводят отпуск в Европе, но счастье длится недолго — террористы, не сумев вытянуть из Рэя нужную им информацию, убивают жену, а затем и его самого. Но вскоре корпорация RST возвращает его к жизни. Армия нанороботов в крови превратила Рэя в бессмертного Бладшота, и теперь солдат наделен сверхсилой и способностью мгновенно самоисцеляться, вот только память оставляет желать лучшего. Но вскоре воспоминания о последних мгновениях жизни возвращаются, и Бладшот отправляется мстить за смерть жены.",
                Rating = (decimal)5.7,
                Picture = Converter.ConvertedImage(Resources.Bloodshot)
            };

            DTOEvent aquaman = new DTOEvent
            {
                Id = 1,
                Name = "Аквамен",
                Description = "Действие фильма разворачивается в необъятном и захватывающем подводном мире семи морей, а сюжет знакомит зрителей с историей происхождения получеловека-полуатланта Артура Карри и ключевыми событиями его жизни — теми, что заставят его не только столкнуться с самим собой, но и выяснить, достоин ли он быть тем, кем ему суждено… царем!",
                Rating = (decimal)5.7,
                Picture = Converter.ConvertedImage(Resources.Aquaman)
            };

            list.Add(bloodshot);
            list.Add(aquaman);

            return list;
        }

        public static DTOBuilding GetBuildingById()
        {
            var building = new DTOBuilding();

            building.Id = 0;
            building.Name = "Кинотеатр Кристалл";
            building.Country = "Россия";
            building.Region = "Пермский Край";
            building.City = "Пермь";
            building.Street = "Ленина";
            building.House = "54";
            
            var cinemas = new List<DTOArtOrganization>();
            cinemas.Add(new DTOArtOrganization{ Id = 0, Name = "Кристалл", Rating = (Decimal?)4.23, Website = "https://cinema.perm.ru/cinemas/kristall-imax-veri-velli/", WorkHours = "09:00-01:00"});

            var restaurants = new List<DTORestaurant>();
            restaurants.Add(new DTORestaurant { Id = 0, Name = "Leroy Cafe", AverageCheck = 890, NumberOfEmptyTables = 5, Rating = (decimal?)4.7, Website = "", WorkHours = "10:00-23:00" });

            building.Cinemas = cinemas;
            building.Restaurants = restaurants;

            return building;
        }
    }
}
