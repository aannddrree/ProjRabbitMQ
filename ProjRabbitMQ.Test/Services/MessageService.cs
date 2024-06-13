using Newtonsoft.Json;
using ProjRabbitMQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjRabbitMQ.Consumer.Services
{
    public class MessageService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<Message> PostMessage(Message bank)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(bank), Encoding.UTF8, "application/json");
                HttpResponseMessage respose = await MessageService._httpClient.PostAsync("https://localhost:7195/api/Messages", content);
                respose.EnsureSuccessStatusCode();
                string bankReturn = await respose.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Message>(bankReturn);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
