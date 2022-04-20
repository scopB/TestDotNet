namespace Webservice.Dtos{
    public record CreateItemDto{
        public string Search_text {get; init;} = string.Empty;
    }
}