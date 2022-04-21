using Microsoft.AspNetCore.Mvc;
using Webservice.Repositories;
using Webservice.Entities;
using Webservice.Dtos;
using Webservice.IInMemitemss;
using Microsoft.Data.SqlClient;

namespace Webservice.Controllers{
    
    [ApiController]
    [Route("item")]
    public class itemcontroller : ControllerBase{
        private readonly IItemsRepository repository;

        public itemcontroller(IItemsRepository repository){
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }

        [HttpGet("{liceneplatess}")]
        public ActionResult<ItemDto> GetItems(string liceneplatess){
            var item = repository.GetItems(liceneplatess);
            if(item is null){
                return NotFound();
            }
            return item.AsDto();
        }

        [HttpPost("find")]
        public IEnumerable<ItemDto> FindItem(CreateItemDto text_item){
            
            var ans = repository.FindItem(text_item).Select(item => item.AsDto());
            return ans;
        }

        [HttpGet("sql")]
        public string Connectsql(){
            string ans = Connect();
            return ans;
        }

        public static string Connect(){
            SqlConnection cnn;
            string ans="";
            datapull testdata = new datapull();

            string connetionString = "Data Source=0.tcp.ap.ngrok.io,12065;Initial Catalog=test;User ID=bank;Password=1234";
            cnn = new SqlConnection(connetionString);
            try{
                // cnn.Open();
                // ans = "TRUE";
                string Ostring = "Select * from Table_7";
                SqlCommand oCmd = new SqlCommand(Ostring, cnn);
                cnn.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader()){
                    // while(oReader.Read()){
                    //     // testdata.Name = oReader.ToString();
                    //     testdata.Name = oReader["Name"].ToString();
                    //     ans = ans + testdata.Name;
                    // 
                    testdata.Name = oReader.GetData(1).ToString();
                }
                cnn.Close();
                // ans = ans + "TRUE "+ testdata.Name;
            }
            catch (Exception ex){
                ans = "FALSE"+ex;
            }

            return testdata.Name;

        }
    }
}
