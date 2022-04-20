using Webservice.Dtos;
using Webservice.Entities;

namespace Webservice{
    public static class Extensions{
        public static ItemDto AsDto(this Items item){
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                liceneplate = item.liceneplate,
                days = item.days 
            };
        }
    }
}