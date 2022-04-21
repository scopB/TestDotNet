
namespace Webservice.Entities
{
    public record datapull{
        public string Name {get; set;}
        public DateTime Datetime{get; init;}
    }
    public record Items{

        public Guid Id {get; init;}
        public string Name {get; init;} = string.Empty;
        public string liceneplate {get; init;} = string.Empty;
        public DateTimeOffset days {get; init;}
    }
}