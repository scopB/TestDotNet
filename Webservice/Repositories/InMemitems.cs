using Webservice.Entities;
using System.Collections.Generic;
using System.Linq;
using Webservice.IInMemitemss;
using Webservice.Dtos;

namespace Webservice.Repositories{
    public class InMemitems : IItemsRepository
    {
        private readonly List<Items> items = new()
        {
            new Items{
                Id = Guid.NewGuid(),
                Name = "Ford",
                liceneplate = "HH332",
                days = DateTimeOffset.UtcNow,
            },
            new Items{
                Id = Guid.NewGuid(),
                Name = "Mazda",
                liceneplate = "HH332",
                days = DateTimeOffset.UtcNow,
            },
            new Items{
                Id = Guid.NewGuid(),
                Name = "Benz",
                liceneplate = "HV332",
                days = DateTimeOffset.UtcNow,
            }
        };

        public IEnumerable<Items> FindItem(CreateItemDto Search)
        {
            return items.Where(item => Equals(item.liceneplate, Search.Search_text));
        }

        public IEnumerable<Items> GetItems()
        {
            return items;
        }

        public Items GetItems(string liceneplatess)
        {
            return items.Where(item => Equals(item.liceneplate, liceneplatess)).SingleOrDefault();
        }

    }
}