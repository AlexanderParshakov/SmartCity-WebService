using SmartCityDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SmartCityDataAccess.MockService;

namespace SmartCityDataAccess.DataAccess
{
    public class Repository
    {
        private static SmartCityEntities GetNewContext()
        {
            return new SmartCityEntities();
        }

        public static List<DTOEvent> GetMovies()
        {
            using (var context = GetNewContext())
            {
                var list = new List<DTOEvent>();

                list = context.Events
                        .AsNoTracking()
                        .Include(x => x.Showings)
                        .OrderByDescending(x => x.Rating)
                        .OrderByDescending(x => x.Name)
                        .Where(x => x.EventType == "Фильм")
                        .Select(x =>
                        new DTOEvent
                        {
                            Id = x.IDEvent,
                            Name = x.Name,
                            Description = x.Description,
                            Rating = x.Rating,
                            Website = x.Website,
                            Showings = x.Showings.Select(s => new DTOShowing { Id = s.IDShowing, Description = s.Description, ReleaseDate = s.ReleaseDate, EndDate = s.EndDate })
                            .ToList()
                        })
                        .ToList();

                if (list.Count == 0)
                {
                    return MockDataService.GetMockMovies();
                }

                return list;
            }
        }

        #region Building Info

        public static DTOBuilding GetBuildingById(int id)
        {
            using (var context = GetNewContext())
            {
                var list = new List<DTOBuilding>();

                list = context.Buildings
                    .AsNoTracking()
                    .Where(x => x.IDBuilding == id)
                    .Select(x =>
                    new DTOBuilding
                    {
                        Id = x.IDBuilding,
                        Name = x.Name,
                        Country = x.Country,
                        Region = x.Region,
                        City = x.City,
                        Street = x.Street,
                        House = x.House,
                        Cinemas = x.ArtOrganizations
                            .Where(org => org.OrganizationType == "Кинотеатр")
                            .Select(c => new DTOArtOrganization { Id = c.IDOrganization, Name = c.Name, Rating = c.ComfortabilityRating, Website = c.Website, WorkHours = c.WorkHours }).ToList(),
                        Restaurants = context.Restaurants.Select(r => new DTORestaurant { Id = r.IDOrganization, Name = r.Name, Rating = r.Rating, Website = r.Website, AverageCheck = r.AverageCheck, WorkHours = r.WorkHours, NumberOfEmptyTables = r.NumberOfEmptyTables }).ToList()
                    })
                    .ToList();

                if (list.Count == 0)
                {
                    return MockDataService.GetBuildingById();
                }

                return list.FirstOrDefault();
            }
        }

        #endregion
    }
}
