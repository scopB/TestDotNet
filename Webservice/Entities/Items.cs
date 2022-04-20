
namespace Webservice.Entities
{

    // private String Getconnect(){
    //     string cs = @"Data Source"
    // }
    public record Items{

        public Guid Id {get; init;}
        public string Name {get; init;} = string.Empty;
        public string liceneplate {get; init;} = string.Empty;
        public DateTimeOffset days {get; init;}
    }
}