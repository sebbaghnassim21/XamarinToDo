using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMobile.Services
{
    class ApiServices
    {
        public void RegisterAsync(string email, string password, string confirmPassword)
        {
           
        }

        public async Task LoginAsync( string username ,string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                 new KeyValuePair<string, string>("username",username),
                 new KeyValuePair<string, string>("password",password),
                 new KeyValuePair<string, string>("client_id","ToDoApi"),
                 new KeyValuePair<string, string>("grant_type","password")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, "https://f04c-41-101-231-66.ngrok.io/auth/realms/ToDoAppRealm/protocol/openid-connect/token");

            request.Content = new FormUrlEncodedContent(keyValues);
            var client = new HttpClient();
            var response=await client.SendAsync(request);

            Debug.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
