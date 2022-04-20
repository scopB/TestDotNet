namespace Webservice.Dtos{
    public record ItemDto{

        public Guid Id {get; init;}
        public string Name {get; init;} = string.Empty;
        public string liceneplate {get; init;} = string.Empty;
        public DateTimeOffset days {get; init;}
    }
}