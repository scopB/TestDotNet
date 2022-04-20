using Webservice.Entities;
using Webservice.Dtos;

namespace Webservice.IInMemitemss{
    public interface IItemsRepository
    {
        IEnumerable<Items> GetItems();
        Items GetItems(string liceneplatess);
        
        IEnumerable<Items> FindItem(CreateItemDto Search);
    }
}