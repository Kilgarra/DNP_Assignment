using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DNP_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNP_Assignment.Data
{
    public class CloudUserService : IUserService
    {

        private HttpClient client;
        public CloudUserService() {
           client= new HttpClient();
        }


        public async Task<User> ValidateUser(string userName, string password)
        {
            string query = "?username=" + userName + "&password=" + password;
            string response = await client.GetStringAsync("http://localhost:5002/user"+query);

            try
            {
                User user = JsonSerializer.Deserialize<User>(response);
                if (user.UserName=="User not found" || user.UserName=="Incorrect password")
                {
                    throw new Exception(user.UserName);
                }

                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}