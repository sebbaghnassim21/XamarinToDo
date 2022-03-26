using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

            await Client.PostAsync("https://0cfd-85-234-131-122.ngrok.io/adduser", content);
        }

        public async Task<string> LoginAsync( string username ,string password)
        {
#pragma warning disable CS0219 // La variable 'operationSuccess' est assignée, mais sa valeur n'est jamais utilisée
            bool operationSuccess = false;
#pragma warning restore CS0219 // La variable 'operationSuccess' est assignée, mais sa valeur n'est jamais utilisée
            var keyValues = new List<KeyValuePair<string, string>>
            {
                 new KeyValuePair<string, string>("username",username),
                 new KeyValuePair<string, string>("password",password),
                 new KeyValuePair<string, string>("client_id","ToDoApi"),
                 new KeyValuePair<string, string>("grant_type","password"),
                 new KeyValuePair<string, string>("client_secret","ed6233b7-824f-4667-ba8c-221085cb1091")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, "https://712b-85-234-131-122.ngrok.io/auth/realms/ToDoAppRealm/protocol/openid-connect/token");

            request.Content = new FormUrlEncodedContent(keyValues);
           
            var client = new HttpClient();
            
            var response=await client.SendAsync(request);

            var jwt = await response.Content.ReadAsStringAsync();
            JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);
            var accesstoken = jwtDynamic.Value<string>("access_token"); 
            Debug.WriteLine(jwt);
            return accesstoken;
        }

        public async Task<List<TaskToDo>> GetTaskToDo(string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await client.GetStringAsync("https://0cfd-85-234-131-122.ngrok.io/tasks/search/findTaskByUser?user=1");
            var Task=JsonConvert.DeserializeObject<List<TaskToDo>>(json);
            return Task;
        }
    }
}
