using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpPost("GetSettingService")]
        public async Task<IActionResult> PostAsync()
        {
            Dictionary<string, string> Params = new Dictionary<string, string>()
            {
                { "AgentId","8"},
                { "AgentPassword","AgentTest"},
                { "AgentName","AgentTest"},
                { "RequestType","GetSettingServices"},
            };

            using var httpClient = new HttpClient();
            var responseTask = await httpClient.PostAsync("https://processing.hgg-pay.kz/home/index", new FormUrlEncodedContent(Params));
            var json = await responseTask.Content.ReadAsStringAsync();
            return Ok(json);
        }

        [HttpPost("CalculatedSum")]
        public async Task<IActionResult> Post()
        {
            Dictionary<string, string> Params = new Dictionary<string, string>()
            {
                { "AgentId","8"},
                { "AgentPassword","AgentTest"},
                { "AgentName","AgentTest"},
                { "RequestType","CalculatedSum"},
                { "Service","11"},
                { "Amount","2" },
                { "Currency","RUB" }
            };

            using var httpClient = new HttpClient();
            var responseTask = await httpClient.PostAsync("https://processing.hgg-pay.kz/home/index", new FormUrlEncodedContent(Params));
            var json = await responseTask.Content.ReadAsStringAsync();
            return Ok(json);
        }
    }
}