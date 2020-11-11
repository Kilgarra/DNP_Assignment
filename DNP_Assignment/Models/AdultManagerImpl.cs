using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNP_Assignment.Models
{
    public class AdultManagerImpl:AdultManager
    {
        private HttpClient client;
        public AdultManagerImpl()
        {
            client=new HttpClient();
        }
        public async Task addAdult(Adult adult)
        {
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content =new StringContent(
                adultSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:5002/adults", content);
            if (response.StatusCode==HttpStatusCode.InternalServerError)
            {
                throw new Exception(response.Content.ToString());
            }
        }
        public async Task<List<Adult>> getAllAdults()
        {
            try
            {
                string response = await client.GetStringAsync("http://localhost:5002/adults");
                List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(response.ToString());
                
                return adults;

            }
            catch (Exception e)
            {
                Console.WriteLine("gsdf");
                throw;
            }
           
        }
        
    }
}
