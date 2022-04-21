using Webservice.Dtos;
using Webservice.Entities;
using Microsoft.Data.SqlClient;

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

    //     public static void Connect(){
    //         SqlConnection cnn;
    //         string ans="Not Thing";
    //         string connetionString = "Data Source=0.tcp.ap.ngrok.io:10016;Initial Catalog=test;User ID=bank;Password=1234";
    //         cnn = new SqlConnection(connetionString);
    //         try{
    //             cnn.Open();
    //             ans = "TRUE";
    //             cnn.Close();
    //         }
    //         catch (Exception ex){
    //             ans = "FALSE";
    //         }

    //         // return ans;

    //     }
    // }
    
    }
}