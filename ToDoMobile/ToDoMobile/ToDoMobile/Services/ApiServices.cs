using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ToDoMobile.Model;

namespace ToDoMobile.Services
{
    class ApiServices
    {
        public async Task RegisterAsync(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            var Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Model = new User
            {
                firstName = firstName,
                lastName=lastName,
                email=email,
                password=password,
            //    confirmPassword=confirmPassword
            };

            var json = JsonConvert.SerializeObject(Model);

            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json"); 

            await Client.PostAsync("https://d9f9-41-100-129-112.ngrok.io/adduser", content);
        }

        public async Task<bool> LoginAsync( string username ,string password)
        {
            bool operationSuccess = false;
            var keyValues = new List<KeyValuePair<string, string>>
            {
                 new KeyValuePair<string, string>("username",username),
                 new KeyValuePair<string, string>("password",password),
                 new KeyValuePair<string, string>("client_id","ToDoApi"),
                 new KeyValuePair<string, string>("grant_type","password"),
                 new KeyValuePair<string, string>("client_secret","ed6233b7-824f-4667-ba8c-221085cb1091")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, "https://3e93-41-100-166-161.ngrok.io/auth/realms/ToDoAppRealm/protocol/openid-connect/token");

            request.Content = new FormUrlEncodedContent(keyValues);
           
            var client = new HttpClient();
            
            var response=await client.SendAsync(request);
            if (response.IsSuccessStatusCode) {

                operationSuccess = true;
                
            }
            return operationSuccess;


            // Debug.WriteLine(await response.Content.ReadAsStringAsync);
        }
    }
}
